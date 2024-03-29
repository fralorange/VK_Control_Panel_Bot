﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using VK_Control_Panel_Bot.Controls;
using VkNet;

namespace VK_Control_Panel_Bot
{
    public partial class MainForm : Form
    {
        //UI settings//
        private bool _dragging = false;
        private Point _start_point = new(0, 0);
        //
        private static MainForm? form = null;
        //
        VkApi? _api;

        public MainForm()
        {
            InitializeComponent();
            form = this;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Accounts.txt"))
            {
                Thread logThread = new(() => _api = Auth.Log(File.ReadAllLines("Accounts.txt")[0]));
                logThread.Start();
                Thread StatusThread = new(() => TextAnimations.Delaying("Welcome!"));
                StatusThread.Start();
                LoginPanel.Hide();
                MenuShow(true);
            }
        }

        public static void UpdateOutput(string s)
        {
            if (form != null)
            {
                form.Output.Invoke((MethodInvoker)delegate
                {
                    form.Output.Text = s;
                });
            }
        }

        public static void MenuShow(bool enable)
        {
            if (form != null)
            {
                form.StripMenu.Invoke((MethodInvoker)delegate
                {
                    form.StripMenu.Visible = enable;
                });
            }
        }

        public static void LoginShow(bool enable)
        {
            if (form != null)
            {
                form.LoginPanel.Invoke((MethodInvoker)delegate
                {
                    form.LoginPanel.Visible = enable;
                });
            }
        }

        public static void CreateChildForm(Form child,bool dialog)
        {
            if (form != null)
            {
                form.Invoke((MethodInvoker)delegate
                {
                    child.StartPosition = FormStartPosition.CenterParent;
                    if (dialog)
                        child.ShowDialog(form);
                    else
                        child.Show(form);
                });
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
            LoginPanel.Hide();
            Thread logThread = new(() => _api = Auth.Log(LoginBox.Text, PassBox.Text,RememberMeButton.Checked));
            logThread.Start();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Iconified_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
            WindowState = FormWindowState.Minimized;
        }

        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new(e.X, e.Y);
        }

        private void UpPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new(p.X - _start_point.X, p.Y - _start_point.Y);
            }
        }

        private void UpPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            PassBox.PasswordChar = (PassBox.PasswordChar == '*') ? PassBox.PasswordChar = '\0' : PassBox.PasswordChar = '*';
        }

        private void MessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!MdiChildren.Any())
            {
                Messages messages = new(api: _api);
                messages.MdiParent = form;
                messages.Location = new Point(12, 46);
                messages.Show();
            }
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Accounts.txt")) File.Delete("Accounts.txt");
            _api!.LogOut();
            MenuShow(false);
            LoginShow(true);
            UpdateOutput("");
            if (form!.MdiChildren.Length > 0) ActiveMdiChild.Close();
        }
    }
}

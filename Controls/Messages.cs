﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VK_Control_Panel_Bot.Extensions;
using VkNet;
using VkNet.Enums.Filters;

namespace VK_Control_Panel_Bot.Controls
{
    public partial class Messages : Form
    {
        readonly List<Panel> borderList = new();
        readonly List<Panel> panels = new();
        readonly List<Button> buttons = new();
        private VkApi _api;
        public Messages(VkApi api)
        {
            _api = api;
            InitializeComponent();
        }

        private void Messages_Layout(object sender, LayoutEventArgs e)
        {
            borderList.ForEach(delegate (Panel p)
            {
                p.BringToFront();
            });
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            borderList.AddMultiple(border1, border2, border3, border4, border5);
            panels.AddMultiple(panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9);
            buttons.AddMultiple(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            button1.Focus();
            panel1.BringToFront();
        }

        private void UserIdTextBox_Leave(object sender, EventArgs e)
        {
            if (long.TryParse(UserIdTextBox.Text, out long id) && !UserIdTextBox.Text.Contains("-") && !UserIdTextBox.Text.Equals("0") && !UserIdTextBox.Text.StartsWith("0"))
            {
                long[] ids = new long[] { id };
                var p = _api.Users.Get(ids, ProfileFields.Photo200).FirstOrDefault();

                var request = WebRequest.Create(p!.Photo200.ToString());
                using var response = request.GetResponse();
                using var stream = response.GetResponseStream();

                AvatarPic1.Image = Image.FromStream(stream);
            }
            else
            {
                UserIdTextBox.Text = "";
                MainForm.UpdateOutput("Wrong userId format");
            }
        }

        private void AnyButton_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string numbersOnlyButton = Regex.Replace(button.Name, @"[^\d]", string.Empty);
            panels.ForEach(delegate (Panel p)
            {
                string numbersOnlyPanel = Regex.Replace(p.Name, @"[^\d]", string.Empty);
                if (numbersOnlyButton.Equals(numbersOnlyPanel))
                {
                    p.BringToFront();
                    button.Focus();
                }
            });
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            string msg = String.Join("\n", MessageTextBox.Lines);
            _api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            {
                RandomId = new Random().Next(),
                UserId = long.Parse(UserIdTextBox.Text),
                Message = msg
            });
            MainForm.UpdateOutput("Message sent");
            MessageTextBox.Lines = null;
        }
    }
}

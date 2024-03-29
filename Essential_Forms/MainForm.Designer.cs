﻿namespace VK_Control_Panel_Bot
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.Iconified = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Output = new System.Windows.Forms.TextBox();
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.ControlsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.RememberMeButton = new System.Windows.Forms.CheckBox();
            this.EyeButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UpPanel.SuspendLayout();
            this.StripMenu.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // Iconified
            // 
            resources.ApplyResources(this.Iconified, "Iconified");
            this.Iconified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Iconified.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Iconified.Name = "Iconified";
            this.Iconified.TabStop = false;
            this.Iconified.UseVisualStyleBackColor = true;
            this.Iconified.Click += new System.EventHandler(this.Iconified_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.UpPanel.Controls.Add(this.panel7);
            this.UpPanel.Controls.Add(this.Output);
            this.UpPanel.Controls.Add(this.Iconified);
            this.UpPanel.Controls.Add(this.Exit);
            this.UpPanel.Controls.Add(this.StripMenu);
            resources.ApplyResources(this.UpPanel, "UpPanel");
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseDown);
            this.UpPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseMove);
            this.UpPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseUp);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Output, "Output");
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            // 
            // StripMenu
            // 
            resources.ApplyResources(this.StripMenu, "StripMenu");
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlsMenu});
            this.StripMenu.Name = "StripMenu";
            // 
            // ControlsMenu
            // 
            this.ControlsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ControlsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessagesToolStripMenuItem,
            this.PhotosToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            resources.ApplyResources(this.ControlsMenu, "ControlsMenu");
            this.ControlsMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ControlsMenu.Name = "ControlsMenu";
            // 
            // MessagesToolStripMenuItem
            // 
            this.MessagesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            resources.ApplyResources(this.MessagesToolStripMenuItem, "MessagesToolStripMenuItem");
            this.MessagesToolStripMenuItem.Click += new System.EventHandler(this.MessagesToolStripMenuItem_Click);
            // 
            // PhotosToolStripMenuItem
            // 
            this.PhotosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PhotosToolStripMenuItem.Name = "PhotosToolStripMenuItem";
            resources.ApplyResources(this.PhotosToolStripMenuItem, "PhotosToolStripMenuItem");
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            resources.ApplyResources(this.LogOutToolStripMenuItem, "LogOutToolStripMenuItem");
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.RememberMeButton);
            this.LoginPanel.Controls.Add(this.EyeButton);
            this.LoginPanel.Controls.Add(this.EnterButton);
            this.LoginPanel.Controls.Add(this.pictureBox3);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Controls.Add(this.panel2);
            this.LoginPanel.Controls.Add(this.panel4);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.PassBox);
            this.LoginPanel.Controls.Add(this.LoginBox);
            resources.ApplyResources(this.LoginPanel, "LoginPanel");
            this.LoginPanel.Name = "LoginPanel";
            // 
            // RememberMeButton
            // 
            resources.ApplyResources(this.RememberMeButton, "RememberMeButton");
            this.RememberMeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RememberMeButton.Name = "RememberMeButton";
            this.RememberMeButton.UseVisualStyleBackColor = true;
            // 
            // EyeButton
            // 
            this.EyeButton.BackColor = System.Drawing.Color.Transparent;
            this.EyeButton.BackgroundImage = global::VK_Control_Panel_Bot.Properties.Resources.eye;
            resources.ApplyResources(this.EyeButton, "EyeButton");
            this.EyeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.UseVisualStyleBackColor = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // EnterButton
            // 
            resources.ApplyResources(this.EnterButton, "EnterButton");
            this.EnterButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::VK_Control_Panel_Bot.Properties.Resources.password;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::VK_Control_Panel_Bot.Properties.Resources.login1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // LoginLabel
            // 
            resources.ApplyResources(this.LoginLabel, "LoginLabel");
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginLabel.Name = "LoginLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VK_Control_Panel_Bot.Properties.Resources.VKLOGO;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.SystemColors.Control;
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.PassBox, "PassBox");
            this.PassBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PassBox.Name = "PassBox";
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.SystemColors.Control;
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.LoginBox, "LoginBox");
            this.LoginBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginBox.Name = "LoginBox";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.UpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.StripMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Iconified;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button EyeButton;
        public System.Windows.Forms.ToolStripMenuItem ControlsMenu;
        public System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem MessagesToolStripMenuItem;
        public System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox RememberMeButton;
        private System.Windows.Forms.ToolStripMenuItem PhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
    }
}

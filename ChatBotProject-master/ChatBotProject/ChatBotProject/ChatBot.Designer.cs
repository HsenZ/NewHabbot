﻿using AIMLbot;
using ChatBotProject.Properties;

namespace ChatBotProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTyping = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InputTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bubble1 = new ChatBotProject.bubble();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.SendButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendButton)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTyping
            // 
            this.txtTyping.AutoSize = true;
            this.txtTyping.BackColor = System.Drawing.Color.White;
            this.txtTyping.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTyping.Location = new System.Drawing.Point(5, 555);
            this.txtTyping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(117, 16);
            this.txtTyping.TabIndex = 3;
            this.txtTyping.Text = "HAMbot is typing...";
            this.txtTyping.Visible = false;
            this.txtTyping.Click += new System.EventHandler(this.txtTyping_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 49);
            this.panel1.TabIndex = 4;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(737, 15);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HAMbot v0.1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ChatBotProject.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // InputTxt
            // 
            this.InputTxt.AutoSize = true;
            this.InputTxt.BackColor = System.Drawing.Color.White;
            this.InputTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.InputTxt.ForeColor = System.Drawing.Color.DarkRed;
            this.InputTxt.HintForeColor = System.Drawing.Color.Empty;
            this.InputTxt.HintText = "";
            this.InputTxt.isPassword = false;
            this.InputTxt.LineFocusedColor = System.Drawing.Color.IndianRed;
            this.InputTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.InputTxt.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.InputTxt.LineThickness = 3;
            this.InputTxt.Location = new System.Drawing.Point(68, 496);
            this.InputTxt.Margin = new System.Windows.Forms.Padding(5);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(631, 54);
            this.InputTxt.TabIndex = 5;
            this.InputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bubble1
            // 
            this.bubble1.AutoSize = true;
            this.bubble1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bubble1.BackColor = System.Drawing.Color.Silver;
            this.bubble1.Location = new System.Drawing.Point(9, 10);
            this.bubble1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bubble1.Name = "bubble1";
            this.bubble1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bubble1.Size = new System.Drawing.Size(479, 94);
            this.bubble1.TabIndex = 3;
            this.bubble1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(9, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 431);
            this.panel2.TabIndex = 7;
            this.panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel2_Scroll);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearChatToolStripMenuItem,
            this.toggleVoiceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // clearChatToolStripMenuItem
            // 
            this.clearChatToolStripMenuItem.Name = "clearChatToolStripMenuItem";
            this.clearChatToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.clearChatToolStripMenuItem.Text = "Clear Chat";
            this.clearChatToolStripMenuItem.Click += new System.EventHandler(this.clearChatToolStripMenuItem_Click);
            // 
            // toggleVoiceToolStripMenuItem
            // 
            this.toggleVoiceToolStripMenuItem.CheckOnClick = true;
            this.toggleVoiceToolStripMenuItem.Name = "toggleVoiceToolStripMenuItem";
            this.toggleVoiceToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.toggleVoiceToolStripMenuItem.Text = "Bot Voice";
            this.toggleVoiceToolStripMenuItem.Click += new System.EventHandler(this.toggleVoiceToolStripMenuItem_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.White;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(9, 498);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(49, 54);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 8;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.White;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.Image")));
            this.SendButton.ImageActive = null;
            this.SendButton.Location = new System.Drawing.Point(708, 498);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(49, 54);
            this.SendButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SendButton.TabIndex = 6;
            this.SendButton.TabStop = false;
            this.SendButton.Zoom = 10;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(768, 580);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTyping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTyping;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputTxt;
        private Bunifu.Framework.UI.BunifuImageButton SendButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private bubble bubble1;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleVoiceToolStripMenuItem;
    }
}


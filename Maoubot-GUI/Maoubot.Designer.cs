﻿namespace Maoubot_GUI
{
	partial class Maoubot
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Chatbox = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonConfigLoad = new System.Windows.Forms.Button();
			this.buttonConfigSave = new System.Windows.Forms.Button();
			this.textBoxChannel = new System.Windows.Forms.TextBox();
			this.textBoxOAuth = new System.Windows.Forms.TextBox();
			this.buttonDisconnect = new System.Windows.Forms.Button();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.textBoxNickname = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Debugbox = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dUMMYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
			this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Chatbox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 588);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// Chatbox
			// 
			this.Chatbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Chatbox.Location = new System.Drawing.Point(3, 3);
			this.Chatbox.Multiline = true;
			this.Chatbox.Name = "Chatbox";
			this.Chatbox.ReadOnly = true;
			this.Chatbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Chatbox.Size = new System.Drawing.Size(528, 582);
			this.Chatbox.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(537, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(344, 582);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(336, 580);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Login/Connect";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Channel";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "oAuth Key";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nickname";
			// 
			// buttonConfigLoad
			// 
			this.buttonConfigLoad.Location = new System.Drawing.Point(169, 83);
			this.buttonConfigLoad.Name = "buttonConfigLoad";
			this.buttonConfigLoad.Size = new System.Drawing.Size(155, 25);
			this.buttonConfigLoad.TabIndex = 6;
			this.buttonConfigLoad.Text = "Load Config";
			this.buttonConfigLoad.UseVisualStyleBackColor = true;
			this.buttonConfigLoad.Click += new System.EventHandler(this.buttonConfigLoad_Click);
			// 
			// buttonConfigSave
			// 
			this.buttonConfigSave.Location = new System.Drawing.Point(6, 83);
			this.buttonConfigSave.Name = "buttonConfigSave";
			this.buttonConfigSave.Size = new System.Drawing.Size(155, 25);
			this.buttonConfigSave.TabIndex = 5;
			this.buttonConfigSave.Text = "Save Config";
			this.buttonConfigSave.UseVisualStyleBackColor = true;
			this.buttonConfigSave.Click += new System.EventHandler(this.buttonConfigSave_Click);
			// 
			// textBoxChannel
			// 
			this.textBoxChannel.Location = new System.Drawing.Point(65, 57);
			this.textBoxChannel.Name = "textBoxChannel";
			this.textBoxChannel.Size = new System.Drawing.Size(259, 20);
			this.textBoxChannel.TabIndex = 4;
			this.textBoxChannel.Text = "CHANNEL";
			// 
			// textBoxOAuth
			// 
			this.textBoxOAuth.Location = new System.Drawing.Point(65, 31);
			this.textBoxOAuth.Name = "textBoxOAuth";
			this.textBoxOAuth.Size = new System.Drawing.Size(259, 20);
			this.textBoxOAuth.TabIndex = 3;
			this.textBoxOAuth.Text = "OAUTH_KEY";
			// 
			// buttonDisconnect
			// 
			this.buttonDisconnect.Location = new System.Drawing.Point(169, 114);
			this.buttonDisconnect.Name = "buttonDisconnect";
			this.buttonDisconnect.Size = new System.Drawing.Size(155, 25);
			this.buttonDisconnect.TabIndex = 2;
			this.buttonDisconnect.Text = "Disconnect/Quit";
			this.buttonDisconnect.UseVisualStyleBackColor = true;
			this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(6, 114);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(155, 25);
			this.buttonConnect.TabIndex = 1;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// textBoxNickname
			// 
			this.textBoxNickname.Location = new System.Drawing.Point(65, 5);
			this.textBoxNickname.Name = "textBoxNickname";
			this.textBoxNickname.Size = new System.Drawing.Size(259, 20);
			this.textBoxNickname.TabIndex = 0;
			this.textBoxNickname.Text = "NICKNAME";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(336, 556);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Maoubot Config";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.buttonConnect);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxNickname);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.buttonDisconnect);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxOAuth);
			this.splitContainer1.Panel1.Controls.Add(this.buttonConfigLoad);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxChannel);
			this.splitContainer1.Panel1.Controls.Add(this.buttonConfigSave);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Debugbox);
			this.splitContainer1.Size = new System.Drawing.Size(330, 574);
			this.splitContainer1.SplitterDistance = 150;
			this.splitContainer1.TabIndex = 11;
			// 
			// Debugbox
			// 
			this.Debugbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Debugbox.Location = new System.Drawing.Point(0, 0);
			this.Debugbox.Multiline = true;
			this.Debugbox.Name = "Debugbox";
			this.Debugbox.ReadOnly = true;
			this.Debugbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Debugbox.Size = new System.Drawing.Size(330, 420);
			this.Debugbox.TabIndex = 11;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dUMMYToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(884, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dUMMYToolStripMenuItem
			// 
			this.dUMMYToolStripMenuItem.Name = "dUMMYToolStripMenuItem";
			this.dUMMYToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.dUMMYToolStripMenuItem.Text = "DUMMY";
			// 
			// Maoubot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 612);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Maoubot";
			this.Text = "Maoubot-GUI";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox Chatbox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNickname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonDisconnect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxOAuth;
		private System.Windows.Forms.Button buttonConfigLoad;
		private System.Windows.Forms.TextBox textBoxChannel;
		private System.Windows.Forms.Button buttonConfigSave;
		private System.Windows.Forms.TextBox Debugbox;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dUMMYToolStripMenuItem;
	}
}


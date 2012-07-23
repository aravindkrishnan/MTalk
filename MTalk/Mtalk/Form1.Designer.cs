namespace Mtalk
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
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NewMessageButton = new System.Windows.Forms.Button();
            this.Presencelabel = new System.Windows.Forms.Label();
            this.SMessageBox = new System.Windows.Forms.TextBox();
            this.StatusChoose = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NewStatuslabel = new System.Windows.Forms.Label();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SelfPicture = new System.Windows.Forms.PictureBox();
            this.AboutLink = new System.Windows.Forms.LinkLabel();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.HelplinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SigninPanel = new System.Windows.Forms.Panel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.ForgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RememberPassword = new System.Windows.Forms.CheckBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.ViewSelectlabel = new System.Windows.Forms.Label();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.ViewSelectpanel = new System.Windows.Forms.Panel();
            this.resize = new System.Windows.Forms.PictureBox();
            this.Rosterpanel = new System.Windows.Forms.TableLayoutPanel();
            this.OnlinePanel = new System.Windows.Forms.TableLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolbarRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.BorderPanel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.StatusChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelfPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SigninPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            this.ViewSelectpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resize)).BeginInit();
            this.toolbarRightClick.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.BorderPanel.Controls.Add(this.splitContainer1);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderPanel.Location = new System.Drawing.Point(0, 33);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(260, 536);
            this.BorderPanel.TabIndex = 1;
            this.BorderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanel_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel1.Controls.Add(this.NewMessageButton);
            this.splitContainer1.Panel1.Controls.Add(this.Presencelabel);
            this.splitContainer1.Panel1.Controls.Add(this.SMessageBox);
            this.splitContainer1.Panel1.Controls.Add(this.StatusChoose);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.SelfPicture);
            this.splitContainer1.Panel1.Controls.Add(this.Statuslabel);
            this.splitContainer1.Panel1.Controls.Add(this.HelplinkLabel);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.AboutLink);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer1.Panel2.Controls.Add(this.SigninPanel);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.RightBorder);
            this.splitContainer1.Panel2.Controls.Add(this.bottomBorder);
            this.splitContainer1.Panel2.Controls.Add(this.ViewSelectpanel);
            this.splitContainer1.Panel2.Controls.Add(this.Rosterpanel);
            this.splitContainer1.Panel2.Controls.Add(this.OnlinePanel);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(260, 536);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 0;
            // 
            // NewMessageButton
            // 
            this.NewMessageButton.Location = new System.Drawing.Point(223, 35);
            this.NewMessageButton.Name = "NewMessageButton";
            this.NewMessageButton.Size = new System.Drawing.Size(31, 14);
            this.NewMessageButton.TabIndex = 16;
            this.NewMessageButton.Text = "Message";
            this.NewMessageButton.UseVisualStyleBackColor = true;
            this.NewMessageButton.Visible = false;
            this.NewMessageButton.Click += new System.EventHandler(this.ChatImage_Click);
            // 
            // Presencelabel
            // 
            this.Presencelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Presencelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Presencelabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presencelabel.ForeColor = System.Drawing.Color.White;
            this.Presencelabel.Location = new System.Drawing.Point(22, 142);
            this.Presencelabel.Name = "Presencelabel";
            this.Presencelabel.Size = new System.Drawing.Size(168, 19);
            this.Presencelabel.TabIndex = 15;
            this.Presencelabel.MouseLeave += new System.EventHandler(this.Presencelabel_MouseLeave);
            this.Presencelabel.Click += new System.EventHandler(this.Presencelabel_Click_1);
            this.Presencelabel.MouseEnter += new System.EventHandler(this.Presencelabel_MouseEnter);
            // 
            // SMessageBox
            // 
            this.SMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SMessageBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SMessageBox.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMessageBox.ForeColor = System.Drawing.Color.White;
            this.SMessageBox.Location = new System.Drawing.Point(24, 140);
            this.SMessageBox.Name = "SMessageBox";
            this.SMessageBox.Size = new System.Drawing.Size(166, 21);
            this.SMessageBox.TabIndex = 14;
            this.SMessageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SMessageTextBox_KeyPress);
            // 
            // StatusChoose
            // 
            this.StatusChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusChoose.AutoSize = true;
            this.StatusChoose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.StatusChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusChoose.Controls.Add(this.pictureBox2);
            this.StatusChoose.Controls.Add(this.NewStatuslabel);
            this.StatusChoose.Controls.Add(this.StatusPictureBox);
            this.StatusChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusChoose.Location = new System.Drawing.Point(24, 103);
            this.StatusChoose.Name = "StatusChoose";
            this.StatusChoose.Size = new System.Drawing.Size(158, 26);
            this.StatusChoose.TabIndex = 13;
            this.StatusChoose.MouseLeave += new System.EventHandler(this.StatusChoose_MouseLeave);
            this.StatusChoose.Click += new System.EventHandler(this.StatusChoose_Click);
            this.StatusChoose.MouseEnter += new System.EventHandler(this.StatusChoose_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Mtalk.Properties.Resources.PullDown;
            this.pictureBox2.Location = new System.Drawing.Point(136, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // NewStatuslabel
            // 
            this.NewStatuslabel.AutoSize = true;
            this.NewStatuslabel.Enabled = false;
            this.NewStatuslabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStatuslabel.ForeColor = System.Drawing.Color.Black;
            this.NewStatuslabel.Location = new System.Drawing.Point(22, 5);
            this.NewStatuslabel.Name = "NewStatuslabel";
            this.NewStatuslabel.Size = new System.Drawing.Size(34, 15);
            this.NewStatuslabel.TabIndex = 1;
            this.NewStatuslabel.Text = "label";
            // 
            // StatusPictureBox
            // 
            this.StatusPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusPictureBox.Image = global::Mtalk.Properties.Resources.contacts;
            this.StatusPictureBox.Location = new System.Drawing.Point(0, 0);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(17, 24);
            this.StatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StatusPictureBox.TabIndex = 8;
            this.StatusPictureBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Available",
            "Busy",
            "Invisible",
            "Idle"});
            this.comboBox1.Location = new System.Drawing.Point(99, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 22);
            this.comboBox1.TabIndex = 11;
            // 
            // SelfPicture
            // 
            this.SelfPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelfPicture.Location = new System.Drawing.Point(201, 121);
            this.SelfPicture.Name = "SelfPicture";
            this.SelfPicture.Size = new System.Drawing.Size(55, 49);
            this.SelfPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelfPicture.TabIndex = 10;
            this.SelfPicture.TabStop = false;
            // 
            // AboutLink
            // 
            this.AboutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutLink.AutoSize = true;
            this.AboutLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLink.Location = new System.Drawing.Point(187, 5);
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Size = new System.Drawing.Size(38, 15);
            this.AboutLink.TabIndex = 9;
            this.AboutLink.TabStop = true;
            this.AboutLink.Text = "About";
            this.AboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // Statuslabel
            // 
            this.Statuslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslabel.ForeColor = System.Drawing.Color.White;
            this.Statuslabel.Location = new System.Drawing.Point(35, 109);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(65, 15);
            this.Statuslabel.TabIndex = 0;
            this.Statuslabel.Text = "Sign in as:";
            // 
            // HelplinkLabel
            // 
            this.HelplinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelplinkLabel.AutoSize = true;
            this.HelplinkLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelplinkLabel.Location = new System.Drawing.Point(222, 5);
            this.HelplinkLabel.Name = "HelplinkLabel";
            this.HelplinkLabel.Size = new System.Drawing.Size(33, 15);
            this.HelplinkLabel.TabIndex = 7;
            this.HelplinkLabel.TabStop = true;
            this.HelplinkLabel.Text = "Help";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SigninPanel
            // 
            this.SigninPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SigninPanel.BackColor = System.Drawing.Color.Transparent;
            this.SigninPanel.Controls.Add(this.SignInButton);
            this.SigninPanel.Controls.Add(this.ForgotPasswordLabel);
            this.SigninPanel.Controls.Add(this.UsernameLabel);
            this.SigninPanel.Controls.Add(this.RememberPassword);
            this.SigninPanel.Controls.Add(this.UserName);
            this.SigninPanel.Controls.Add(this.Passwordlabel);
            this.SigninPanel.Controls.Add(this.Password);
            this.SigninPanel.Controls.Add(this.linkLabel1);
            this.SigninPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SigninPanel.Location = new System.Drawing.Point(14, 13);
            this.SigninPanel.Name = "SigninPanel";
            this.SigninPanel.Size = new System.Drawing.Size(225, 299);
            this.SigninPanel.TabIndex = 7;
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInButton.BackColor = System.Drawing.Color.AliceBlue;
            this.SignInButton.BackgroundImage = global::Mtalk.Properties.Resources.button1up;
            this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.Navy;
            this.SignInButton.Location = new System.Drawing.Point(57, 188);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(108, 25);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.MouseLeave += new System.EventHandler(this.SignInButton_MouseLeave);
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            this.SignInButton.MouseEnter += new System.EventHandler(this.SignInButton_MouseEnter);
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(44, 227);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(133, 15);
            this.ForgotPasswordLabel.TabIndex = 5;
            this.ForgotPasswordLabel.TabStop = true;
            this.ForgotPasswordLabel.Text = "Forgot your password?";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(32, 40);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(66, 15);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // RememberPassword
            // 
            this.RememberPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RememberPassword.AutoSize = true;
            this.RememberPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberPassword.ForeColor = System.Drawing.Color.White;
            this.RememberPassword.Location = new System.Drawing.Point(35, 155);
            this.RememberPassword.Name = "RememberPassword";
            this.RememberPassword.Size = new System.Drawing.Size(147, 19);
            this.RememberPassword.TabIndex = 3;
            this.RememberPassword.Text = "Remember password";
            this.RememberPassword.UseVisualStyleBackColor = false;
            this.RememberPassword.CheckedChanged += new System.EventHandler(this.RememberPassword_CheckedChanged);
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(35, 58);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(156, 21);
            this.UserName.TabIndex = 1;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Passwordlabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Passwordlabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.Color.White;
            this.Passwordlabel.Location = new System.Drawing.Point(32, 100);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(65, 15);
            this.Passwordlabel.TabIndex = 0;
            this.Passwordlabel.Text = "Password";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(35, 118);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(156, 21);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(43, 252);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 15);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account?";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.ViewPanel);
            this.panel1.Location = new System.Drawing.Point(2, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 17);
            this.panel1.TabIndex = 17;
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ViewPanel.Controls.Add(this.ViewSelectlabel);
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewPanel.Location = new System.Drawing.Point(25, 0);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(57, 17);
            this.ViewPanel.TabIndex = 16;
            // 
            // ViewSelectlabel
            // 
            this.ViewSelectlabel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ViewSelectlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewSelectlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewSelectlabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSelectlabel.ForeColor = System.Drawing.Color.White;
            this.ViewSelectlabel.Location = new System.Drawing.Point(0, 0);
            this.ViewSelectlabel.Name = "ViewSelectlabel";
            this.ViewSelectlabel.Size = new System.Drawing.Size(57, 17);
            this.ViewSelectlabel.TabIndex = 0;
            this.ViewSelectlabel.Text = "Online";
            this.ViewSelectlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ViewSelectlabel.MouseLeave += new System.EventHandler(this.ViewSelectlabel_MouseLeave);
            this.ViewSelectlabel.Click += new System.EventHandler(this.ViewSelectlabel_Click);
            this.ViewSelectlabel.MouseEnter += new System.EventHandler(this.ViewSelectlabel_MouseEnter);
            // 
            // RightBorder
            // 
            this.RightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder.Location = new System.Drawing.Point(256, 0);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(2, 351);
            this.RightBorder.TabIndex = 18;
            this.RightBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBorder_MouseMove);
            this.RightBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBorder_MouseDown);
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.Transparent;
            this.bottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(0, 351);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(258, 4);
            this.bottomBorder.TabIndex = 17;
            this.bottomBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bottomBorder_MouseMove);
            this.bottomBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomBorder_MouseDown);
            // 
            // ViewSelectpanel
            // 
            this.ViewSelectpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewSelectpanel.BackColor = System.Drawing.Color.Transparent;
            this.ViewSelectpanel.Controls.Add(this.resize);
            this.ViewSelectpanel.Location = new System.Drawing.Point(90, 330);
            this.ViewSelectpanel.Name = "ViewSelectpanel";
            this.ViewSelectpanel.Size = new System.Drawing.Size(168, 23);
            this.ViewSelectpanel.TabIndex = 7;
            // 
            // resize
            // 
            this.resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resize.BackgroundImage")));
            this.resize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resize.Location = new System.Drawing.Point(142, 1);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(27, 22);
            this.resize.TabIndex = 15;
            this.resize.TabStop = false;
            this.resize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.resize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            // 
            // Rosterpanel
            // 
            this.Rosterpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Rosterpanel.AutoScroll = true;
            this.Rosterpanel.BackColor = System.Drawing.Color.SkyBlue;
            this.Rosterpanel.ColumnCount = 1;
            this.Rosterpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Rosterpanel.Location = new System.Drawing.Point(4, 0);
            this.Rosterpanel.Name = "Rosterpanel";
            this.Rosterpanel.RowCount = 7;
            this.Rosterpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Rosterpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Rosterpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Rosterpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Rosterpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Rosterpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Rosterpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Rosterpanel.Size = new System.Drawing.Size(250, 324);
            this.Rosterpanel.TabIndex = 16;
            // 
            // OnlinePanel
            // 
            this.OnlinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OnlinePanel.AutoScroll = true;
            this.OnlinePanel.BackColor = System.Drawing.Color.SkyBlue;
            this.OnlinePanel.ColumnCount = 1;
            this.OnlinePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OnlinePanel.Location = new System.Drawing.Point(4, 0);
            this.OnlinePanel.Name = "OnlinePanel";
            this.OnlinePanel.RowCount = 7;
            this.OnlinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.OnlinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.OnlinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.OnlinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.OnlinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.OnlinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.OnlinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.OnlinePanel.Size = new System.Drawing.Size(250, 323);
            this.OnlinePanel.TabIndex = 17;
            this.OnlinePanel.Resize += new System.EventHandler(this.Onlinepanel_Resize);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "contacts.png");
            this.imageList1.Images.SetKeyName(1, "green.png");
            this.imageList1.Images.SetKeyName(2, "orange.png");
            this.imageList1.Images.SetKeyName(3, "red.png");
            this.imageList1.Images.SetKeyName(4, "stop.png");
            // 
            // toolbarRightClick
            // 
            this.toolbarRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizeToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.toolbarRightClick.Name = "toolbarRightClick";
            this.toolbarRightClick.Size = new System.Drawing.Size(114, 70);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.maximizeToolStripMenuItem.Text = "Restore";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.toolbarRightClick;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MTalk";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(260, 33);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Euphemia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "M Talk";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(233, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 18);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(208, 6);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(19, 17);
            this.MinimizeButton.TabIndex = 8;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(260, 569);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 800);
            this.MinimumSize = new System.Drawing.Size(250, 520);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MTalk";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Move);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.BorderPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.StatusChoose.ResumeLayout(false);
            this.StatusChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelfPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SigninPanel.ResumeLayout(false);
            this.SigninPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ViewPanel.ResumeLayout(false);
            this.ViewSelectpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resize)).EndInit();
            this.toolbarRightClick.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel HelplinkLabel;
        private System.Windows.Forms.Panel SigninPanel;
        private System.Windows.Forms.PictureBox resize;
        private System.Windows.Forms.ContextMenuStrip toolbarRightClick;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox RememberPassword;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.LinkLabel ForgotPasswordLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel ViewSelectpanel;
        private System.Windows.Forms.LinkLabel AboutLink;
        private System.Windows.Forms.TableLayoutPanel Rosterpanel;
        private System.Windows.Forms.PictureBox SelfPicture;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label NewStatuslabel;
        public System.Windows.Forms.Panel StatusChoose;
        private System.Windows.Forms.TextBox SMessageBox;
        private System.Windows.Forms.Label Presencelabel;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.Panel RightBorder;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Label ViewSelectlabel;
        private System.Windows.Forms.TableLayoutPanel OnlinePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewMessageButton;
    }
}


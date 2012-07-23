namespace Mtalk
{
    partial class RosterForm
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
            this.IconsPanel = new System.Windows.Forms.Panel();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.FileImage = new System.Windows.Forms.PictureBox();
            this.WebCamImage = new System.Windows.Forms.PictureBox();
            this.CallImage = new System.Windows.Forms.PictureBox();
            this.ChatImage = new System.Windows.Forms.PictureBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rightpanel = new System.Windows.Forms.Panel();
            this.Namelabel = new System.Windows.Forms.Label();
            this.VCardImage = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.IconsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // IconsPanel
            // 
            this.IconsPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.IconsPanel.Controls.Add(this.Leftpanel);
            this.IconsPanel.Controls.Add(this.FileImage);
            this.IconsPanel.Controls.Add(this.WebCamImage);
            this.IconsPanel.Controls.Add(this.CallImage);
            this.IconsPanel.Controls.Add(this.ChatImage);
            this.IconsPanel.Location = new System.Drawing.Point(0, 0);
            this.IconsPanel.Name = "IconsPanel";
            this.IconsPanel.Size = new System.Drawing.Size(317, 28);
            this.IconsPanel.TabIndex = 0;
            // 
            // Leftpanel
            // 
            this.Leftpanel.Location = new System.Drawing.Point(0, 17);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(15, 126);
            this.Leftpanel.TabIndex = 1;
            this.Leftpanel.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // FileImage
            // 
            this.FileImage.BackgroundImage = global::Mtalk.Properties.Resources.File;
            this.FileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FileImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileImage.Location = new System.Drawing.Point(134, 3);
            this.FileImage.Name = "FileImage";
            this.FileImage.Size = new System.Drawing.Size(41, 22);
            this.FileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FileImage.TabIndex = 0;
            this.FileImage.TabStop = false;
            this.toolTip.SetToolTip(this.FileImage, "Send File");
            this.FileImage.MouseLeave += new System.EventHandler(this.FileImage_MouseLeave);
            this.FileImage.MouseEnter += new System.EventHandler(this.FileImage_MouseEnter);
            // 
            // WebCamImage
            // 
            this.WebCamImage.BackgroundImage = global::Mtalk.Properties.Resources.Webcam;
            this.WebCamImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WebCamImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebCamImage.Location = new System.Drawing.Point(95, 3);
            this.WebCamImage.Name = "WebCamImage";
            this.WebCamImage.Size = new System.Drawing.Size(33, 22);
            this.WebCamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WebCamImage.TabIndex = 0;
            this.WebCamImage.TabStop = false;
            this.toolTip.SetToolTip(this.WebCamImage, "Video Call");
            this.WebCamImage.MouseLeave += new System.EventHandler(this.WebCamImage_MouseLeave);
            this.WebCamImage.MouseEnter += new System.EventHandler(this.WebCamImage_MouseEnter);
            // 
            // CallImage
            // 
            this.CallImage.BackgroundImage = global::Mtalk.Properties.Resources.Phone;
            this.CallImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CallImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CallImage.Location = new System.Drawing.Point(53, 3);
            this.CallImage.Name = "CallImage";
            this.CallImage.Size = new System.Drawing.Size(36, 25);
            this.CallImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CallImage.TabIndex = 0;
            this.CallImage.TabStop = false;
            this.toolTip.SetToolTip(this.CallImage, "Call");
            this.CallImage.MouseLeave += new System.EventHandler(this.CallImage_MouseLeave);
            this.CallImage.MouseEnter += new System.EventHandler(this.CallImage_MouseEnter);
            // 
            // ChatImage
            // 
            this.ChatImage.BackgroundImage = global::Mtalk.Properties.Resources.chat;
            this.ChatImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChatImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatImage.Location = new System.Drawing.Point(12, 0);
            this.ChatImage.Name = "ChatImage";
            this.ChatImage.Size = new System.Drawing.Size(35, 28);
            this.ChatImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ChatImage.TabIndex = 0;
            this.ChatImage.TabStop = false;
            this.toolTip.SetToolTip(this.ChatImage, "Chat");
            this.ChatImage.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.ChatImage.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // Statuslabel
            // 
            this.Statuslabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslabel.ForeColor = System.Drawing.Color.Black;
            this.Statuslabel.Location = new System.Drawing.Point(9, 87);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(165, 38);
            this.Statuslabel.TabIndex = 3;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(14, 2);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(0, 15);
            this.Emaillabel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Emaillabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 21);
            this.panel1.TabIndex = 5;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Rightpanel);
            this.panel2.Controls.Add(this.Namelabel);
            this.panel2.Controls.Add(this.Statuslabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 153);
            this.panel2.TabIndex = 6;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // Rightpanel
            // 
            this.Rightpanel.Location = new System.Drawing.Point(305, 16);
            this.Rightpanel.Name = "Rightpanel";
            this.Rightpanel.Size = new System.Drawing.Size(10, 126);
            this.Rightpanel.TabIndex = 5;
            this.Rightpanel.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // Namelabel
            // 
            this.Namelabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.Black;
            this.Namelabel.Location = new System.Drawing.Point(11, 33);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(163, 42);
            this.Namelabel.TabIndex = 4;
            // 
            // VCardImage
            // 
            this.VCardImage.Location = new System.Drawing.Point(206, 34);
            this.VCardImage.Name = "VCardImage";
            this.VCardImage.Size = new System.Drawing.Size(99, 92);
            this.VCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VCardImage.TabIndex = 1;
            this.VCardImage.TabStop = false;
            // 
            // RosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(317, 153);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VCardImage);
            this.Controls.Add(this.IconsPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RosterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RosterForm";
            this.Load += new System.EventHandler(this.RosterForm_Load);
            this.IconsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VCardImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FileImage;
        private System.Windows.Forms.PictureBox WebCamImage;
        private System.Windows.Forms.PictureBox CallImage;
        public System.Windows.Forms.Label Statuslabel;
        public System.Windows.Forms.Label Emaillabel;
        public System.Windows.Forms.Panel IconsPanel;
        public System.Windows.Forms.PictureBox VCardImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Namelabel;
        public System.Windows.Forms.Panel Rightpanel;
        public System.Windows.Forms.Panel Leftpanel;
        public System.Windows.Forms.PictureBox ChatImage;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
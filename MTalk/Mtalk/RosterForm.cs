using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mtalk
{
    public partial class RosterForm : Form
    {
        
        public RosterForm()
        {
            InitializeComponent();
            
        }
        public RosterForm(int x,int y)
        {
            InitializeComponent();
            this.Location = new Point(x, y);


        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ChatImage.Image = Properties.Resources.chat24;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ChatImage.Image = Properties.Resources.chat;
        }

        private void CallImage_MouseEnter(object sender, EventArgs e)
        {
            CallImage.Image = Properties.Resources.Phone24;
        }

        private void CallImage_MouseLeave(object sender, EventArgs e)
        {
            CallImage.Image = Properties.Resources.Phone;
        }

        private void WebCamImage_MouseEnter(object sender, EventArgs e)
        {
            WebCamImage.Image = Properties.Resources.Webcam24;
        }

        private void WebCamImage_MouseLeave(object sender, EventArgs e)
        {
            WebCamImage.Image = Properties.Resources.Webcam;
        }

        private void FileImage_MouseEnter(object sender, EventArgs e)
        {
            FileImage.Image = Properties.Resources.File24;
        }

        private void FileImage_MouseLeave(object sender, EventArgs e)
        {
            FileImage.Image = Properties.Resources.File;
        }

        private void RosterForm_Load(object sender, EventArgs e)
        {
            Namelabel.BackColor = Namelabel.BackColor;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
         

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}

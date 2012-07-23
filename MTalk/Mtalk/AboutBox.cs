using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Mtalk
{
    public partial class AboutBox : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
             int nTopRect, // y-coordinate of upper-left corner
             int nRightRect, // x-coordinate of lower-right corner
             int nBottomRect, // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
         );
        Thread td;
        int i = 0;
        public AboutBox()
        {
            InitializeComponent();
             td = new Thread(new ThreadStart(animate));
             td.Start();
             
             Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
             panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
             panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            
            
        }

        protected void animate()
        {
            while(true)
            {
                if (i == 9)
                    i = 0;
                LogoPicture.Image = imageList.Images[i];
                
                Thread.Sleep(200);
                i++;

            } 


        }



        private void button1_MouseEnter(object sender, EventArgs e)
        {
            OKbutton.BackgroundImage = Properties.Resources.buttonOKover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            OKbutton.BackgroundImage = Properties.Resources.buttonOKup;

        }

      

      

        private void AboutBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKbutton.PerformClick();
            }

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            td.Abort();
            this.Dispose();
        }

        int Xp, Yp;
        Point pt = new System.Drawing.Point();
        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {

            Xp = MousePosition.X - this.Location.X;
            Yp = MousePosition.Y - this.Location.Y;
        }

        private void Toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = MousePosition;
                pt.X = pt.X - Xp;
                pt.Y = pt.Y - Yp;
                this.Location = pt;
            }

        }

       
    }
}

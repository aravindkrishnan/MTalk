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
    public partial class StatusListForm : Form
    {
       
        public StatusListForm()
        {
            InitializeComponent();
        }
        public StatusListForm(int x,int y,int width)
        {
            InitializeComponent();
            this.Location = new Point(x, y);
            this.Width = width;

            panel1.Width = width-1;
            panel2.Width = width-1;
            panel3.Width = width-2;
            panel4.Width = width-2;
            panel5.Width = width-2;

          

           

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.DeepSkyBlue;


        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.LightCyan;

            int x1 = MousePosition.X;
            int y1 = MousePosition.Y;

            //int Left = this.Left;//+Mleft;
            //int Top = this.Top;// +Mtop;
            //int Right = this.Right;// +MRight;
            //int Bottom = this.Bottom;// +MBottom;
            //if (x1 >= this.Left && x1 <= this.Right && y1 >= this.Top && y1 <= this.Bottom)
            //{
            //}
            //else
            //{
            //    this.Dispose();
            //}
            if (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                // the mouse is inside the control bounds
            }
            else
            {
                // the mouse is outside the control bounds
                this.Dispose();
            }

        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            this.Dispose();


        }
    }
}

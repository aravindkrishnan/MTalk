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
    public partial class PresencePopUp : Form
    {
        public PresencePopUp()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void PresencePopUp_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
           
                 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            this.Dispose();
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using NudgeFormSolution;
using agsXMPP;

namespace Mtalk
{
    public partial class ChatForm : Form
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

        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        public static extern long HideCaret(IntPtr hwnd);

        string sender;
        static string myname;
        public bool count = false;

        System.IO.Stream BuzzAudioStream;
       

        public ChatForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

           //panel14.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel14.Width, panel14.Height, 10, 10));
           
            

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            BuzzAudioStream=thisExe.GetManifestResourceStream("Mtalk.Buzz.wav");
          //string sample= "<html><head><style>h1 {font-family:\"Times New Roman\";  font-size:16pt color:blue;}</style></head><body><h1>this headline is blue and 16 pt.</h1></body></html>";
          //webBrowser1.DocumentText = sample;
            
            
          
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
            
            this.Dispose();
         
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            panel15.Hide();
            textBox1.Focus();
            Emoticons.LostFocus += new EventHandler(Emoticons_LostFocus);

            int n = Titlelabel.Text.IndexOf(" ");
            if (n != -1)
            {
                this.sender = Titlelabel.Text.Remove(n);
            }
            else
            {
                this.sender = Titlelabel.Text;

            }
            myname=Form1.Aname;

            if (string.IsNullOrEmpty(myname) == false)
            {
                n = myname.IndexOf(" ");
                if (n != -1)
                {
                    myname = myname.Remove(n);
                }
            }
            else
                myname = Form1.fullname;


           
        }

        void Emoticons_LostFocus(object sender, EventArgs e)
        {
            if (panel15.Visible == true)
                panel15.Hide();

            textBox1.Focus();
        }

      

        void Emoticons_LostFocus()
        {
            if (panel15.Visible == true)
                panel15.Hide();
            textBox1.Focus();
        }

        int Xp, Yp;
        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            Toppanel.Cursor = Cursors.SizeAll;
            Xp = MousePosition.X - this.Location.X;
            Yp = MousePosition.Y - this.Location.Y;
            Emoticons_LostFocus();
        }
        Point pt=new Point();
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

        private void Toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            Toppanel.Cursor = Cursors.Default;
        }
        int firstWidth;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
          
            Xp = MousePosition.X;// -this.Location.X;
            Yp = MousePosition.Y; //- this.Location.Y;
            firstWidth = this.Width;
            Emoticons_LostFocus();
        }
        bool panel4show=false;
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {
                if (this.Width != this.MinimumSize.Width)
                {

                    panel6.Hide();
                    Contactpicture.Hide();
                    MyPicture.Hide();
                    if (panel13.Visible == true)
                    {
                        panel13.Hide(); panel4show = true;
                    }
                    else if (panel12.Visible == true)
                    {
                        panel12.Hide(); panel4show = false;
                    }
                }
                else if (this.Width == this.MinimumSize.Width)
                {
                    panel6.Show();
                    Contactpicture.Show();
                    MyPicture.Show();
                    if (panel4show == true)
                        panel13.Show();
                    else if (panel4show == false)
                        panel12.Show();
                }
                pt = MousePosition;
                pt.X = pt.X - Xp;
               // pt.Y = pt.Y - Yp;
                this.Width = firstWidth + pt.X;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            panel6.Show();
            Contactpicture.Show();
            MyPicture.Show();
            if (panel4show == true)
                panel13.Show();
            else if (panel4show == false)
                panel12.Show();
        }

        int firstheight;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

            Xp = MousePosition.X;// -this.Location.X;
            Yp = MousePosition.Y; //- this.Location.Y;
            firstheight = this.Height;
            Emoticons_LostFocus();
        }
        

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {

                if (this.Height != this.MinimumSize.Height)
                {
                    panel17.Hide();
                    MyPicture.Hide();
                }
                else if (this.Height == this.MinimumSize.Height)
                {
                    panel17.Show();
                    MyPicture.Show();
                }
                pt = MousePosition;
               // pt.X = pt.X - Xp;
                 pt.Y = pt.Y - Yp;
                this.Height = firstheight + pt.Y;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            }
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            panel17.Show();
            MyPicture.Show();

        }


        int eY;
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            Xp = MousePosition.X;// this.Location.X;
            Yp = MousePosition.Y; // this.Location.Y;
            firstWidth = this.Width;
            firstheight = this.Height;
            eY = this.Top;
            Emoticons_LostFocus();
          
        }
        int newX; bool panelshow = false;
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Width != this.MinimumSize.Width)
                {
                    panel6.Hide();
                    Contactpicture.Hide();
                    MyPicture.Hide();
                    if (panel13.Visible == true)
                    {
                        panel13.Hide(); panelshow = true;
                    }
                    else if (panel12.Visible == true)
                    {
                        panel12.Hide(); panelshow = false;

                    }
                }
                else if (this.Width == this.MinimumSize.Width)
                {
                    panel6.Show();
                    Contactpicture.Show();
                    MyPicture.Show();
                    if (panelshow == true)
                        panel13.Show();
                    else if (panelshow == false)
                        panel12.Show();
                }
               
                
                    pt = MousePosition;
                    newX = Xp - pt.X;
                    //pt.Y = pt.Y - Yp;
                    this.Width = firstWidth + newX;
                    if (this.Width > this.MinimumSize.Width)
                    {
                    this.Location = new Point(pt.X, eY);
                     }
               
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            }

        }
        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            panel6.Show();
            Contactpicture.Show();
            MyPicture.Show();

            if(panelshow==true)
            panel13.Show();
            else if (panelshow == false)
            panel12.Show();
        }
        
        private void CallImage_MouseEnter(object sender, EventArgs e)
        {
            CallImage.Image = Properties.Resources.Phone24;
            CallImage.BackColor = Color.LightCyan;
            Calllabel.BackColor = Color.LightCyan;
            
        }

        private void CallImage_MouseLeave(object sender, EventArgs e)
        {
            CallImage.Image = Properties.Resources.Phone;
            CallImage.BackColor = Color.Transparent;
            Calllabel.BackColor = Color.Transparent;
        }

        private void WebCamImage_MouseEnter(object sender, EventArgs e)
        {
            WebCamImage.Image = Properties.Resources.Webcam24;
            WebCamImage.BackColor = Color.LightCyan;
            Webcamlabel.BackColor = Color.LightCyan;
            
        }

        private void WebCamImage_MouseLeave(object sender, EventArgs e)
        {
            WebCamImage.Image = Properties.Resources.Webcam;
            WebCamImage.BackColor = Color.Transparent;
            Webcamlabel.BackColor = Color.Transparent;
        }

        private void FileImage_MouseEnter(object sender, EventArgs e)
        {
            FileImage.Image = Properties.Resources.File24;
            FileImage.BackColor = Color.LightCyan;
            Filelabel.BackColor = Color.LightCyan; 
            
        }

        private void FileImage_MouseLeave(object sender, EventArgs e)
        {
            FileImage.Image = Properties.Resources.File;
            FileImage.BackColor = Color.Transparent;
            Filelabel.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PullLeft24;
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.PullLeft;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel14.Show();
            panel16.Width = panel16.Width - 75; 
            panel13.Hide();
            panel12.Show();
            Emoticons_LostFocus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel14.Hide();
            panel16.Width=panel16.Width+75;
            panel12.Hide();
            panel13.Show();
            Emoticons_LostFocus();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.PullRight24;
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.PullRight;
        }


        private void Smiley_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.BackColor = Color.Navy;



        }

        private void Smiley_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.BackColor = Color.Transparent;
        }

        private void Emoticons_Click(object sender, EventArgs e)
        {
            Emoticons.Focus();
            
            if (panel15.Visible == true)
                panel15.Hide();
            else if (panel15.Visible == false)
                panel15.Show();
        }

        
        private void panel9_Click(object sender, EventArgs e)
        {
            Emoticons_LostFocus();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            Emoticons_LostFocus();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            Emoticons_LostFocus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":)");
            textBox1.Focus();
            panel15.Hide();
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":-/");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("B-)");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":((");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":-t");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":(");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(";)");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":D");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":P");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":|");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":O");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("X-(");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8-|");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(">:)");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":\">");
            textBox1.Focus();
            panel15.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(":))");
            textBox1.Focus();
            panel15.Hide();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Emoticons_LostFocus();
        }
        Message m = new Message();
        string fontweight = ";font-weight:normal;";
        string fontname = "Arial";
        int fontsize = 10;
        private void FontChange_Click(object sender, EventArgs e)
        {
           
            Emoticons_LostFocus();
            DialogResult dg= fd.ShowDialog();
            if (dg == DialogResult.OK)
            {
                if (fd.Font.Style.ToString().Equals("Bold"))
                {
                    this.fontweight="font-weight:bold";
                }
                else if (fd.Font.Style.ToString().Equals("Italic"))
                {
                    this.fontweight="font-style:italic";
                }
                else if (fd.Font.Style.ToString().Contains("Bold")&&fd.Font.Style.ToString().Contains("Italic"))
                {
                    this.fontweight = "font-style:italic;font-weight:bold";
                }
                else if (fd.Font.Style.ToString().Equals("Regular"))
                {
                    this.fontweight = "font-weight:normal";
                }

                this.fontsize = (int)this.fd.Font.Size;
                this.fontname = this.fd.Font.Name;
                m.font = "font-size:" + this.fontsize + "pt;  font-family:\"" + this.fontname + "\";"+this.fontweight ;
                m.css = "body{" + m.font + "; " + m.color + ";}";
                HtmlDocument doc = webBrowser1.Document;

                m.message = Message.htmlstart + Message.headstart + m.css + Message.headend + Message.bodystart + doc.Body.InnerHtml + Message.bodyend + Message.htmlend;

                webBrowser1.DocumentText = m.message;
                
                    


            }

        }

        bool imsender = false;
        
        public void displaymessage(string person,string messg)
        {
            string msg = smileyChoose(messg);
            string from;
            if (imsender == false)
                from = this.sender;
            else
                from = person;

            string newmessage;
            if (this.fd.Font.Style.ToString().Equals("Bold"))
            {
                this.fontweight = "font-weight:bold";
            }
            else if (this.fd.Font.Style.ToString().Equals("Italic"))
            {
                this.fontweight = "font-style:italic";
            }
            else if (this.fd.Font.Style.ToString().Contains("Bold") && this.fd.Font.Style.ToString().Contains("Italic"))
            {
                this.fontweight = "font-style:italic;font-weight:bold";
            }
            else if (fd.Font.Style.ToString().Equals("Regular"))
            {
                this.fontweight = "font-weight:normal";
            }

           

            m.font = "font-size:" + this.fontsize + "pt;  font-family:\"" + this.fontname + "\";" + this.fontweight;
            m.color = "color:rgb(" + this.cd.Color.R + "," + this.cd.Color.G + "," +this.cd.Color.B + ")";
            m.css = "body{" + m.font + "; " + m.color + ";}";
            HtmlDocument doc = webBrowser1.Document;

            if (doc!=null)
            {
             
                newmessage = doc.Body.InnerHtml;
                newmessage += "</br></br><strong>" + from + "</strong>: " + msg ;
            }
            else
            {
               
                newmessage ="<strong>"+  from + "</strong>: " + msg ;
            }
             m.message = Message.htmlstart + Message.headstart + m.css + Message.headend + Message.bodystart + newmessage + Message.bodyend + Message.htmlend;

            webBrowser1.DocumentText = m.message;

        }



        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Emoticons_LostFocus();
            DialogResult dg= cd.ShowDialog();
            if (dg == DialogResult.OK)
            {
                m.font = "font-size:" + this.fontsize + "pt;  font-family:\"" + this.fontname + "\";" + this.fontweight;
                m.color = "color:rgb(" + this.cd.Color.R+","+this.cd.Color.G+","+this.cd.Color.B +")";
                m.css = "body{" + m.font + "; " + m.color + ";}";
                HtmlDocument doc = webBrowser1.Document;

                m.message = Message.htmlstart + Message.headstart + m.css + Message.headend + Message.bodystart + doc.Body.InnerHtml + Message.bodyend + Message.htmlend;
                webBrowser1.DocumentText = m.message;

            }
        }


        public void sendmessage(string to, string mesg)
        {
          


            agsXMPP.protocol.client.Message msg = new agsXMPP.protocol.client.Message();
            msg.Type = agsXMPP.protocol.client.MessageType.chat;
            msg.To = new Jid(to);
            msg.Body = mesg;
           Form1.staticVar.xmpp.Send(msg);

        }
       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texttosend = null;
            string smiley = null;
            if (e.KeyChar == (char)13)
            {
                // Then Enter key was pressed
                texttosend = textBox1.Text;
                imsender = true;
              
                if (string.IsNullOrEmpty(texttosend) == false)
                {


                    texttosend=smileyChoose(texttosend);


                    displaymessage(myname, texttosend);
                    sendmessage(this.Name, textBox1.Text);
                }
                //HtmlDocument doc = this.webBrowser1.Document;
                //webBrowser1.DocumentStream



                textBox1.Clear();
                
                textBox1.SelectionStart = 0;
                textBox1.ScrollToCaret();
                imsender = false;
            }
        }


       
            
            private string smileyChoose(string input)
            {
                string  smiley;
                if ((input.Contains(":)") || input.Contains(":-)")) && !(input.Contains(":))") || input.Contains(":-))")))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smile.png" + "\";alt=\"smile\"/>";
                input = input.Replace(":)", smiley);
                input=input.Replace(":-)", smiley);
            }

            if (input.Contains(";)") || input.Contains(";-)"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_wink.png" + "\";alt=\"wink\"/>";
                input = input.Replace(";)", smiley);
                input = input.Replace(";-)", smiley);
            }
            
                if (input.Contains(":O") || input.Contains(":-O"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_surprise.png" + "\";alt=\"surprise\"/>";
                input = input.Replace(":O", smiley);
                input = input.Replace(":-O", smiley);
            }

                if ((input.Contains(":(") || input.Contains(":-(")) && !(input.Contains(":((") || input.Contains(":-((")))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_sad.png" + "\";alt=\"sad\"/>";
                input = input.Replace(":(", smiley);
                input = input.Replace(":-(", smiley);
            }
            if (input.Contains(";)") || input.Contains(";-)"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_wink.png" + "\";alt=\"wink\"/>";
                input = input.Replace(";)", smiley);
                input = input.Replace(";-)", smiley);
            }
            if (input.Contains("8-|") || input.Contains("8|"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_roll.png" + "\";alt=\"roll\"/>";
                input = input.Replace("8|", smiley);
                input = input.Replace("8-|", smiley);
            }
            if (input.Contains(":P") || input.Contains(":-P"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_razz.png" + "\";alt=\"tongue\"/>";
                input = input.Replace(":P", smiley);
                input = input.Replace(":-P", smiley);
            }

            if (input.Contains(":\">") )
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_red.png" + "\";alt=\"blush\"/>";
                input = input.Replace(":\">", smiley);
               
            }
            if (input.Contains(":|") || input.Contains(":-|"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_neutral.png" + "\";alt=\"straight face\"/>";
                input = input.Replace(":|", smiley);
                input = input.Replace(":-|", smiley);
            }
            if (input.Contains("X(") || input.Contains("X-("))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_mad.png" + "\";alt=\"mad\"/>";
                input = input.Replace("X(", smiley);
                input = input.Replace("X-(", smiley);
            }
            if (input.Contains(":))") || input.Contains(":-))"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_lol.png" + "\";alt=\"lol\"/>";
                input = input.Replace(":))", smiley);
                input = input.Replace(":-))", smiley);
            }

            if (input.Contains(":D") || input.Contains(":-D"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_grin.png" + "\";alt=\"Big grin\"/>";
                input = input.Replace(":D", smiley);
                input = input.Replace(":-D", smiley);
            }
            if (input.Contains(">:)") )
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_evil.png" + "\";alt=\"Devilish\"/>";
                input = input.Replace(">:)", smiley);
                
            }
            if (input.Contains(":-t") || input.Contains(":t"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_eek.png" + "\";alt=\"eek\"/>";
                input = input.Replace(":t", smiley);
                input = input.Replace(":-t", smiley);
            }

            if (input.Contains(":((") || input.Contains(":-(("))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_cry.png" + "\";alt=\"cry\"/>";
                input = input.Replace(":((", smiley);
                input = input.Replace(":-((", smiley);
            }
            if (input.Contains("B-)") )
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_cool.png" + "\";alt=\"cool\"/>";
                input = input.Replace("B-)", smiley);
               
            }
            if (input.Contains(":-/") || input.Contains(":/"))
            {

                smiley = "<img src=\"" + System.IO.Path.GetTempPath() + "smiley_confuse.png" + "\";alt=\"confuse\"/>";
                input = input.Replace(":/", smiley);
                input = input.Replace(":-/", smiley);
            }

            if (input.Contains("<BUZZ>"))
            {
                
                input = input.Replace("<BUZZ>", "<font color=\"red\"><strong>BUZZ!!!</strong></font>");
                BuzzAction();
               
            }


            return input;
        }








        private void panel16_Click(object sender, EventArgs e)
        {
            Emoticons_LostFocus();
        }
        
        SoundPlayer player = new SoundPlayer();
        
        
        
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            pictureBox20.Enabled = false;
                BuzzAction();
                sendmessage(this.Name, "<BUZZ>");
                imsender = true;
                displaymessage(myname, "<font color=\"red\"><strong>BUZZ!!!</strong></font>");
            
            
        }
        public void BuzzAction()
        {

            player.Stream = BuzzAudioStream;
            player.Play();

            Nudge nudged = new Nudge(this);
            nudged.NudgeMe();
            


        }
        int scroll=30;
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = this.webBrowser1.Document;
            doc.Body.ScrollTop = 300+ scroll;
            scroll = scroll + 30;

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // count = true;
            pictureBox20.Enabled = true;
            timer1.Enabled = false;
        }

       
       
        
      
        
       

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;

using agsXMPP;
using agsXMPP.protocol.client;
using RosterItemControl;

namespace Mtalk
{
    public partial class Form1 : Form
    {
        public static Form1 staticVar = null;
        public static string uname;
        public static string fullname;
        public static string Aname = null;
        Panel r1;
        Label l1;
        Dictionary<string, agsXMPP.protocol.iq.roster.RosterItem> contactsRoster = new Dictionary<string, agsXMPP.protocol.iq.roster.RosterItem>();
        Dictionary<string,Image> VCardImage=new  Dictionary<string,Image>();
        Thread t;
        Image mypicture;
        Message m;
        
        //Dictionary<string, agsXMPP.protocol.iq.roster.RosterItem> contactsRosterUpdated = new Dictionary<string, agsXMPP.protocol.iq.roster.RosterItem>();
        Dictionary<string, agsXMPP.protocol.iq.roster.RosterItem> PresenceRoster = new Dictionary<string, agsXMPP.protocol.iq.roster.RosterItem>();

        SortedDictionary<string, agsXMPP.protocol.client.Presence> availableRoster = new SortedDictionary<string, agsXMPP.protocol.client.Presence>();
        SortedDictionary<string, agsXMPP.protocol.client.Presence> busyRoster = new SortedDictionary<string, agsXMPP.protocol.client.Presence>();
        SortedDictionary<string, agsXMPP.protocol.client.Presence> idleRoster = new SortedDictionary<string, agsXMPP.protocol.client.Presence>();
        SortedDictionary<string, agsXMPP.protocol.client.Presence> invisibleRoster = new SortedDictionary<string, agsXMPP.protocol.client.Presence>();

        Dictionary<string, agsXMPP.protocol.client.Message> mess = new Dictionary<string, agsXMPP.protocol.client.Message>();
       
        RosterForm f;

        public  XmppClientConnection xmpp = new XmppClientConnection();

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
        [DllImport("user32.dll")]
        private static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);


        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            xmpp.OnLogin += new ObjectHandler(xmpp_OnLogin);
            xmpp.OnError += new ErrorHandler(xmpp_OnError);
            xmpp.OnClose += new ObjectHandler(xmpp_OnClose);

            xmpp.OnRosterStart += new ObjectHandler(xmpp_OnRosterStart);
            xmpp.OnRosterEnd += new ObjectHandler(xmpp_OnRosterEnd);
            xmpp.OnRosterItem += new XmppClientConnection.RosterHandler(xmpp_OnRosterItem);
            xmpp.OnPresence += new agsXMPP.protocol.client.PresenceHandler(xmpp_OnPresence);
            xmpp.OnMessage += new agsXMPP.protocol.client.MessageHandler(xmpp_OnMessage);
           // ViewSelectlabel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ViewSelectlabel.Width, ViewSelectlabel.Height, 20, 20));
            ViewPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ViewPanel.Width, ViewPanel.Height, 10, 10));


            staticVar = this;
        }
        int Xp, Yp;
        Point pt = new System.Drawing.Point();

        int rX, rY;
        Point rP = new System.Drawing.Point();

         [DllImport("user32.dll")]
        static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
 
     

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
           // ControlPaint.DrawBorder(e.Graphics, this.BorderPanel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void BorderPanel_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void BorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void BorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Xp = MousePosition.X - this.Location.X;
            Yp = MousePosition.Y - this.Location.Y;

        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                pt = MousePosition;
                pt.X = pt.X - Xp;
                pt.Y = pt.Y - Yp;
                this.Location = pt;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
                     

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SignInButton.Enabled = false;
            smileycreate();
            if (File.Exists("un.dat"))
            {
                TextReader tr = new StreamReader("un.dat");


                string username = Decrypt(tr.ReadLine(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                string password = Decrypt(tr.ReadLine(), "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);

                tr.Close();

                UserName.Text = username;
                Password.Text = password;
                Presencelabel.Hide();
                Rosterpanel.Hide();
                OnlinePanel.Hide();
                ViewPanel.Hide();
                StatusChoose.Hide();
                SMessageBox.Hide();
             


            }



        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resize_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                rX = MousePosition.X - this.Location.X;
                rY = MousePosition.Y - this.Location.Y;
            }
            catch 
            {
                MessageBox.Show("Form1,resize mouse down");
            }
        }

        private void resize_MouseMove(object sender, MouseEventArgs e)
        {
            try {


                if ((e.Button == MouseButtons.Left))//&&(this.Width>=256 && this.Height>=569))
                {
                    rP = MousePosition;
                    rX = MousePosition.X - this.Location.X;
                    rY = MousePosition.Y - this.Location.Y;
                    //if (rX >= 256 && rY >= 569 && rX <= 500)
                    {
                        this.Width = rX;
                        this.Height = rY;
                    }

            
                }
            }
            catch 
            {
                MessageBox.Show("form1 :resize mouse move");
            }


        }

      
        private void SignInButton_Click(object sender, EventArgs e)
        {
           //SignInButton.Enabled = false;
            SigninPanel.Enabled = false;



           if (RememberPassword.Checked == true && String.IsNullOrEmpty(UserName.Text) == false && String.IsNullOrEmpty(Password.Text) == false)
           {


               string enc_uname = Encrypt(UserName.Text, "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
               string enc_pword = Encrypt(Password.Text, "Pas5pr@se", "s@1tValue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);

               TextWriter tw1 = new StreamWriter("un.dat");
               File.SetAttributes("un.dat", File.GetAttributes("un.dat") | FileAttributes.Hidden);


               tw1.WriteLine(enc_uname);
               tw1.WriteLine(enc_pword);

               tw1.Close();

           }

            if (UserName.Text.IndexOf("@gmail.com") == -1)
                fullname = UserName.Text + "@gmail.com";
            else
                fullname = UserName.Text;


            Jid jidUser = new Jid(fullname);
            xmpp.Server = jidUser.Server;
            xmpp.ConnectServer = "talk.google.com";


            xmpp.Username = jidUser.User;
            xmpp.Password = Password.Text;
            xmpp.AutoResolveConnectServer = true;
            xmpp.ClientVersion = "MTalk Beta v0.3";
            xmpp.Resource = "MTalk.v0.3";
            xmpp.Open();


            uname = jidUser.Bare;
           
            UserName.Enabled = false;
            Password.Enabled = false;
            Statuslabel.Text = jidUser.User;
            Presencelabel.Show();
            Presencelabel.Text = "Connecting";
            comboBox1.Hide();
            StatusChoose.Show();
            NewStatuslabel.Text = jidUser.User;
            
           

           
        }


        void xmpp_OnLogin(object sender)
        {

            if (InvokeRequired)
            {

                BeginInvoke(new ObjectHandler(xmpp_OnLogin), new object[] { sender });
                return;
            }
            SigninPanel.Dispose();
            if (OnlinePanel.Controls.Count < 8)
                OnlinePanel.AutoScroll = false;
            else
                OnlinePanel.AutoScroll = true;

            

          
           
            notifyIcon1.Icon = new Icon(GetType(),"Network.ico");
            Presencelabel.Text = "Connected";
        
            Statuslabel.Hide();
            StatusChoose.Show();
            ViewPanel.Show();


            //MessageBox.Show("Login Success");
        }
        void xmpp_OnClose(object sender)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ObjectHandler(xmpp_OnClose), new object[] { sender });
                return;
            }
            MessageBox.Show("onClose");

        }

        void xmpp_OnError(object sender, Exception ex)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ErrorHandler(xmpp_OnError), new object[] { sender, ex });
                return;
            }

            Presencelabel.Text = "Error Connecting";
            UserName.Enabled = true;
            Password.Enabled = true;
            SignInButton.Enabled = true;


            DialogResult dialog=MessageBox.Show("Error connecting !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (dialog.ToString().Equals("OK"))
            {
                Presencelabel.Text = "Offline";
                Statuslabel.Text = "Sign In";
            }

                
        }

        void xmpp_OnPresence(object sender, agsXMPP.protocol.client.Presence pres)
        {
            
            if (InvokeRequired)
            {
                // Windows Forms are not Thread Safe, we need to invoke this :(
                // We're not in the UI thread, so we need to call BeginInvoke				
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(xmpp_OnPresence), new object[] { sender, pres });
                return;
            }
            
            try{
               

                if ((FormWindowState.Minimized == WindowState||this.Visible==false )&& pres.Show.ToString() == "NONE"&&pres.Type != agsXMPP.protocol.client.PresenceType.unavailable)
                {
                    PresencePopUp fm = new PresencePopUp();

                    if (VCardImage.ContainsKey(pres.From.Bare))
                    {
                        if (VCardImage[pres.From.Bare] != null)
                            fm.pictureBox1.Image = VCardImage[pres.From.Bare];
                        else
                            fm.pictureBox1.Image = Properties.Resources.Moon;
                    }
                    else
                        fm.pictureBox1.Image = Properties.Resources.Moon;

                    if (contactsRoster.ContainsKey(pres.From.Bare))
                    {

                        if (String.IsNullOrEmpty(contactsRoster[pres.From.Bare].Name))
                          fm.label1.Text = contactsRoster[pres.From.Bare].Jid.Bare +" is online";
                        else
                            fm.label1.Text = contactsRoster[pres.From.Bare].Name + " is online";
                    }
                    fm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - 250, Screen.PrimaryScreen.WorkingArea.Bottom-100);

                    fm.Show();
                }


            if (pres.From.Bare.Equals(fullname) == false)
            {
                if (pres.Type != agsXMPP.protocol.client.PresenceType.unavailable)
                {
                    //Available
                    if (pres.Show == ShowType.NONE)
                    {
                        if (availableRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            availableRoster.Remove(pres.From.Bare.ToLower());
                            availableRoster.Add(pres.From.Bare.ToLower(), pres);
                        }

                        else if (busyRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            busyRoster.Remove(pres.From.Bare.ToLower());
                        }

                        else if (idleRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            idleRoster.Remove(pres.From.Bare.ToLower());
                        }


                        if (availableRoster.ContainsKey(pres.From.Bare.ToLower()) == false)
                        {
                            availableRoster.Add(pres.From.Bare.ToLower(), pres);
                        }
                    }
                    //Busy
                    else if (pres.Show == ShowType.dnd)
                    {
                        if (busyRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            busyRoster.Remove(pres.From.Bare.ToLower());
                            busyRoster.Add(pres.From.Bare.ToLower(), pres);
                        }

                        else if (availableRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            availableRoster.Remove(pres.From.Bare.ToLower());
                        }

                        else if (idleRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            idleRoster.Remove(pres.From.Bare.ToLower());
                        }


                        if (busyRoster.ContainsKey(pres.From.Bare.ToLower()) == false)
                        {
                            busyRoster.Add(pres.From.Bare.ToLower(), pres);
                        }
                    }
                    //Away
                    else if (pres.Show == ShowType.away)
                    {
                        if (idleRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            idleRoster.Remove(pres.From.Bare.ToLower());
                            idleRoster.Add(pres.From.Bare.ToLower(), pres);
                        }

                        else if (busyRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            busyRoster.Remove(pres.From.Bare.ToLower());
                        }

                        else if (availableRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            availableRoster.Remove(pres.From.Bare.ToLower());
                        }


                        if (idleRoster.ContainsKey(pres.From.Bare.ToLower()) == false)
                        {
                            idleRoster.Add(pres.From.Bare.ToLower(), pres);
                        }
                    }

                   


                }
                else  if (pres.Type == agsXMPP.protocol.client.PresenceType.unavailable)
                {

                    if (invisibleRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            invisibleRoster.Remove(pres.From.Bare.ToLower());
                         
                        }
                    else if (idleRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            idleRoster.Remove(pres.From.Bare.ToLower());
                        }

                    else if (busyRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            busyRoster.Remove(pres.From.Bare.ToLower());
                        }

                    else if (availableRoster.ContainsKey(pres.From.Bare.ToLower()) == true)
                        {
                            availableRoster.Remove(pres.From.Bare.ToLower());
                        }

                        
                   
                }

            }

            }
            catch 
            {
                MessageBox.Show("form1:on presence");
            }

            CreateOnlineRoster();

        }

        void xmpp_OnRosterItem(object sender, agsXMPP.protocol.iq.roster.RosterItem item)
        {
            if (InvokeRequired)
            {
                // Windows Forms are not Thread Safe, we need to invoke this :(
                // We're not in the UI thread, so we need to call BeginInvoke				
                BeginInvoke(new XmppClientConnection.RosterHandler(xmpp_OnRosterItem), new object[] { sender, item });
                return;
            }
            //listEvents.Items.Add(String.Format("Received Contact {0}", item.Jid.Bare));
            //listEvents.SelectedIndex = listEvents.Items.Count - 1;

            if (item.Jid.Server == "gmail.com")
            {
                contactsRoster.Add(item.Jid.Bare, item);


                agsXMPP.protocol.iq.vcard.VcardIq viq = new agsXMPP.protocol.iq.vcard.VcardIq(agsXMPP.protocol.client.IqType.get, new Jid(item.Jid.Bare));
                xmpp.IqGrabber.SendIq(viq, new agsXMPP.IqCB(VcardResult), null);
            }
            
           
            
            
        }
        string boxname = null; bool chatformpresent = false; ChatForm f2;
        void xmpp_OnMessage(object sender, agsXMPP.protocol.client.Message msg)
        {

            // ignore empty messages (events)

            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.protocol.client.MessageHandler(xmpp_OnMessage), new object[] { sender, msg });
                return;
            }
            try{
            if (msg.Body == null)
                return;

            boxname = msg.From.Bare;
          
            //Check if window exist,if not open new window
            EventArgs arg = new EventArgs();
            ChatImage_Click((object)NewMessageButton, arg);


            chatformpresent = false;
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.Name.Equals(chatfrom) && OpenForm.GetType().Name.Equals("ChatForm"))
                {
                    if (OpenForm.Name.Equals(boxname))
                    {
                        chatformpresent = true;
                        f2 = (ChatForm)OpenForm;
                        break;
                    }
                }
            }
           

            

                if (chatformpresent == true)
                {
                    f2.displaymessage(boxname, msg.Body);
                }


            }
            catch 
            {
                MessageBox.Show("Form1:on message");
            }




        }













        void CreateOnlineRoster()
        {
            
            OnlinePanel.Controls.Clear();
            OnlinePanel.Hide();
          
            foreach (KeyValuePair<string, agsXMPP.protocol.client.Presence> item in availableRoster)
            {
                RosterItemControl.RosterItemControl roster = new RosterItemControl.RosterItemControl();
                    

                try
                {
                    roster.MainPanel.MouseHover += new EventHandler(roster_MouseHover);
                    roster.MainPanel.MouseLeave += new EventHandler(MainPanel_MouseLeave);
                    roster.MainPanel.Click += new EventHandler(ChatImage_Click);
                    roster.NameLabel.MouseEnter += new EventHandler(roster_MouseHover);
                    roster.Name = item.Value.From.Bare.ToLower();
                }
                catch 
                {
                    MessageBox.Show("Available:Roster Creation PLace");
                }

                try
                {

                    if (contactsRoster.ContainsKey(item.Value.From.Bare.ToLower()))
                    {
                        if (String.IsNullOrEmpty(contactsRoster[item.Value.From.Bare.ToLower()].Name))
                        {
                            roster.NameLabel.Text = contactsRoster[item.Value.From.Bare.ToLower()].Jid.Bare;

                        }
                        else
                        {
                            roster.NameLabel.Text = contactsRoster[item.Value.From.Bare.ToLower()].Name;

                        }
                    }
                    if(string.IsNullOrEmpty(item.Value.Status))
                              roster.StatusLabel.Text="Available";
                        
                    else
                    roster.StatusLabel.Text = item.Value.Status;

                    roster.StatusImage.Image = Properties.Resources.green;
                }
                catch
                {
                    MessageBox.Show("Available:check contacts roster");
                }

                try
                {
                    if (VCardImage.ContainsKey(item.Value.From.Bare.ToLower()))
                    {
                        if (VCardImage[item.Value.From.Bare] != null)
                        {
                            roster.VCardImage.Image = VCardImage[item.Value.From.Bare.ToLower()];
                        }
                        else
                        {
                            roster.VCardImage.Image = Properties.Resources.Moon;
                        }
                    }
                    else
                    {
                        roster.VCardImage.Image = Properties.Resources.Moon;
                    }
                }
                catch
                {
                    MessageBox.Show("Available:vcard");
                }
                roster.Dock = DockStyle.Left;
               OnlinePanel.Controls.Add(roster);

            }
            foreach (KeyValuePair<string, agsXMPP.protocol.client.Presence> item in busyRoster)
            {
                RosterItemControl.RosterItemControl roster = new RosterItemControl.RosterItemControl();
                   
                try
                {
                    roster.MainPanel.MouseHover += new EventHandler(roster_MouseHover);
                    roster.MainPanel.MouseLeave += new EventHandler(MainPanel_MouseLeave);
                    roster.NameLabel.MouseEnter += new EventHandler(roster_MouseHover);
                    roster.MainPanel.Click += new EventHandler(ChatImage_Click);

                    roster.Name = item.Value.From.Bare.ToLower();
                }
                catch
                {
                    MessageBox.Show("busy:roster create");
                }

                try
                {
                    if (contactsRoster.ContainsKey(item.Value.From.Bare.ToLower()))
                    {
                        if (String.IsNullOrEmpty(contactsRoster[item.Value.From.Bare.ToLower()].Name))
                        {
                            roster.NameLabel.Text = contactsRoster[item.Value.From.Bare.ToLower()].Jid.Bare;

                        }
                        else
                        {
                            roster.NameLabel.Text = contactsRoster[item.Value.From.Bare.ToLower()].Name;

                        }
                        if (string.IsNullOrEmpty(item.Value.Status))
                            roster.StatusLabel.Text = "Busy";

                        else
                        roster.StatusLabel.Text = item.Value.Status;
                        roster.StatusImage.Image = Properties.Resources.red;
                    }
                }
                catch
                {
                    MessageBox.Show("busy:check contacts roster");
                }

                try
                {
                    if (VCardImage.ContainsKey(item.Value.From.Bare.ToLower()))
                    {
                        if (VCardImage[item.Value.From.Bare.ToLower()] != null)
                        {
                            roster.VCardImage.Image = VCardImage[item.Value.From.Bare.ToLower()];
                        }
                        else
                        {
                            roster.VCardImage.Image = Properties.Resources.Moon;
                        }
                    }
                    else
                    {
                        roster.VCardImage.Image = Properties.Resources.Moon;
                    }
                }
                catch
                {
                    MessageBox.Show("busy:vcard");
                }
                roster.Dock = DockStyle.Left;
                OnlinePanel.Controls.Add(roster);

            }
            foreach (KeyValuePair<string, agsXMPP.protocol.client.Presence> item in idleRoster)
            {
                RosterItemControl.RosterItemControl roster = new RosterItemControl.RosterItemControl();
                   
                try
                {

                    roster.MainPanel.MouseHover += new EventHandler(roster_MouseHover);
                    roster.MainPanel.MouseLeave += new EventHandler(MainPanel_MouseLeave);
                    roster.NameLabel.MouseEnter += new EventHandler(roster_MouseHover);
                    roster.MainPanel.Click += new EventHandler(ChatImage_Click);
                    roster.Name = item.Value.From.Bare.ToLower();
                }
                catch
                {
                    MessageBox.Show("idle:create roster");
                }
                try
                {
                    if (contactsRoster.ContainsKey(item.Value.From.Bare.ToLower()))
                    {
                        if (String.IsNullOrEmpty(contactsRoster[item.Value.From.Bare.ToLower()].Name))
                        {
                            roster.NameLabel.Text = contactsRoster[item.Value.From.Bare.ToLower()].Jid.Bare;

                        }
                        else
                        {
                            roster.NameLabel.Text = contactsRoster[item.Value.From.Bare.ToLower()].Name;

                        }
                    }
                    if (string.IsNullOrEmpty(item.Value.Status))
                        roster.StatusLabel.Text = "Idle";

                    else
                    roster.StatusLabel.Text = item.Value.Status;
                    roster.StatusImage.Image = Properties.Resources.orange;
                }
                catch
                {
                    MessageBox.Show("idle:check contacts roster");
                }
                try
                {
                    if (VCardImage.ContainsKey(item.Value.From.Bare.ToLower()))
                    {
                        if (VCardImage[item.Value.From.Bare.ToLower()] != null)
                        {
                            roster.VCardImage.Image = VCardImage[item.Value.From.Bare.ToLower()];
                        }
                        else
                        {
                            roster.VCardImage.Image = Properties.Resources.Moon;
                        }
                    }
                    else
                    {
                        roster.VCardImage.Image = Properties.Resources.Moon;
                    }
                }
                 catch
                {
                    MessageBox.Show("idle:vcard");
                }
                roster.Dock = DockStyle.Left;
                OnlinePanel.Controls.Add(roster);

            }

            if (OnlinePanel.Controls.Count < 8)
                  OnlinePanel.AutoScroll = false;
            else
                OnlinePanel.AutoScroll = true;

          OnlinePanel.Show();
        }

        bool createroster = false;
        void CreateRosterView()
        {

            createroster = true;
            Rosterpanel.Hide();
            Rosterpanel.Resize += new EventHandler(Rosterpanel_Resize);
             foreach (KeyValuePair<string,agsXMPP.protocol.iq.roster.RosterItem> item in contactsRoster)
            {
              
                
                //PresenceRoster.Add(item.Value.Jid.Bare,
            
                RosterItemControl.RosterItemControl roster = new RosterItemControl.RosterItemControl();
                roster.MainPanel.MouseHover += new EventHandler(roster_MouseHover);
                roster.MainPanel.MouseLeave += new EventHandler(MainPanel_MouseLeave);

                roster.NameLabel.MouseEnter+=new EventHandler(roster_MouseHover);
                roster.MainPanel.Click += new EventHandler(ChatImage_Click);
                roster.Name = item.Value.Jid.Bare;


                if (String.IsNullOrEmpty(item.Value.Name))
                {
                    roster.NameLabel.Text = item.Value.Jid.Bare;
                   
                }
                else
                {
                    roster.NameLabel.Text = item.Value.Name;
                   
                }



                if (VCardImage.ContainsKey(item.Value.Jid.Bare.ToLower()))
                        roster.VCardImage.Image = VCardImage[item.Value.Jid.Bare.ToLower()];
                    else
                        roster.VCardImage.Image = Properties.Resources.Moon;
                
                
                roster.Dock = DockStyle.Left;
                Rosterpanel.Controls.Add(roster);
                
            }
            

            
        }

        void Rosterpanel_Resize(object sender, EventArgs e)
        {
            ShowScrollBar(this.Rosterpanel.Handle, 0, false);
        }

        void Onlinepanel_Resize(object sender, EventArgs e)
        {
            ShowScrollBar(this.OnlinePanel.Handle, 0, false);
        }
        

        bool check = false;
        void roster_MouseHover(object sender, EventArgs e)
        {

            try
            {
                r1 = (Panel)sender;
            }
            catch
            {
                l1 = (Label)sender;
                r1 = (Panel)l1.Parent;
            }
            try
            {

                Rectangle screensize = Screen.PrimaryScreen.Bounds;
                int rX = 0;

                if (OnlinePanel.Visible == true)
                {
                    if (OnlinePanel.AutoScroll == true)
                        rX = this.Left + this.Width - 25;
                    else
                        rX = this.Left + this.Width - 15;
                }
                else if (Rosterpanel.Visible == true)
                {
                    if (Rosterpanel.AutoScroll == true)
                        rX = this.Left + this.Width - 25;
                    else
                        rX = this.Left + this.Width - 15;
                }
                check = false;
                int rY = this.Top + r1.Location.Y + r1.Parent.Location.Y + r1.Parent.Parent.Location.Y + r1.Parent.Parent.Parent.Location.Y + r1.Parent.Parent.Parent.Parent.Location.Y + r1.Parent.Parent.Parent.Parent.Parent.Location.Y;

                if ((screensize.Right - this.Right) < 320)
                {

                    rX = this.Left - 305;
                    check = true;
                }


                if (f != null)
                    if (!f.IsDisposed)
                        f.Dispose();

                f = new RosterForm(rX, rY);
                f.MouseLeave += new EventHandler(MainPanel_MouseLeave);
                f.ChatImage.Click += new EventHandler(ChatImage_Click);
                f.IconsPanel.MouseLeave += new EventHandler(MainPanel_MouseLeave);

                if (check == true)
                    f.Rightpanel.Enabled = false;
                else
                    f.Leftpanel.Enabled = false;


                f.Emaillabel.Text = r1.Parent.Name;
                f.Name = r1.Parent.Name;
                if (contactsRoster.ContainsKey(r1.Parent.Name.ToLower()))
                {
                    f.Namelabel.Text = contactsRoster[r1.Parent.Name.ToLower()].Name;
                }
                f.Statuslabel.Text = r1.Controls["StatusLabel"].Text;

                if (VCardImage.ContainsKey(r1.Parent.Name.ToLower()))
                {
                    if (VCardImage[r1.Parent.Name.ToLower()] != null)
                    {
                        f.VCardImage.Image = VCardImage[r1.Parent.Name.ToLower()];
                        //   ((PictureBox)r1.Controls["VCardImage"]).Image=VCardImage[r1.Parent.Name];
                    }
                    else
                    {
                        f.VCardImage.Image = Properties.Resources.Moon;
                        //   ((PictureBox)r1.Controls["VCardImage"]).Image=Properties.Resources.Moon;
                    }
                }
                else
                {
                    f.VCardImage.Image = Properties.Resources.Moon;
                    //   ((PictureBox)r1.Controls["VCardImage"]).Image=Properties.Resources.Moon;
                }


                // f.Namelabel.Text = 
                //f.Statuslabel.Text = this.Left.ToString() + "," + this.Top.ToString() + "," + this.Right.ToString() + "," + this.Bottom.ToString();
                f.Location = new Point(rX, rY);


                f.Show();
            }
           
            catch 
            {
                MessageBox.Show("form1:roster mouse hover");
            }


        }


        ChatForm c;
        ChatForm f1;
        
        bool formpresent = false;
        string chatfrom = null;
        void ChatImage_Click(object sender, EventArgs e)
        {
            try{

            if(f!=null)
                if (!f.IsDisposed)
                    f.Dispose();

            formpresent = false;

            Control cntrl = (Control)sender;

            if (cntrl.Name.Equals("NewMessageButton"))
                chatfrom = boxname;
            else
            {
                if (f != null)
                {
                   chatfrom = f.Name;
                }
                else if (f == null)
                {
                    chatfrom = cntrl.Parent.Name;
                }

            }

            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.Name.Equals(chatfrom) &&OpenForm.GetType().Name.Equals("ChatForm"))
                {
                    if (OpenForm.Name.Equals(chatfrom))
                    {
                        formpresent = true;
                        f1 =(ChatForm) OpenForm;
                        break;
                    }
                }
            }
            if (formpresent == true)
            {
                if (f1.WindowState == FormWindowState.Minimized)
                {
                    f1.WindowState = FormWindowState.Normal;
                }
                else
                    f1.Activate();
                //f1.webBrowser1.DocumentText

                

            }
            else if (formpresent == false)
            {

                c = new ChatForm();
                c.Name = chatfrom;
                

                if (String.IsNullOrEmpty(contactsRoster[chatfrom].Name))
                {
                    c.Titlelabel.Text = contactsRoster[chatfrom].Jid.Bare;

                }
                else
                {
                    c.Titlelabel.Text = contactsRoster[chatfrom].Name;

                }

                if (VCardImage.ContainsKey(chatfrom))
                {
                    if (VCardImage[chatfrom] != null)
                    {
                        c.Contactpicture.Image = VCardImage[chatfrom];
                    }
                    else
                    {
                        c.Contactpicture.Image = Properties.Resources.Moon;
                    }
                }
                else
                {
                    c.Contactpicture.Image = Properties.Resources.Moon;
                }

                c.MyPicture.Image = mypicture;
                c.Text = c.Titlelabel.Text;
                //if (f != null)
                //    if (!f.IsDisposed)
                //        f.Dispose();
                c.Show();


            }
            }
            catch
            {
                MessageBox.Show("form1:chatimage click");
            }


            }

     


        //bool rformpresent = false;
        //Form rosterF;
            
        void    MainPanel_MouseLeave(object sender, EventArgs e)
        {
                          
                if(f!=null)
                    if(f.IsDisposed==false)
                        
                          if(f.Bounds.Contains(MousePosition)==false)
                            {
                                f.Dispose();

                            }
            

        }
        

        void xmpp_OnRosterStart(object sender)
        {
            if (InvokeRequired)
            {
                // Windows Forms are not Thread Safe, we need to invoke this :(
                // We're not in the UI thread, so we need to call BeginInvoke				
                BeginInvoke(new ObjectHandler(xmpp_OnRosterStart), new object[] { sender });
                return;
            }
            agsXMPP.protocol.iq.vcard.VcardIq viq = new agsXMPP.protocol.iq.vcard.VcardIq(agsXMPP.protocol.client.IqType.get, new Jid(fullname));
            xmpp.IqGrabber.SendIq(viq, new agsXMPP.IqCB(VcardResult), null);
        }




        private void VcardResult(object sender, agsXMPP.protocol.client.IQ iq, object data)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new agsXMPP.IqCB(VcardResult), new object[] { sender, iq, data });
                return;
            }
            
            //get the jid of the vcard
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(iq.ToString());
            //XmlNode node = doc.FirstChild;
            //foreach (XmlNode node1 in node.ChildNodes)
            //    foreach (XmlNode node2 in node1.ChildNodes)
                
            try{
                    

            if (iq.Type == agsXMPP.protocol.client.IqType.result)
            {
                agsXMPP.protocol.iq.vcard.Vcard vcard = iq.Vcard;
              
                if (vcard != null)
                {
                    agsXMPP.protocol.iq.vcard.Photo photo = vcard.Photo;
                    if (iq.From.Bare.ToLower().Equals(fullname) == false)
                    {
                        
                        if (photo != null)
                            VCardImage.Add(iq.From.Bare.ToLower(), photo.Image);

                        else
                            VCardImage.Add(iq.From.Bare.ToLower(), null);
                    }
                    else if (iq.From.Bare.ToLower().Equals(fullname) == true)
                    {
                       // Statuslabel.Text = vcard.Fullname;
                        NewStatuslabel.Text = vcard.Fullname;
                        Aname = vcard.Fullname;
                        


                        if (photo != null)
                        {
                            SelfPicture.Image = photo.Image;
                            mypicture = photo.Image;
                        }
                        else
                        {
                            SelfPicture.Image = Properties.Resources.Moon;
                            mypicture = Properties.Resources.Moon;
                        }
                    }



                }
               


            }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        void xmpp_OnRosterEnd(object sender)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ObjectHandler(xmpp_OnRosterEnd), new object[] { sender });
                return;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                xmpp.Show = agsXMPP.protocol.client.ShowType.NONE;
                xmpp.Status = "Available";
                StatusPictureBox.Image = Properties.Resources.green;
                Presencelabel.Text = "Available";
                xmpp.SendMyPresence();
                    
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                xmpp.Show = agsXMPP.protocol.client.ShowType.dnd;
                xmpp.Status = "Busy";
                StatusPictureBox.Image = Properties.Resources.red;
                Presencelabel.Text = "Busy";
                xmpp.SendMyPresence();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //Invisible mode..yet to implement..signing in as available
                xmpp.Show = agsXMPP.protocol.client.ShowType.NONE;
                xmpp.Status = "";
                StatusPictureBox.Image = Properties.Resources.contacts;
                Presence pres = new Presence();
                pres.Type = PresenceType.unavailable;
                pres.Priority = 5;

                xmpp.Send(pres);

                Presencelabel.Text = "Invisible";
            }
            else if (comboBox1.SelectedIndex == 3)
            {

                xmpp.Show = agsXMPP.protocol.client.ShowType.away;
                xmpp.Status = "Idle";
                StatusPictureBox.Image = Properties.Resources.orange;
                Presencelabel.Text = "Idle";
                xmpp.SendMyPresence();
            }




            OnlinePanel.Show();

           // CreateRosterView();




        }

      




        public static string Encrypt(string plainText,
                             string passPhrase,
                             string saltValue,
                             string hashAlgorithm,
                             int passwordIterations,
                             string initVector,
                             int keySize)
        {

            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            passPhrase,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
                                                             keyBytes,
                                                             initVectorBytes);

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         encryptor,
                                                         CryptoStreamMode.Write);
            // Start encrypting.
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            // Finish encrypting.
            cryptoStream.FlushFinalBlock();

            // Convert our encrypted data from a memory stream into a byte array.
            byte[] cipherTextBytes = memoryStream.ToArray();

            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();

            // Convert encrypted data into a base64-encoded string.
            string cipherText = Convert.ToBase64String(cipherTextBytes);

            // Return encrypted string.
            return cipherText;
        }


        public static string Decrypt(string cipherText,
                                     string passPhrase,
                                     string saltValue,
                                     string hashAlgorithm,
                                     int passwordIterations,
                                     string initVector,
                                     int keySize)
        {

            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);


            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);


            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            passPhrase,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(
                                                             keyBytes,
                                                             initVectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         decryptor,
                                                         CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            // Start decrypting.
            int decryptedByteCount = cryptoStream.Read(plainTextBytes,
                                                       0,
                                                       plainTextBytes.Length);

            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();

            // Convert decrypted data into a string. 
            // Let us assume that the original plaintext string was UTF8-encoded.
            string plainText = Encoding.UTF8.GetString(plainTextBytes,
                                                       0,
                                                       decryptedByteCount);

            // Return decrypted string.   
            return plainText;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserName.Text))
                SignInButton.Enabled = false;
            else if (String.IsNullOrEmpty(UserName.Text) == false && (String.IsNullOrEmpty(UserName.Text)) == false)
                SignInButton.Enabled = true;


        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Text))
                SignInButton.Enabled = false;
            else if (String.IsNullOrEmpty(Password.Text) == false && (String.IsNullOrEmpty(Password.Text)) == false)
                SignInButton.Enabled = true;


        }

        private void RememberPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (RememberPassword.Checked == false)
            {


                if (File.Exists("un.dat"))
                {

                    File.Delete("un.dat");


                }

            }

        }

        private void SignInButton_MouseEnter(object sender, EventArgs e)
        {
            SignInButton.BackgroundImage = Properties.Resources.button1over;
        }

        private void SignInButton_MouseLeave(object sender, EventArgs e)
        {
            SignInButton.BackgroundImage = Properties.Resources.button1up;
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Location = new Point(this.Left, (this.Top + this.Height / 2));
            a.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Statusbutton_MouseEnter(object sender, EventArgs e)
        {
            //Statusbutton.BackgroundImage = Properties.Resources.buttonSover;
          //  StatusList.Show();
        }

        private void Statusbutton_MouseLeave(object sender, EventArgs e)
        {
            //Statusbutton.BackgroundImage = Properties.Resources.buttonSup;
            //StatusList.Hide();
        }
        StatusListForm statusform;
        private void StatusChoose_MouseEnter(object sender, EventArgs e)
        {
            StatusChoose.BackColor = Color.LightCyan;
            NewStatuslabel.ForeColor = Color.Navy;
            
           
        }
       

        private void StatusChoose_Click(object sender, EventArgs e)
        {
            if (statusform == null)
            {
                
                int x = StatusChoose.Left + this.Left + 1;
                int y = StatusChoose.Bottom + this.Top + TopPanel.Height;
                statusform = new StatusListForm(x, y,StatusChoose.Width);
             
                statusform.panel1.Click += new EventHandler(this.bAvailable_Click);
                statusform.panel2.Click += new EventHandler(this.bBusy_Click);
                statusform.panel3.Click += new EventHandler(this.bInvisible_Click);
                statusform.panel4.Click += new EventHandler(this.bAway_Click);
                statusform.panel5.Click += new EventHandler(this.bSignOut_Click);



                statusform.Show();
            }
            else
            {
                if (!statusform.IsDisposed)
                    statusform.Dispose();

                else
                {
                    int x = StatusChoose.Left + this.Left + 1;
                    int y = StatusChoose.Bottom + this.Top + TopPanel.Height;

                    statusform = new StatusListForm(x, y,StatusChoose.Width);
                    statusform.panel1.Click += new EventHandler(this.bAvailable_Click);
                    statusform.panel2.Click += new EventHandler(this.bBusy_Click);
                    statusform.panel3.Click += new EventHandler(this.bInvisible_Click);
                    statusform.panel4.Click += new EventHandler(this.bAway_Click);
                    statusform.panel5.Click += new EventHandler(this.bSignOut_Click);

                    statusform.Show();
                }
            }
        }
        
        private void StatusChoose_MouseLeave(object sender, EventArgs e)
        {
          
            if (statusform == null)
            {
                StatusChoose.BackColor = Color.DeepSkyBlue;
                NewStatuslabel.ForeColor = Color.White;
            }
            else if (statusform != null)
                if (statusform.IsDisposed)
            {
              
                StatusChoose.BackColor = Color.DeepSkyBlue;
                NewStatuslabel.ForeColor = Color.White;

            }
          

            
           

           
                
                
           
        }

  
        private void bAvailable_Click(object sender, EventArgs e)
        {
            xmpp.Show = agsXMPP.protocol.client.ShowType.NONE;
            xmpp.Status = "Available";
            StatusPictureBox.Image = Properties.Resources.green;
            Presencelabel.Text = "Available";
            xmpp.SendMyPresence();
            statusform.Dispose();
            StatusChoose.BackColor = Color.DeepSkyBlue;
            NewStatuslabel.ForeColor = Color.White;
        }

        private void bBusy_Click(object sender, EventArgs e)
        {
            xmpp.Show = agsXMPP.protocol.client.ShowType.dnd;
            xmpp.Status = "Busy";
            StatusPictureBox.Image = Properties.Resources.red;
            Presencelabel.Text = "Busy";
            xmpp.SendMyPresence();
            statusform.Dispose();
            StatusChoose.BackColor = Color.DeepSkyBlue;
            NewStatuslabel.ForeColor = Color.White;
        }

        private void bInvisible_Click(object sender, EventArgs e)
        {
            //Invisible mode..yet to implement..signing in as available
            xmpp.Show = agsXMPP.protocol.client.ShowType.NONE;
            xmpp.Status = "";
           
            StatusPictureBox.Image = Properties.Resources.contacts;
            Presence pres = new Presence();
            pres.Type = PresenceType.unavailable;
            //pres.Priority = 5;

            xmpp.Send(pres);


            //Presencelabel.Text = "Invisible";
            //xmpp.SendMyPresence();
            statusform.Dispose();
            StatusChoose.BackColor = Color.DeepSkyBlue;
            NewStatuslabel.ForeColor = Color.White;
        }

        private void bAway_Click(object sender, EventArgs e)
        {
            xmpp.Show = agsXMPP.protocol.client.ShowType.away;
            xmpp.Status = "Idle";
            StatusPictureBox.Image = Properties.Resources.orange;
            Presencelabel.Text = "Idle";
            xmpp.SendMyPresence();
            statusform.Dispose();
            StatusChoose.BackColor = Color.DeepSkyBlue;
            NewStatuslabel.ForeColor = Color.White;
        }

        private void bSignOut_Click(object sender, EventArgs e)
        {


            if (statusform != null)
                if (!statusform.IsDisposed)
                {
                    statusform.Dispose();

                }
            StatusChoose.BackColor = Color.DeepSkyBlue;
            NewStatuslabel.ForeColor = Color.White;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

            if (statusform != null)
                if (!statusform.IsDisposed)
                {
                    statusform.Dispose();

                }
            

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            StatusChoose.BackColor = Color.DeepSkyBlue;
            NewStatuslabel.ForeColor = Color.White;

            if (statusform != null)
                if (!statusform.IsDisposed)
                {
                    statusform.Dispose();

                }
            if(f!=null)
                if (!f.IsDisposed)
                {
                    f.Dispose();
                }

        }

      

        private void Presencelabel_MouseEnter(object sender, EventArgs e)
        {
            Presencelabel.BackColor = Color.LightCyan;
            Presencelabel.ForeColor = Color.Navy;
        }

        private void Presencelabel_MouseLeave(object sender, EventArgs e)
        {
            Presencelabel.BackColor = Color.Transparent;
            Presencelabel.ForeColor = Color.White;

        }
    
        private void Presencelabel_Click(object sender, EventArgs e)
        {

            SMessageBox.Text=Presencelabel.Text;
            SMessageBox.Show();
           
           
        }

        private void SMessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                // Then Enter key was pressed
                Presencelabel.Text = SMessageBox.Text;

                if (SMessageBox.Text.Length > 26)
                {
                }
                else
                {
                    SMessageBox.Hide();
                    Presencelabel.Show();
                }

            }
        }

        private void Presencelabel_Click_1(object sender, EventArgs e)
        {
            Presencelabel.Hide();
            SMessageBox.Text = Presencelabel.Text;
            SMessageBox.Show();
        }
        int firstheight;
        private void bottomBorder_MouseDown(object sender, MouseEventArgs e)
        {
            Xp = MousePosition.X;// -this.Location.X;
            Yp = MousePosition.Y; //- this.Location.Y;
            firstheight = this.Height;
        }

        private void bottomBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = MousePosition;
                // pt.X = pt.X - Xp;
                pt.Y = pt.Y - Yp;
                this.Height = firstheight + pt.Y;
               

            }
        }

        int firstWidth;
        private void RightBorder_MouseDown(object sender, MouseEventArgs e)
        {
            Xp = MousePosition.X;// -this.Location.X;
            Yp = MousePosition.Y; //- this.Location.Y;
            firstWidth = this.Width;
        }

        private void RightBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pt = MousePosition;
                pt.X = pt.X - Xp;
                // pt.Y = pt.Y - Yp;
                this.Width = firstWidth + pt.X;
               
            }

        }

        private void ViewSelectlabel_MouseEnter(object sender, EventArgs e)
        {
            ViewSelectlabel.BackColor = Color.Navy;
        }

        private void ViewSelectlabel_MouseLeave(object sender, EventArgs e)
        {
            ViewSelectlabel.BackColor = Color.DarkTurquoise;
        }

        private void ViewSelectlabel_Click(object sender, EventArgs e)
        {
            if (ViewSelectlabel.Text.Equals("Online"))
            {
                ViewSelectlabel.Text = "Contacts";
                if (createroster == false)
                    CreateRosterView();
                Rosterpanel.Show();
                OnlinePanel.Hide();

            }
            else if (ViewSelectlabel.Text.Equals("Contacts"))
            {
                ViewSelectlabel.Text = "Online";
                OnlinePanel.Show();
                Rosterpanel.Hide();
            }
            
        }


        private void smileycreate()
        {

            Bitmap smile1 = Properties.Resources.smiley;
            smile1.Save(System.IO.Path.GetTempPath() + "smile.png");

            Bitmap smile2 = Properties.Resources.smiley_confuse;
            smile2.Save(System.IO.Path.GetTempPath() + "smiley_confuse.png");

            Bitmap smile3 = Properties.Resources.smiley_cool;
            smile3.Save(System.IO.Path.GetTempPath() + "smiley_cool.png");

            Bitmap smile4 = Properties.Resources.smiley_cry;
            smile4.Save(System.IO.Path.GetTempPath() + "smiley_cry.png");

            Bitmap smile5 = Properties.Resources.smiley_eek;
            smile5.Save(System.IO.Path.GetTempPath() + "smiley_eek.png");

            Bitmap smile6 = Properties.Resources.smiley_evil;
            smile6.Save(System.IO.Path.GetTempPath() + "smiley_evil.png");

            Bitmap smile7 = Properties.Resources.smiley_grin;
            smile7.Save(System.IO.Path.GetTempPath() + "smiley_grin.png");

            Bitmap smile8 = Properties.Resources.smiley_lol;
            smile8.Save(System.IO.Path.GetTempPath() + "smiley_lol.png");

            Bitmap smile9 = Properties.Resources.smiley_mad;
            smile9.Save(System.IO.Path.GetTempPath() + "smiley_mad.png");

            Bitmap smile10 = Properties.Resources.smiley_neutral;
            smile10.Save(System.IO.Path.GetTempPath() + "smiley_neutral.png");

            Bitmap smile11 = Properties.Resources.smiley_razz;
            smile11.Save(System.IO.Path.GetTempPath() + "smiley_razz.png");

            Bitmap smile12 = Properties.Resources.smiley_red;
            smile12.Save(System.IO.Path.GetTempPath() + "smiley_red.png");

            Bitmap smile13 = Properties.Resources.smiley_roll;
            smile13.Save(System.IO.Path.GetTempPath() + "smiley_roll.png");

            Bitmap smile14 = Properties.Resources.smiley_sad;
            smile14.Save(System.IO.Path.GetTempPath() + "smiley_sad.png");

            Bitmap smile15 = Properties.Resources.smiley_surprise;
            smile15.Save(System.IO.Path.GetTempPath() + "smiley_surprise.png");

            Bitmap smile16 = Properties.Resources.smiley_wink;
            smile16.Save(System.IO.Path.GetTempPath() + "smiley_wink.png");

        }

        private void deletesmiley()
        {
            if (File.Exists(System.IO.Path.GetTempPath() + "smile.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smile.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_wink.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smile_wink.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_surprise.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_surprise.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_sad.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_sad.png");
            
            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_roll.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_roll.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_red.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_red.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_razz.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_razz.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_neutral.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_neutral.png");
            
            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_mad.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_mad.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_lol.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_lol.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_grin.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_grin.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_evil.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_evil.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_eek.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_eek.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_cry.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_cry.png");
            
            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_cool.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_cool.png");

            if (File.Exists(System.IO.Path.GetTempPath() + "smiley_confuse.png"))
                File.Delete(System.IO.Path.GetTempPath() + "smiley_confuse.png");

        }

      

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;

        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            
            if (FormWindowState.Minimized == WindowState || this.Visible==false)
                a.StartPosition = FormStartPosition.CenterScreen;
            else
                a.StartPosition = FormStartPosition.CenterParent;
            
            a.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deletesmiley();
            
            xmpp.Close();
            this.Dispose();
        }

      

       

    }


   

}

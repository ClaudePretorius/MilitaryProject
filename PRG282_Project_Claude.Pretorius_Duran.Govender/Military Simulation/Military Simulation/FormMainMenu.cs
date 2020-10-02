using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Threading;

namespace Military_Simulation
{
    public partial class FormMainMenu : Form
    {

        internal static FormPlaneSelect form2 ;
        internal static FormMainMenu form1 ;

        
        // fields
        private IconButton currentBtn; //would be the current active button
        private Panel leftBorderBtn;
        private Panel leftBorderBtnSubMenu;
        public Form currentChildForm;

        public Thread thread1 = null; //declare thread for use of time calculations and date
        public bool ShowTime = true;



        //constructor
        public FormMainMenu()
        {
            form1 = this;
            form2 = new FormPlaneSelect();
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtnSubMenu = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            leftBorderBtnSubMenu.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            pnlAircraftSubMenu.Controls.Add(leftBorderBtnSubMenu);
            HideSubMenu(); //activate method for submenu
            //form
            this.Text = string.Empty; //the next three lines is to stop buffering when dragging form and get rid of form name ontop
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //to allow desktop toolbar to show on bottom when maximized app
            //time and date labels update
            thread1 = new Thread(new ThreadStart(Timer)); //thread for time and date label
            thread1.Start(); //starting thread for time label

        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(170, 130, 240);
            public static Color color2 = Color.FromArgb(250, 120, 175);
            public static Color color3 = Color.FromArgb(250, 140, 115);
            public static Color color4 = Color.FromArgb(95, 75, 220);
            public static Color color5 = Color.FromArgb(250, 90, 155);
            public static Color color6 = Color.FromArgb(25, 160, 250);
            public static Color color7 = Color.FromArgb(250, 50, 50);
        }

        private void HideSubMenu()
        {
            pnlAircraftSubMenu.Visible = false;
        }

        private void ShowSubMenu()
        {
            pnlAircraftSubMenu.Visible = true;
        }

        //method for if button in menu activated/clicked/isActive
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)//if button is clicked, thus if not null
            {
                DeActivateButton(); //this will deactivate button clicked before and restore original style features
                //button clicked/active
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(40, 40, 80);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor=color;
                currentBtn.TextImageRelation=TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign= ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                //lblTitle of current form
                if (currentBtn.Text == "Dashboard")
                {
                    lblTitleChildForm.Text = "Home";
                }
                else
                {
                    lblTitleChildForm.Text = currentBtn.Text;
                }
                
            }
        }

        //method for if button in Submenu activated/clicked/isActive
        private void ActivateButtonSubMenu(object senderBtnSub, Color color)
        {
            if (senderBtnSub != null)//if button is clicked, thus if not null
            {
                DeActivateButton(); //this will deactivate button clicked before and restore original style features
                //button clicked/active
                currentBtn = (IconButton)senderBtnSub;
                currentBtn.BackColor = Color.FromArgb(40, 40, 80);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtnSubMenu.BackColor = color;
                leftBorderBtnSubMenu.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtnSubMenu.Visible = true;
                leftBorderBtnSubMenu.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                //lblTitle of current form
                if (currentBtn.Text == "Dashboard")
                {
                    lblTitleChildForm.Text = "Home";
                }
                else
                {
                    lblTitleChildForm.Text = currentBtn.Text;
                }
            }
        }

        private void DeActivateButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
            
        }
        
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only the form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;  //remove edge of form for better style look and feel
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);//Display chosen childform on panel desktop to show form for UI interaction capabilities
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); //Display the form chose from menu by user
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(750, 500);
        }

        private void btnDashboardMenu_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                //open only the form
                currentChildForm.Close();
            }
            ActivateButton(sender, RGBColors.color1);
            HideSubMenu();
            this.MinimumSize = new System.Drawing.Size(750, 500);
        }

        private void btnAircraftMenu_Click(object sender, EventArgs e)
        {
            leftBorderBtnSubMenu.Visible = false;
            ActivateButton(sender, RGBColors.color2);
            if (pnlAircraftSubMenu.Visible==false)
            {
                ShowSubMenu();
            }
            else
            {
                HideSubMenu();
            }
        }

        private void btnAircraftAddSubMenu_Click(object sender, EventArgs e)
        {
            leftBorderBtn.Visible = false;
            ActivateButtonSubMenu(sender, RGBColors.color3);
            OpenChildForm(new FormAddAircraft());
            this.MinimumSize = new System.Drawing.Size(980, 550);
        }

        private void btnAircraftDeleteSubMenu_Click(object sender, EventArgs e)
        {
            leftBorderBtn.Visible = false;
            ActivateButtonSubMenu(sender, RGBColors.color4);
            OpenChildForm(new FormDeleteAircraft());
            this.MinimumSize = new System.Drawing.Size(900, 500);
        }

        private void btnAircraftEditSubMenu_Click(object sender, EventArgs e)
        {
            leftBorderBtn.Visible = false;
            ActivateButtonSubMenu(sender, RGBColors.color5);
            this.MinimumSize = new System.Drawing.Size(980, 550);
            OpenChildForm(new FormEditAircraft());
            
        }

        private void btnAircraftViewAllSubMenu_Click(object sender, EventArgs e)
        {
            leftBorderBtn.Visible = false;
            ActivateButtonSubMenu(sender, RGBColors.color6);
            this.MinimumSize = new System.Drawing.Size(760, 500);
            OpenChildForm(new FormViewAllAircraft());
        }

        private void btnSimulationMenu_Click(object sender, EventArgs e)
        {
            
            HideSubMenu();
            ActivateButton(sender, RGBColors.color7);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            OpenChildForm(new FormPlaneSelect());

        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)//Closes any open child forms displaying if any
            {
                //open only the form
                currentChildForm.Close();
            } 
            Reset(); //invoke reset method to clear menu formats
            this.MinimumSize = new System.Drawing.Size(750, 500);
        }

        private void Reset()
        {
            HideSubMenu();
            DeActivateButton();  
            leftBorderBtn.Visible = false;
            leftBorderBtnSubMenu.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int IParam);
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        public delegate void TimeDel(); // delegate for time label and date label
        public void Lableupdate()
        {
            if (lblTime.InvokeRequired)
            {
                TimeDel cc = new TimeDel(Lableupdate);
                this.Invoke(cc);
            }
            else
            {

                lblTime.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
                lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            }
        }
        public void Timer()
        {

            while (ShowTime != false)
            {
                Lableupdate();
                Thread.Sleep(1000);
            }



        }
    }
}

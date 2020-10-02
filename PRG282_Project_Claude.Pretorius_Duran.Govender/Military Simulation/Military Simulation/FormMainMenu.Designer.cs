namespace Military_Simulation
{
    partial class FormMainMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExitMenu = new FontAwesome.Sharp.IconButton();
            this.btnSimulationMenu = new FontAwesome.Sharp.IconButton();
            this.pnlAircraftSubMenu = new System.Windows.Forms.Panel();
            this.btnAircraftViewAllSubMenu = new FontAwesome.Sharp.IconButton();
            this.btnAircraftEditSubMenu = new FontAwesome.Sharp.IconButton();
            this.btnAircraftDeleteSubMenu = new FontAwesome.Sharp.IconButton();
            this.btnAircraftAddSubMenu = new FontAwesome.Sharp.IconButton();
            this.btnAircraftMenu = new FontAwesome.Sharp.IconButton();
            this.btnDashboardMenu = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlAircraftSubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.btnExitMenu);
            this.pnlMenu.Controls.Add(this.btnSimulationMenu);
            this.pnlMenu.Controls.Add(this.pnlAircraftSubMenu);
            this.pnlMenu.Controls.Add(this.btnAircraftMenu);
            this.pnlMenu.Controls.Add(this.btnDashboardMenu);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 501);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExitMenu.FlatAppearance.BorderSize = 0;
            this.btnExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExitMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExitMenu.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExitMenu.IconColor = System.Drawing.Color.White;
            this.btnExitMenu.IconSize = 32;
            this.btnExitMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitMenu.Location = new System.Drawing.Point(0, 528);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExitMenu.Rotation = 0D;
            this.btnExitMenu.Size = new System.Drawing.Size(203, 60);
            this.btnExitMenu.TabIndex = 5;
            this.btnExitMenu.Text = "Exit";
            this.btnExitMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitMenu.UseVisualStyleBackColor = true;
            this.btnExitMenu.Click += new System.EventHandler(this.btnExitMenu_Click);
            // 
            // btnSimulationMenu
            // 
            this.btnSimulationMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSimulationMenu.FlatAppearance.BorderSize = 0;
            this.btnSimulationMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulationMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSimulationMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSimulationMenu.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnSimulationMenu.IconColor = System.Drawing.Color.White;
            this.btnSimulationMenu.IconSize = 32;
            this.btnSimulationMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulationMenu.Location = new System.Drawing.Point(0, 468);
            this.btnSimulationMenu.Name = "btnSimulationMenu";
            this.btnSimulationMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSimulationMenu.Rotation = 0D;
            this.btnSimulationMenu.Size = new System.Drawing.Size(203, 60);
            this.btnSimulationMenu.TabIndex = 4;
            this.btnSimulationMenu.Text = "Simulation";
            this.btnSimulationMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulationMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimulationMenu.UseVisualStyleBackColor = true;
            this.btnSimulationMenu.Click += new System.EventHandler(this.btnSimulationMenu_Click);
            // 
            // pnlAircraftSubMenu
            // 
            this.pnlAircraftSubMenu.Controls.Add(this.btnAircraftViewAllSubMenu);
            this.pnlAircraftSubMenu.Controls.Add(this.btnAircraftEditSubMenu);
            this.pnlAircraftSubMenu.Controls.Add(this.btnAircraftDeleteSubMenu);
            this.pnlAircraftSubMenu.Controls.Add(this.btnAircraftAddSubMenu);
            this.pnlAircraftSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAircraftSubMenu.Location = new System.Drawing.Point(0, 260);
            this.pnlAircraftSubMenu.Name = "pnlAircraftSubMenu";
            this.pnlAircraftSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlAircraftSubMenu.Size = new System.Drawing.Size(203, 208);
            this.pnlAircraftSubMenu.TabIndex = 3;
            // 
            // btnAircraftViewAllSubMenu
            // 
            this.btnAircraftViewAllSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAircraftViewAllSubMenu.FlatAppearance.BorderSize = 0;
            this.btnAircraftViewAllSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAircraftViewAllSubMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAircraftViewAllSubMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAircraftViewAllSubMenu.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnAircraftViewAllSubMenu.IconColor = System.Drawing.Color.White;
            this.btnAircraftViewAllSubMenu.IconSize = 32;
            this.btnAircraftViewAllSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftViewAllSubMenu.Location = new System.Drawing.Point(10, 150);
            this.btnAircraftViewAllSubMenu.Name = "btnAircraftViewAllSubMenu";
            this.btnAircraftViewAllSubMenu.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnAircraftViewAllSubMenu.Rotation = 0D;
            this.btnAircraftViewAllSubMenu.Size = new System.Drawing.Size(193, 50);
            this.btnAircraftViewAllSubMenu.TabIndex = 6;
            this.btnAircraftViewAllSubMenu.Text = "View All";
            this.btnAircraftViewAllSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftViewAllSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAircraftViewAllSubMenu.UseVisualStyleBackColor = true;
            this.btnAircraftViewAllSubMenu.Click += new System.EventHandler(this.btnAircraftViewAllSubMenu_Click);
            // 
            // btnAircraftEditSubMenu
            // 
            this.btnAircraftEditSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAircraftEditSubMenu.FlatAppearance.BorderSize = 0;
            this.btnAircraftEditSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAircraftEditSubMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAircraftEditSubMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAircraftEditSubMenu.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnAircraftEditSubMenu.IconColor = System.Drawing.Color.White;
            this.btnAircraftEditSubMenu.IconSize = 32;
            this.btnAircraftEditSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftEditSubMenu.Location = new System.Drawing.Point(10, 100);
            this.btnAircraftEditSubMenu.Name = "btnAircraftEditSubMenu";
            this.btnAircraftEditSubMenu.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnAircraftEditSubMenu.Rotation = 0D;
            this.btnAircraftEditSubMenu.Size = new System.Drawing.Size(193, 50);
            this.btnAircraftEditSubMenu.TabIndex = 5;
            this.btnAircraftEditSubMenu.Text = "Edit";
            this.btnAircraftEditSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftEditSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAircraftEditSubMenu.UseVisualStyleBackColor = true;
            this.btnAircraftEditSubMenu.Click += new System.EventHandler(this.btnAircraftEditSubMenu_Click);
            // 
            // btnAircraftDeleteSubMenu
            // 
            this.btnAircraftDeleteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAircraftDeleteSubMenu.FlatAppearance.BorderSize = 0;
            this.btnAircraftDeleteSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAircraftDeleteSubMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAircraftDeleteSubMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAircraftDeleteSubMenu.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnAircraftDeleteSubMenu.IconColor = System.Drawing.Color.White;
            this.btnAircraftDeleteSubMenu.IconSize = 32;
            this.btnAircraftDeleteSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftDeleteSubMenu.Location = new System.Drawing.Point(10, 50);
            this.btnAircraftDeleteSubMenu.Name = "btnAircraftDeleteSubMenu";
            this.btnAircraftDeleteSubMenu.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnAircraftDeleteSubMenu.Rotation = 0D;
            this.btnAircraftDeleteSubMenu.Size = new System.Drawing.Size(193, 50);
            this.btnAircraftDeleteSubMenu.TabIndex = 4;
            this.btnAircraftDeleteSubMenu.Text = "Delete";
            this.btnAircraftDeleteSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftDeleteSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAircraftDeleteSubMenu.UseVisualStyleBackColor = true;
            this.btnAircraftDeleteSubMenu.Click += new System.EventHandler(this.btnAircraftDeleteSubMenu_Click);
            // 
            // btnAircraftAddSubMenu
            // 
            this.btnAircraftAddSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAircraftAddSubMenu.FlatAppearance.BorderSize = 0;
            this.btnAircraftAddSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAircraftAddSubMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAircraftAddSubMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAircraftAddSubMenu.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAircraftAddSubMenu.IconColor = System.Drawing.Color.White;
            this.btnAircraftAddSubMenu.IconSize = 32;
            this.btnAircraftAddSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftAddSubMenu.Location = new System.Drawing.Point(10, 0);
            this.btnAircraftAddSubMenu.Name = "btnAircraftAddSubMenu";
            this.btnAircraftAddSubMenu.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnAircraftAddSubMenu.Rotation = 0D;
            this.btnAircraftAddSubMenu.Size = new System.Drawing.Size(193, 50);
            this.btnAircraftAddSubMenu.TabIndex = 3;
            this.btnAircraftAddSubMenu.Text = "Add";
            this.btnAircraftAddSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftAddSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAircraftAddSubMenu.UseVisualStyleBackColor = true;
            this.btnAircraftAddSubMenu.Click += new System.EventHandler(this.btnAircraftAddSubMenu_Click);
            // 
            // btnAircraftMenu
            // 
            this.btnAircraftMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAircraftMenu.FlatAppearance.BorderSize = 0;
            this.btnAircraftMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAircraftMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAircraftMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAircraftMenu.IconChar = FontAwesome.Sharp.IconChar.FighterJet;
            this.btnAircraftMenu.IconColor = System.Drawing.Color.White;
            this.btnAircraftMenu.IconSize = 32;
            this.btnAircraftMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftMenu.Location = new System.Drawing.Point(0, 200);
            this.btnAircraftMenu.Name = "btnAircraftMenu";
            this.btnAircraftMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAircraftMenu.Rotation = 0D;
            this.btnAircraftMenu.Size = new System.Drawing.Size(203, 60);
            this.btnAircraftMenu.TabIndex = 2;
            this.btnAircraftMenu.Text = "Aircraft";
            this.btnAircraftMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAircraftMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAircraftMenu.UseVisualStyleBackColor = true;
            this.btnAircraftMenu.Click += new System.EventHandler(this.btnAircraftMenu_Click);
            // 
            // btnDashboardMenu
            // 
            this.btnDashboardMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboardMenu.FlatAppearance.BorderSize = 0;
            this.btnDashboardMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboardMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboardMenu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnDashboardMenu.IconColor = System.Drawing.Color.White;
            this.btnDashboardMenu.IconSize = 32;
            this.btnDashboardMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardMenu.Location = new System.Drawing.Point(0, 140);
            this.btnDashboardMenu.Name = "btnDashboardMenu";
            this.btnDashboardMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboardMenu.Rotation = 0D;
            this.btnDashboardMenu.Size = new System.Drawing.Size(203, 60);
            this.btnDashboardMenu.TabIndex = 1;
            this.btnDashboardMenu.Text = "Dashboard";
            this.btnDashboardMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboardMenu.UseVisualStyleBackColor = true;
            this.btnDashboardMenu.Click += new System.EventHandler(this.btnDashboardMenu_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(203, 140);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Military_Simulation.Properties.Resources.MilitaryLogo;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(3, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(214, 81);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnRestore);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.lblTitleChildForm);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(560, 75);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconSize = 18;
            this.btnMinimize.Location = new System.Drawing.Point(485, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 5, 8);
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(20, 21);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRestore.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestore.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRestore.IconSize = 18;
            this.btnRestore.Location = new System.Drawing.Point(511, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRestore.Rotation = 0D;
            this.btnRestore.Size = new System.Drawing.Size(20, 21);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 18;
            this.btnExit.Location = new System.Drawing.Point(537, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(20, 21);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(45, 39);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 29);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(220, 75);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(560, 8);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDesktop.Controls.Add(this.lblDate);
            this.pnlDesktop.Controls.Add(this.lblTime);
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 83);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(560, 418);
            this.pnlDesktop.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblDate.Location = new System.Drawing.Point(206, 277);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Current Date";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(219, 246);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(172, 31);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Current Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Military_Simulation.Properties.Resources.MilitaryLogoHome;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(195, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 501);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlAircraftSubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnDashboardMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnExitMenu;
        private FontAwesome.Sharp.IconButton btnSimulationMenu;
        private System.Windows.Forms.Panel pnlAircraftSubMenu;
        private FontAwesome.Sharp.IconButton btnAircraftViewAllSubMenu;
        private FontAwesome.Sharp.IconButton btnAircraftEditSubMenu;
        private FontAwesome.Sharp.IconButton btnAircraftDeleteSubMenu;
        private FontAwesome.Sharp.IconButton btnAircraftAddSubMenu;
        private FontAwesome.Sharp.IconButton btnAircraftMenu;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel pnlTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Panel pnlDesktop;
    }
}


namespace Military_Simulation
{
    partial class FormPlaneSelect
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
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAmmoType = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAmmoType = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPlaneInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacture = new System.Windows.Forms.TextBox();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.txtAircraftID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSelectPlane = new System.Windows.Forms.DataGridView();
            this.pnlDelete.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlShadow.Location = new System.Drawing.Point(526, 0);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(8, 354);
            this.pnlShadow.TabIndex = 6;
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnStart);
            this.pnlDelete.Controls.Add(this.txtAmmoType);
            this.pnlDelete.Controls.Add(this.txtManufacturer);
            this.pnlDelete.Controls.Add(this.txtType);
            this.pnlDelete.Controls.Add(this.txtModelName);
            this.pnlDelete.Controls.Add(this.txtID);
            this.pnlDelete.Controls.Add(this.lblAmmoType);
            this.pnlDelete.Controls.Add(this.lblManufacturer);
            this.pnlDelete.Controls.Add(this.lblType);
            this.pnlDelete.Controls.Add(this.lblModelName);
            this.pnlDelete.Controls.Add(this.lblID);
            this.pnlDelete.Controls.Add(this.lblPlaneInfo);
            this.pnlDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDelete.Location = new System.Drawing.Point(534, 0);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(142, 354);
            this.pnlDelete.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 298);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAmmoType
            // 
            this.txtAmmoType.Location = new System.Drawing.Point(9, 248);
            this.txtAmmoType.Name = "txtAmmoType";
            this.txtAmmoType.ReadOnly = true;
            this.txtAmmoType.Size = new System.Drawing.Size(100, 20);
            this.txtAmmoType.TabIndex = 10;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(9, 200);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 9;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(9, 150);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 8;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(9, 101);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.ReadOnly = true;
            this.txtModelName.Size = new System.Drawing.Size(100, 20);
            this.txtModelName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(9, 54);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblAmmoType
            // 
            this.lblAmmoType.AutoSize = true;
            this.lblAmmoType.Location = new System.Drawing.Point(6, 232);
            this.lblAmmoType.Name = "lblAmmoType";
            this.lblAmmoType.Size = new System.Drawing.Size(88, 13);
            this.lblAmmoType.TabIndex = 5;
            this.lblAmmoType.Text = "Ammunition Type";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(6, 184);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 4;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 134);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(6, 85);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(67, 13);
            this.lblModelName.TabIndex = 2;
            this.lblModelName.Text = "Model Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblPlaneInfo
            // 
            this.lblPlaneInfo.AutoSize = true;
            this.lblPlaneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneInfo.Location = new System.Drawing.Point(6, 14);
            this.lblPlaneInfo.Name = "lblPlaneInfo";
            this.lblPlaneInfo.Size = new System.Drawing.Size(128, 16);
            this.lblPlaneInfo.TabIndex = 0;
            this.lblPlaneInfo.Text = "Plane Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 8);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtManufacture);
            this.panel2.Controls.Add(this.txtTyp);
            this.panel2.Controls.Add(this.txtModName);
            this.panel2.Controls.Add(this.txtAircraftID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 76);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Model Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID";
            // 
            // txtManufacture
            // 
            this.txtManufacture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManufacture.Location = new System.Drawing.Point(408, 53);
            this.txtManufacture.Name = "txtManufacture";
            this.txtManufacture.Size = new System.Drawing.Size(100, 20);
            this.txtManufacture.TabIndex = 14;
            // 
            // txtTyp
            // 
            this.txtTyp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTyp.Location = new System.Drawing.Point(276, 53);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(100, 20);
            this.txtTyp.TabIndex = 13;
            // 
            // txtModName
            // 
            this.txtModName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModName.Location = new System.Drawing.Point(137, 53);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(100, 20);
            this.txtModName.TabIndex = 12;
            // 
            // txtAircraftID
            // 
            this.txtAircraftID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAircraftID.Location = new System.Drawing.Point(10, 53);
            this.txtAircraftID.Name = "txtAircraftID";
            this.txtAircraftID.Size = new System.Drawing.Size(100, 20);
            this.txtAircraftID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search";
            // 
            // dgvSelectPlane
            // 
            this.dgvSelectPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectPlane.Location = new System.Drawing.Point(0, 84);
            this.dgvSelectPlane.Name = "dgvSelectPlane";
            this.dgvSelectPlane.Size = new System.Drawing.Size(526, 270);
            this.dgvSelectPlane.TabIndex = 9;
            this.dgvSelectPlane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectPlane_CellClick);
            // 
            // FormPlaneSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 354);
            this.Controls.Add(this.dgvSelectPlane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlDelete);
            this.Name = "FormPlaneSelect";
            this.Text = "FormPlaneSelect";
            this.Load += new System.EventHandler(this.FormPlaneSelect_Load);
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAmmoType;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAmmoType;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPlaneInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManufacture;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.TextBox txtAircraftID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSelectPlane;
    }
}
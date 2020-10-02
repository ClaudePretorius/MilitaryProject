namespace Military_Simulation
{
    partial class FormViewAllAircraft
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtAircraftID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.dgvViewAllAircraft = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lblManufacturer);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblModelName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtManufacturer);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtModelName);
            this.panel1.Controls.Add(this.txtAircraftID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 76);
            this.panel1.TabIndex = 1;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(431, 37);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 18;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(320, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type";
            // 
            // lblModelName
            // 
            this.lblModelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(164, 37);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(67, 13);
            this.lblModelName.TabIndex = 16;
            this.lblModelName.Text = "Model Name";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(56, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManufacturer.Location = new System.Drawing.Point(417, 53);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 14;
            this.txtManufacturer.TextChanged += new System.EventHandler(this.txtManufacturer_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtType.Location = new System.Drawing.Point(285, 53);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 13;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtModelName
            // 
            this.txtModelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModelName.Location = new System.Drawing.Point(146, 53);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(100, 20);
            this.txtModelName.TabIndex = 12;
            this.txtModelName.TextChanged += new System.EventHandler(this.txtModelName_TextChanged);
            // 
            // txtAircraftID
            // 
            this.txtAircraftID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAircraftID.Location = new System.Drawing.Point(19, 53);
            this.txtAircraftID.Name = "txtAircraftID";
            this.txtAircraftID.Size = new System.Drawing.Size(100, 20);
            this.txtAircraftID.TabIndex = 11;
            this.txtAircraftID.TextChanged += new System.EventHandler(this.txtAircraftID_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search";
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(0, 76);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(544, 8);
            this.pnlShadow.TabIndex = 3;
            // 
            // dgvViewAllAircraft
            // 
            this.dgvViewAllAircraft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewAllAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewAllAircraft.Location = new System.Drawing.Point(0, 84);
            this.dgvViewAllAircraft.Name = "dgvViewAllAircraft";
            this.dgvViewAllAircraft.Size = new System.Drawing.Size(544, 295);
            this.dgvViewAllAircraft.TabIndex = 4;
            // 
            // FormViewAllAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.dgvViewAllAircraft);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewAllAircraft";
            this.Text = "FormViewAllAircraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewAllAircraft_FormClosing);
            this.Load += new System.EventHandler(this.FormViewAllAircraft_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllAircraft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtAircraftID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.DataGridView dgvViewAllAircraft;
    }
}
namespace Military_Simulation
{
    partial class FormEditAircraft
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
            this.dgvUpdateAircraft = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.NumUpDownDamage = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownAmmoAmount = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownFuelCapacity = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownHealth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFuelConsumption = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmmoType = new System.Windows.Forms.TextBox();
            this.txtDistancePerTank = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.grpBxAircraftUpdateInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAmmoAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownFuelCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownHealth)).BeginInit();
            this.grpBxAircraftUpdateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUpdateAircraft
            // 
            this.dgvUpdateAircraft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUpdateAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUpdateAircraft.Location = new System.Drawing.Point(0, 321);
            this.dgvUpdateAircraft.Name = "dgvUpdateAircraft";
            this.dgvUpdateAircraft.Size = new System.Drawing.Size(800, 129);
            this.dgvUpdateAircraft.TabIndex = 8;
            this.dgvUpdateAircraft.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateAircraft_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(326, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 24);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // NumUpDownDamage
            // 
            this.NumUpDownDamage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumUpDownDamage.Location = new System.Drawing.Point(557, 241);
            this.NumUpDownDamage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumUpDownDamage.Name = "NumUpDownDamage";
            this.NumUpDownDamage.Size = new System.Drawing.Size(164, 20);
            this.NumUpDownDamage.TabIndex = 28;
            // 
            // NumUpDownSpeed
            // 
            this.NumUpDownSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumUpDownSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.NumUpDownSpeed.Location = new System.Drawing.Point(557, 115);
            this.NumUpDownSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDownSpeed.Name = "NumUpDownSpeed";
            this.NumUpDownSpeed.Size = new System.Drawing.Size(164, 20);
            this.NumUpDownSpeed.TabIndex = 27;
            // 
            // NumUpDownAmmoAmount
            // 
            this.NumUpDownAmmoAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumUpDownAmmoAmount.Location = new System.Drawing.Point(557, 200);
            this.NumUpDownAmmoAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumUpDownAmmoAmount.Name = "NumUpDownAmmoAmount";
            this.NumUpDownAmmoAmount.Size = new System.Drawing.Size(164, 20);
            this.NumUpDownAmmoAmount.TabIndex = 26;
            // 
            // NumUpDownFuelCapacity
            // 
            this.NumUpDownFuelCapacity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumUpDownFuelCapacity.Location = new System.Drawing.Point(121, 241);
            this.NumUpDownFuelCapacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumUpDownFuelCapacity.Name = "NumUpDownFuelCapacity";
            this.NumUpDownFuelCapacity.Size = new System.Drawing.Size(164, 20);
            this.NumUpDownFuelCapacity.TabIndex = 25;
            // 
            // NumUpDownHealth
            // 
            this.NumUpDownHealth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumUpDownHealth.Location = new System.Drawing.Point(121, 200);
            this.NumUpDownHealth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumUpDownHealth.Name = "NumUpDownHealth";
            this.NumUpDownHealth.Size = new System.Drawing.Size(164, 20);
            this.NumUpDownHealth.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Damage (Per Ammo type)";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fuel Consumption (L/Km)";
            // 
            // txtFuelConsumption
            // 
            this.txtFuelConsumption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFuelConsumption.Location = new System.Drawing.Point(557, 32);
            this.txtFuelConsumption.Name = "txtFuelConsumption";
            this.txtFuelConsumption.Size = new System.Drawing.Size(164, 20);
            this.txtFuelConsumption.TabIndex = 20;
            this.txtFuelConsumption.TextChanged += new System.EventHandler(this.txtFuelConsumption_TextChanged);
            this.txtFuelConsumption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuelConsumption_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ammunition Amount";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ammunition Type";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Speed (Km/h)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Distance Per Tank (Km)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fuel Capacity (L)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Health";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Model Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aircraft ID";
            // 
            // txtAmmoType
            // 
            this.txtAmmoType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmmoType.Location = new System.Drawing.Point(557, 156);
            this.txtAmmoType.Name = "txtAmmoType";
            this.txtAmmoType.Size = new System.Drawing.Size(164, 20);
            this.txtAmmoType.TabIndex = 8;
            // 
            // txtDistancePerTank
            // 
            this.txtDistancePerTank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDistancePerTank.BackColor = System.Drawing.SystemColors.Window;
            this.txtDistancePerTank.Location = new System.Drawing.Point(557, 76);
            this.txtDistancePerTank.Name = "txtDistancePerTank";
            this.txtDistancePerTank.Size = new System.Drawing.Size(164, 20);
            this.txtDistancePerTank.TabIndex = 6;
            this.txtDistancePerTank.TextChanged += new System.EventHandler(this.txtDistancePerTank_TextChanged);
            this.txtDistancePerTank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancePerTank_KeyPress);
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManufacturer.Location = new System.Drawing.Point(121, 156);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(164, 20);
            this.txtManufacturer.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtType.Location = new System.Drawing.Point(121, 114);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(164, 20);
            this.txtType.TabIndex = 2;
            // 
            // txtModelName
            // 
            this.txtModelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModelName.Location = new System.Drawing.Point(121, 72);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(164, 20);
            this.txtModelName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(121, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(164, 13);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "Auto Generate";
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(0, 313);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(800, 8);
            this.pnlShadow.TabIndex = 7;
            // 
            // grpBxAircraftUpdateInfo
            // 
            this.grpBxAircraftUpdateInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBxAircraftUpdateInfo.Controls.Add(this.btnUpdate);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.NumUpDownDamage);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.NumUpDownSpeed);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.NumUpDownAmmoAmount);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.NumUpDownFuelCapacity);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.NumUpDownHealth);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label12);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label11);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.txtFuelConsumption);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label10);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label9);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label8);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label7);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label6);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label5);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label4);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label3);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label2);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.label1);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.txtAmmoType);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.txtDistancePerTank);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.txtManufacturer);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.txtType);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.txtModelName);
            this.grpBxAircraftUpdateInfo.Controls.Add(this.txtID);
            this.grpBxAircraftUpdateInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxAircraftUpdateInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpBxAircraftUpdateInfo.Location = new System.Drawing.Point(0, 0);
            this.grpBxAircraftUpdateInfo.Name = "grpBxAircraftUpdateInfo";
            this.grpBxAircraftUpdateInfo.Size = new System.Drawing.Size(800, 313);
            this.grpBxAircraftUpdateInfo.TabIndex = 6;
            this.grpBxAircraftUpdateInfo.TabStop = false;
            this.grpBxAircraftUpdateInfo.Text = "Aircraft Info";
            // 
            // FormEditAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUpdateAircraft);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.grpBxAircraftUpdateInfo);
            this.Name = "FormEditAircraft";
            this.Text = "FormEditAircraft";
            this.Load += new System.EventHandler(this.FormEditAircraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAmmoAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownFuelCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownHealth)).EndInit();
            this.grpBxAircraftUpdateInfo.ResumeLayout(false);
            this.grpBxAircraftUpdateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateAircraft;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown NumUpDownDamage;
        private System.Windows.Forms.NumericUpDown NumUpDownSpeed;
        private System.Windows.Forms.NumericUpDown NumUpDownAmmoAmount;
        private System.Windows.Forms.NumericUpDown NumUpDownFuelCapacity;
        private System.Windows.Forms.NumericUpDown NumUpDownHealth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFuelConsumption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmmoType;
        private System.Windows.Forms.TextBox txtDistancePerTank;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.GroupBox grpBxAircraftUpdateInfo;
    }
}
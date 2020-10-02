namespace Military_Simulation
{
    partial class FormSimulation
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnUpdateNeighbours = new System.Windows.Forms.Button();
            this.btnViewImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.lblprogressBarDamageDone = new System.Windows.Forms.Label();
            this.lblprogressBarDamageTaken = new System.Windows.Forms.Label();
            this.lblprogressBarFuelLeft = new System.Windows.Forms.Label();
            this.progressBarDamageDone = new System.Windows.Forms.ProgressBar();
            this.progressBarDamageTaken = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarFuelLeft = new System.Windows.Forms.ProgressBar();
            this.circularProgressBarSuccessRate = new CircularProgressBar.CircularProgressBar();
            this.pnlpic = new System.Windows.Forms.Panel();
            this.pnlDelete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlShadow.Location = new System.Drawing.Point(605, 0);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(8, 539);
            this.pnlShadow.TabIndex = 6;
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlDelete.Controls.Add(this.label4);
            this.pnlDelete.Controls.Add(this.lblInstructions);
            this.pnlDelete.Controls.Add(this.label2);
            this.pnlDelete.Controls.Add(this.btnReset);
            this.pnlDelete.Controls.Add(this.btnRun);
            this.pnlDelete.Controls.Add(this.btnUpdateNeighbours);
            this.pnlDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDelete.Location = new System.Drawing.Point(613, 0);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(173, 539);
            this.pnlDelete.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(57, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Instructions:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInstructions.Location = new System.Drawing.Point(6, 237);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(61, 13);
            this.lblInstructions.TabIndex = 20;
            this.lblInstructions.Text = "Instructions";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(56, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Controls";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(23, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(23, 114);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(121, 23);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnUpdateNeighbours
            // 
            this.btnUpdateNeighbours.Location = new System.Drawing.Point(23, 61);
            this.btnUpdateNeighbours.Name = "btnUpdateNeighbours";
            this.btnUpdateNeighbours.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateNeighbours.TabIndex = 11;
            this.btnUpdateNeighbours.Text = "Update Neighbours";
            this.btnUpdateNeighbours.UseVisualStyleBackColor = true;
            this.btnUpdateNeighbours.Click += new System.EventHandler(this.btnUpdateNeighbours_Click);
            // 
            // btnViewImage
            // 
            this.btnViewImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewImage.Location = new System.Drawing.Point(387, 35);
            this.btnViewImage.Name = "btnViewImage";
            this.btnViewImage.Size = new System.Drawing.Size(121, 23);
            this.btnViewImage.TabIndex = 14;
            this.btnViewImage.Text = "View Image";
            this.btnViewImage.UseVisualStyleBackColor = true;
            this.btnViewImage.Click += new System.EventHandler(this.btnViewImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnBrowse);
            this.panel1.Controls.Add(this.btnViewImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 61);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(329, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Toggle between picture view && simulation view";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(57, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Import image from your computer:";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBrowse.Location = new System.Drawing.Point(77, 35);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(121, 23);
            this.BtnBrowse.TabIndex = 16;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 8);
            this.panel2.TabIndex = 8;
            // 
            // pnlReport
            // 
            this.pnlReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlReport.Controls.Add(this.lblprogressBarDamageDone);
            this.pnlReport.Controls.Add(this.lblprogressBarDamageTaken);
            this.pnlReport.Controls.Add(this.lblprogressBarFuelLeft);
            this.pnlReport.Controls.Add(this.progressBarDamageDone);
            this.pnlReport.Controls.Add(this.progressBarDamageTaken);
            this.pnlReport.Controls.Add(this.label8);
            this.pnlReport.Controls.Add(this.label7);
            this.pnlReport.Controls.Add(this.label6);
            this.pnlReport.Controls.Add(this.label5);
            this.pnlReport.Controls.Add(this.progressBarFuelLeft);
            this.pnlReport.Controls.Add(this.circularProgressBarSuccessRate);
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReport.Location = new System.Drawing.Point(0, 422);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(605, 117);
            this.pnlReport.TabIndex = 19;
            // 
            // lblprogressBarDamageDone
            // 
            this.lblprogressBarDamageDone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprogressBarDamageDone.AutoSize = true;
            this.lblprogressBarDamageDone.ForeColor = System.Drawing.Color.Black;
            this.lblprogressBarDamageDone.Location = new System.Drawing.Point(443, 69);
            this.lblprogressBarDamageDone.Name = "lblprogressBarDamageDone";
            this.lblprogressBarDamageDone.Size = new System.Drawing.Size(55, 13);
            this.lblprogressBarDamageDone.TabIndex = 30;
            this.lblprogressBarDamageDone.Text = "DmgDone";
            // 
            // lblprogressBarDamageTaken
            // 
            this.lblprogressBarDamageTaken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprogressBarDamageTaken.AutoSize = true;
            this.lblprogressBarDamageTaken.ForeColor = System.Drawing.Color.Black;
            this.lblprogressBarDamageTaken.Location = new System.Drawing.Point(315, 69);
            this.lblprogressBarDamageTaken.Name = "lblprogressBarDamageTaken";
            this.lblprogressBarDamageTaken.Size = new System.Drawing.Size(54, 13);
            this.lblprogressBarDamageTaken.TabIndex = 29;
            this.lblprogressBarDamageTaken.Text = "DmgTake";
            // 
            // lblprogressBarFuelLeft
            // 
            this.lblprogressBarFuelLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprogressBarFuelLeft.AutoSize = true;
            this.lblprogressBarFuelLeft.ForeColor = System.Drawing.Color.Black;
            this.lblprogressBarFuelLeft.Location = new System.Drawing.Point(180, 69);
            this.lblprogressBarFuelLeft.Name = "lblprogressBarFuelLeft";
            this.lblprogressBarFuelLeft.Size = new System.Drawing.Size(47, 13);
            this.lblprogressBarFuelLeft.TabIndex = 28;
            this.lblprogressBarFuelLeft.Text = "Fuel left:";
            // 
            // progressBarDamageDone
            // 
            this.progressBarDamageDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarDamageDone.Location = new System.Drawing.Point(418, 43);
            this.progressBarDamageDone.Name = "progressBarDamageDone";
            this.progressBarDamageDone.Size = new System.Drawing.Size(100, 23);
            this.progressBarDamageDone.TabIndex = 27;
            // 
            // progressBarDamageTaken
            // 
            this.progressBarDamageTaken.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarDamageTaken.Location = new System.Drawing.Point(294, 43);
            this.progressBarDamageTaken.Name = "progressBarDamageTaken";
            this.progressBarDamageTaken.Size = new System.Drawing.Size(100, 23);
            this.progressBarDamageTaken.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(431, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Damage done:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(304, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Damage taken:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(190, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fuel left:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Success Rate:";
            // 
            // progressBarFuelLeft
            // 
            this.progressBarFuelLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarFuelLeft.Location = new System.Drawing.Point(161, 43);
            this.progressBarFuelLeft.Name = "progressBarFuelLeft";
            this.progressBarFuelLeft.Size = new System.Drawing.Size(100, 23);
            this.progressBarFuelLeft.TabIndex = 1;
            // 
            // circularProgressBarSuccessRate
            // 
            this.circularProgressBarSuccessRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.circularProgressBarSuccessRate.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarSuccessRate.AnimationSpeed = 500;
            this.circularProgressBarSuccessRate.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarSuccessRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarSuccessRate.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBarSuccessRate.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circularProgressBarSuccessRate.InnerMargin = 2;
            this.circularProgressBarSuccessRate.InnerWidth = -1;
            this.circularProgressBarSuccessRate.Location = new System.Drawing.Point(43, 30);
            this.circularProgressBarSuccessRate.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarSuccessRate.Name = "circularProgressBarSuccessRate";
            this.circularProgressBarSuccessRate.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarSuccessRate.OuterMargin = -2;
            this.circularProgressBarSuccessRate.OuterWidth = -10;
            this.circularProgressBarSuccessRate.ProgressColor = System.Drawing.Color.MediumBlue;
            this.circularProgressBarSuccessRate.ProgressWidth = 8;
            this.circularProgressBarSuccessRate.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarSuccessRate.Size = new System.Drawing.Size(101, 84);
            this.circularProgressBarSuccessRate.StartAngle = 270;
            this.circularProgressBarSuccessRate.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarSuccessRate.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarSuccessRate.SubscriptText = "";
            this.circularProgressBarSuccessRate.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarSuccessRate.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarSuccessRate.SuperscriptText = "";
            this.circularProgressBarSuccessRate.TabIndex = 0;
            this.circularProgressBarSuccessRate.TextMargin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.circularProgressBarSuccessRate.Value = 68;
            // 
            // pnlpic
            // 
            this.pnlpic.BackColor = System.Drawing.Color.Transparent;
            this.pnlpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlpic.Location = new System.Drawing.Point(0, 69);
            this.pnlpic.Name = "pnlpic";
            this.pnlpic.Size = new System.Drawing.Size(605, 353);
            this.pnlpic.TabIndex = 20;
            // 
            // FormSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 539);
            this.Controls.Add(this.pnlpic);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlDelete);
            this.Name = "FormSimulation";
            this.Text = "FormSimulation";
            this.Load += new System.EventHandler(this.FormSimulation_Load);
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnUpdateNeighbours;
        private System.Windows.Forms.Button btnViewImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlReport;
        private CircularProgressBar.CircularProgressBar circularProgressBarSuccessRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarFuelLeft;
        private System.Windows.Forms.ProgressBar progressBarDamageDone;
        private System.Windows.Forms.ProgressBar progressBarDamageTaken;
        private System.Windows.Forms.Label lblprogressBarDamageDone;
        private System.Windows.Forms.Label lblprogressBarDamageTaken;
        private System.Windows.Forms.Label lblprogressBarFuelLeft;
        private System.Windows.Forms.Panel pnlpic;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Simulation
{
    public partial class FormSimulation : Form
    {
        string imagepath;

        public int NumOfRows = 50;
        public int NumOfCols = 50;
        public Grid nodeGrid;
        public FormSimulation()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {
            pnlpic.Visible = false;
            circularProgressBarSuccessRate.Visible = false;
            progressBarFuelLeft.Visible = false;
            progressBarDamageDone.Visible = false;
            progressBarDamageTaken.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            lblprogressBarFuelLeft.Visible = false;
            lblprogressBarDamageDone.Visible = false;
            lblprogressBarDamageTaken.Visible = false;


            MessageBox.Show("Please wait a while for grid to draw");
            btnViewImage.Enabled = false;
            lblInstructions.Text =  "1.Left click = start position" +
                                    Environment.NewLine + "2.Right click = end position" + Environment.NewLine +
                                    "3.Left click hold = obstacles" + Environment.NewLine + "4.Click Update Neighbours button" +
                                    Environment.NewLine + "5.Click Run" + Environment.NewLine +
                                    Environment.NewLine + "Hide image to enable clicking";

            nodeGrid = new Grid(this.Height, this.Width, this.NumOfRows, this.NumOfCols);
            int titleBarHeight = SystemInformation.CaptionHeight;
            this.Height = this.Height-69 + titleBarHeight;
            this.Width = this.Width-181 + 150;

            nodeGrid.make_grid();

            for (int i = 0; i < this.NumOfCols; i++)
            {
                for (int j = 0; j < this.NumOfRows; j++)
                {
                    Controls.Add(nodeGrid.grid[i, j]);
                }
            }
            

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {

            // path for getting picture in dictory
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            imagepath = ofd.FileName;
            if (!string.IsNullOrEmpty(imagepath))
            {
                Bitmap OriginalImage = new Bitmap(imagepath);

                Bitmap BlackandwhiteImage = new Bitmap(OriginalImage.Width, OriginalImage.Height);

                Graphics sg = Graphics.FromImage(BlackandwhiteImage);
                //chages image to black and white
                Color c = Color.Black;
                Color v = Color.Black;

                int av = 0;

                for (int i = 0; i < OriginalImage.Width; i++)
                {
                    for (int y = 0; y < OriginalImage.Height; y++)
                    {
                        c = OriginalImage.GetPixel(i, y);
                        av = (c.R + c.B + c.G) / 3;
                        v = Color.FromArgb(c.A, av, av, av);
                        BlackandwhiteImage.SetPixel(i, y, v);
                    }
                }

                for (int x = 0; x < BlackandwhiteImage.Width; x++)
                {
                    for (int y = 0; y < BlackandwhiteImage.Height; y++)
                    {
                        Color color = BlackandwhiteImage.GetPixel(x, y);
                        BlackandwhiteImage.SetPixel(x, y, Color.FromArgb(50, color.R, color.G, color.B));
                    }
                }
                pnlpic.Visible = true;
                pnlpic.BackgroundImage = BlackandwhiteImage;
                btnViewImage.Enabled = true;
                btnViewImage.Text = "Hide Image";
            }
            else
            {
                MessageBox.Show("No image uploaded.");
                pnlpic.Visible = false;
            }
        }

        private void btnViewImage_Click(object sender, EventArgs e)
        {
            if (btnViewImage.Text == "View Image")
            {
                pnlpic.Visible = true;
                pnlpic.Show();
                btnViewImage.Text = "Hide Image";
            }
            else
            {
                pnlpic.Visible = false;
                pnlpic.Hide();
                btnViewImage.Text = "View Image";
            }
            
        }

        private void btnUpdateNeighbours_Click(object sender, EventArgs e)
        {
            nodeGrid.update_neighbors();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           
            nodeGrid.astar();
            results();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormMainMenu.form1.OpenChildForm(new FormPlaneSelect());
        }
        private void results()
        {
            circularProgressBarSuccessRate.Visible = true;
            progressBarFuelLeft.Visible = true;
            progressBarDamageDone.Visible = true;
            progressBarDamageTaken.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            lblprogressBarFuelLeft.Visible = true;
            lblprogressBarDamageDone.Visible = true;
            lblprogressBarDamageTaken.Visible = true;

            circularProgressBarSuccessRate.Value = 55;
            circularProgressBarSuccessRate.Text = "55%";

            progressBarFuelLeft.Value = 18;
            lblprogressBarFuelLeft.Text = "";

            progressBarDamageDone.Value = 76;
            lblprogressBarDamageDone.Text = "2500";

            progressBarDamageTaken.Value = 68;
            lblprogressBarDamageTaken.Text = "3900";
        }
    }
}

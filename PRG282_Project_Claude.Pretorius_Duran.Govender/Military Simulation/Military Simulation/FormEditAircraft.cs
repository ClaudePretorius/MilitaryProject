using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Military_Simulation
{
    public partial class FormEditAircraft : Form
    {
        public FormEditAircraft()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
        }

        string Aircraft_ID;
        static string Path = $"Data Source =.; Initial Catalog = MilitarySimulatorDB; Integrated Security = SSPI";
        string Q = string.Format(@"SELECT * FROM Aircraft");

        private void FormEditAircraft_Load(object sender, EventArgs e)
        {
            foreach (Control x in grpBxAircraftUpdateInfo.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Enabled = false;
                }
                if (x is NumericUpDown)
                {
                    ((NumericUpDown)x).Enabled = false;
                }
                if (x is Button)
                {
                    ((Button)x).Enabled = false;
                }
            }

            SqlConnection Conn = new SqlConnection(Path);
            SqlDataAdapter reader = new SqlDataAdapter(Q, Conn);
            DataTable table = new DataTable();


            reader.Fill(table);
            dgvUpdateAircraft.DataSource = table;
            Conn.Close();

            MessageBox.Show("Click on datagrid to auto generate values and enable textboxes for update");
        }

        private void dgvUpdateAircraft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvUpdateAircraft.Rows[e.RowIndex];
            if (!String.IsNullOrEmpty(row.Cells["Aircraft_ID"].Value.ToString()))
            {
                foreach (Control x in grpBxAircraftUpdateInfo.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Enabled = true;
                    }
                    if (x is NumericUpDown)
                    {
                        ((NumericUpDown)x).Enabled = true;
                    }
                    if (x is Button)
                    {
                        ((Button)x).Enabled = true;
                    }
                }
                /////////////////////////////////////////////////////////////////////
                if (e.RowIndex >= 0)
                {
                    Aircraft_ID = row.Cells["Aircraft_ID"].Value.ToString(); 
                    txtID.Text = row.Cells["Aircraft_ID"].Value.ToString();
                    txtModelName.Text = row.Cells["Model_Name"].Value.ToString();
                    txtType.Text = row.Cells["Type"].Value.ToString();
                    txtManufacturer.Text = row.Cells["Manufacturer"].Value.ToString();
                    NumUpDownHealth.Value = int.Parse(row.Cells["Health"].Value.ToString());
                    NumUpDownFuelCapacity.Value = int.Parse(row.Cells["Fuel_Capacity(L)"].Value.ToString());
                    txtFuelConsumption.Text = row.Cells["Fuel_Consumption(L/km)"].Value.ToString();
                    txtDistancePerTank.Text = row.Cells["Distance_Per_Tank(km)"].Value.ToString();
                    NumUpDownSpeed.Value = int.Parse(row.Cells["Speed(km/h)"].Value.ToString());
                    txtAmmoType.Text = row.Cells["Ammunition_Type"].Value.ToString();
                    NumUpDownAmmoAmount.Value = int.Parse(row.Cells["Ammunition_Amount"].Value.ToString());
                    NumUpDownDamage.Value = int.Parse(row.Cells["Damage(Per_Ammunition_Type)"].Value.ToString());
                }
            }
            else
            {
                //if clicked on cell with no content then nothing happens
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateModuleDetails() == false)//if all necessary information is filled in and nothing is empty/blank/left out
            {
                if ((int)NumUpDownHealth.Value != 0 &&
                    (int)NumUpDownFuelCapacity.Value != 0 &&
                    (int)NumUpDownSpeed.Value != 0 &&
                    (int)NumUpDownAmmoAmount.Value != 0 &&
                    (int)NumUpDownDamage.Value != 0
                    )
                {
                    float FuelConsumption = 0;
                    float distancePerTank = 0;
                    string ModName = txtModelName.Text;
                    string Type = txtType.Text;
                    string manufacturer = txtManufacturer.Text;
                    int Health = (int)NumUpDownHealth.Value;
                    int FuelCapacity = (int)NumUpDownFuelCapacity.Value;
                    if ((string.IsNullOrEmpty(txtFuelConsumption.Text)) || (string.IsNullOrWhiteSpace(txtFuelConsumption.Text)))
                    {
                        MessageBox.Show("Please fill in all necessary information");
                        goto b;
                    }
                    else
                    {
                        FuelConsumption = float.Parse(txtFuelConsumption.Text);
                    }

                    if ((string.IsNullOrEmpty(txtDistancePerTank.Text)) || (string.IsNullOrWhiteSpace(txtDistancePerTank.Text)))
                    {
                        MessageBox.Show("Please fill in all necessary information");
                        goto b;
                    }
                    else
                    {
                        distancePerTank = float.Parse(txtDistancePerTank.Text);
                    }


                    int Speed = (int)NumUpDownSpeed.Value;
                    string AmmoType = txtAmmoType.Text;
                    int AmmoAmount = (int)NumUpDownAmmoAmount.Value;
                    int Damage = (int)NumUpDownDamage.Value;



                    new DataHandlerDGV().Update(Aircraft_ID,ModName, Type, manufacturer, Health, FuelCapacity, FuelConsumption, distancePerTank, Speed, AmmoType, AmmoAmount, Damage);
                  
                    FormEditAircraft_Load(this, null);
                }
                else
                {

                    MessageBox.Show("Please fill in all info");
                }

            }
            else
            {
                MessageBox.Show("Please fill in all info");
            }



        //the next line refreshes the datagridview by reloading form again with proper connections

        b:

            FormEditAircraft_Load(this, null);
        }

        string PreviousTextFuelConsumption;
        private void txtFuelConsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreviousTextFuelConsumption = txtFuelConsumption.Text;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {

                e.Handled = true;



            }
            else
            {
                if ((e.KeyChar == '.') && (txtFuelConsumption.Text.Contains(".")))
                {
                    string s = txtFuelConsumption.Text;
                    txtFuelConsumption.Text = s.Substring(0, s.Length - 1);
                }

            }
        }

        private void txtFuelConsumption_TextChanged(object sender, EventArgs e)
        {
            char lastChar;
            validateModuleDetails();
            if (txtFuelConsumption.Text.Length >= 1)
            {

                lastChar = txtFuelConsumption.Text.Last();
            }
            else
            {

                goto c;
            }

            string test = txtFuelConsumption.Text.Substring(0, txtFuelConsumption.Text.Length - 1);
            if (lastChar.ToString() == "." && test.Contains("."))
            {
                txtFuelConsumption.Text = PreviousTextFuelConsumption;
            }
            else
            {

            }

            if ((txtFuelConsumption.Text.Length >= 1) && (lastChar.ToString() != "."))
            {
                double distPtank = double.Parse(txtFuelConsumption.Text);
                distPtank = Math.Floor(distPtank * 100) / 100;
                txtFuelConsumption.Text = distPtank.ToString();

            }
            if (!String.IsNullOrEmpty(txtFuelConsumption.Text) && txtFuelConsumption.Text != ".")
            {
                if (double.Parse(txtFuelConsumption.Text) >= 100)
                {
                    MessageBox.Show("Fuel consumption too high! Must be less than 100");
                    txtFuelConsumption.Text = PreviousTextFuelConsumption;
                }
            }


        c:
            txtFuelConsumption.Focus();
            txtFuelConsumption.SelectionStart = txtFuelConsumption.Text.Length;
        }


        string PreviousTextDistancePtank;
        private void txtDistancePerTank_TextChanged(object sender, EventArgs e)
        {

            char lastChar;
            validateModuleDetails();
            if (txtDistancePerTank.Text.Length >= 1)
            {

                lastChar = txtDistancePerTank.Text.Last();
            }
            else
            {

                goto c;
            }

            string test = txtDistancePerTank.Text.Substring(0, txtDistancePerTank.Text.Length - 1);
            if (lastChar.ToString() == "." && test.Contains("."))
            {
                txtDistancePerTank.Text = PreviousTextDistancePtank;
            }
            else
            {

            }

            if ((txtDistancePerTank.Text.Length >= 1) && (lastChar.ToString() != "."))
            {
                double distPtank = double.Parse(txtDistancePerTank.Text);
                distPtank = Math.Floor(distPtank * 100) / 100;
                txtDistancePerTank.Text = distPtank.ToString();

            }
        c:
            txtDistancePerTank.Focus();
            txtDistancePerTank.SelectionStart = txtDistancePerTank.Text.Length;
        }

        private void txtDistancePerTank_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreviousTextDistancePtank = txtDistancePerTank.Text;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {

                e.Handled = true;

            }
            else
            {
                if ((e.KeyChar == '.') && (txtDistancePerTank.Text.Contains(".")))
                {
                    string s = txtDistancePerTank.Text;
                    txtDistancePerTank.Text = s.Substring(0, s.Length - 1);
                }

            }
        }

        private void ClearTextBoxes() //this clears all the textboxes on call. Good for after submission button clicked
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        //The following is a method to check that all textboxes has information before being able and submit info to database
        private bool validateModuleDetails()
        {

            if (String.IsNullOrWhiteSpace(txtModelName.Text) ||
                String.IsNullOrWhiteSpace(txtType.Text) ||
                String.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                String.IsNullOrWhiteSpace(txtFuelConsumption.Text) ||
                String.IsNullOrWhiteSpace(txtAmmoType.Text)
               )
            {

                return true;

            }
            else
            {

                return false;
            }
        }

        
    }
}


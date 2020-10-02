using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Military_Simulation
{
    public partial class FormPlaneSelect : Form
    {
        internal static DataHandlerDGV dh;
        internal static FormPlaneSelect formplane;

        public string AircraftID;
        public string ModelName;
        public string Type;
        public string Manufacturer;
        public int Health;
        public int Fuelcapacity;
        public float FuelConsumption;
        public float DistancePerTank;
        public int Speed;
        public string AmmoType;
        public int AmmoAmnt;
        public int DamagePerAmmo;


        public FormPlaneSelect()
        {
            InitializeComponent();
        }
        static string Path = $"Data Source =.; Initial Catalog = MilitarySimulatorDB; Integrated Security = SSPI";
        string Q = string.Format(@"SELECT * FROM Aircraft");
        DataTable table = new DataTable();


        private void FormPlaneSelect_Load(object sender, EventArgs e)
        {
            dh = new DataHandlerDGV();
            formplane = this;
            SqlConnection Conn = new SqlConnection(Path);
            SqlDataAdapter reader = new SqlDataAdapter(Q, Conn);



            reader.Fill(table);
            dgvSelectPlane.DataSource = table;
            Conn.Close();

            btnStart.Enabled = false;
            MessageBox.Show("Select plane from datagrid to enable start simulation button");

        }



        private void dgvSelectPlane_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvSelectPlane.Rows[e.RowIndex];
            if (!String.IsNullOrEmpty(row.Cells["Aircraft_ID"].Value.ToString()))
            {
                if (e.RowIndex >= 0)
                {

                    txtID.Text = row.Cells["Aircraft_ID"].Value.ToString();
                    txtModelName.Text = row.Cells["Model_Name"].Value.ToString();
                    txtType.Text = row.Cells["Type"].Value.ToString();
                    txtManufacturer.Text = row.Cells["Manufacturer"].Value.ToString();
                    txtAmmoType.Text = row.Cells["Ammunition_Type"].Value.ToString();

                    AircraftID = row.Cells["Aircraft_ID"].Value.ToString(); 
                    ModelName = row.Cells["Model_Name"].Value.ToString(); 
                    Type = row.Cells["Type"].Value.ToString(); 
                    Manufacturer = row.Cells["Manufacturer"].Value.ToString(); 
                    Health = int.Parse(row.Cells["Health"].Value.ToString()); 
                    Fuelcapacity = int.Parse(row.Cells["Fuel_Capacity(L)"].Value.ToString()); 
                    FuelConsumption = float.Parse(row.Cells["Fuel_Consumption(L/km)"].Value.ToString()); 
                    DistancePerTank = float.Parse(row.Cells["Distance_Per_Tank(km)"].Value.ToString()); 
                    Speed = int.Parse(row.Cells["Speed(km/h)"].Value.ToString()); 
                    AmmoType = row.Cells["Ammunition_Type"].Value.ToString(); 
                    AmmoAmnt = int.Parse(row.Cells["Ammunition_Amount"].Value.ToString()); 
                    DamagePerAmmo = int.Parse(row.Cells["Damage(Per_Ammunition_Type)"].Value.ToString()); 

                }
            }
            else
            {
                //if clicked on cell with no content then nothing happens
            }
        }

        private void txtAircraftID_TextChanged(object sender, EventArgs e)
        {
            if (txtAircraftID.Text == null)
            {
                dgvSelectPlane.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Aircraft_ID, 'System.String') LIKE '%{0}%'", txtAircraftID.Text);//show records containing part of this search
                dgvSelectPlane.DataSource = dv.ToTable();
            }
        }

        private void txtModName_TextChanged(object sender, EventArgs e)
        {
            if (txtModName.Text == null)
            {
                dgvSelectPlane.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Model_Name, 'System.String') LIKE '%{0}%'", txtModName.Text);//show records containing part of this search
                dgvSelectPlane.DataSource = dv.ToTable();
            }
        }

        private void txtTyp_TextChanged(object sender, EventArgs e)
        {
            if (txtTyp.Text == null)
            {
                dgvSelectPlane.DataSource = table; // if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Type, 'System.String') LIKE '%{0}%'", txtTyp.Text);//show records containing part of this search
                dgvSelectPlane.DataSource = dv.ToTable();
            }
        }

        private void txtManufacture_TextChanged(object sender, EventArgs e)
        {
            if (txtManufacture.Text == null)
            {
                dgvSelectPlane.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Manufacturer, 'System.String') LIKE '%{0}%'", txtManufacture.Text);//show records containing part of this search
                dgvSelectPlane.DataSource = dv.ToTable();
            }
        }


        public void btnStart_Click(object sender, EventArgs e)
        {
            //FormSimulation obj = new FormSimulation();
            //obj.AircraftID = "Testing";
             FormMainMenu.form1.OpenChildForm(new FormSimulation());
        }

        private void dgvSelectPlane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvSelectPlane.Rows[e.RowIndex];
            if (!String.IsNullOrEmpty(row.Cells["Aircraft_ID"].Value.ToString()))
            {
                btnStart.Enabled=true;

                if (e.RowIndex >= 0)
                {

                    txtID.Text = row.Cells["Aircraft_ID"].Value.ToString();
                    txtModelName.Text = row.Cells["Model_Name"].Value.ToString();
                    txtType.Text = row.Cells["Type"].Value.ToString();
                    txtManufacturer.Text = row.Cells["Manufacturer"].Value.ToString();
                    txtAmmoType.Text = row.Cells["Ammunition_Type"].Value.ToString();
                }
            }
            else
            {
                btnStart.Enabled = false;
            }

        }
    }
}

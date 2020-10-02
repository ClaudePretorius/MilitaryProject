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

namespace Military_Simulation
{
    public partial class FormDeleteAircraft : Form
    {
        public FormDeleteAircraft()
        {
            InitializeComponent();
        }
        static string Path = $"Data Source =.; Initial Catalog = MilitarySimulatorDB; Integrated Security = SSPI";
        string Q = string.Format(@"SELECT * FROM Aircraft");
        DataTable table = new DataTable();


        private void FormDeleteAircraft_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Path);
            SqlDataAdapter reader = new SqlDataAdapter(Q, Conn);
           


            reader.Fill(table);
            dgvDeleteAircraft.DataSource = table;
            Conn.Close();

            
        }

    

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtID.Text))|| (string.IsNullOrWhiteSpace(txtID.Text)))
            {
                MessageBox.Show("Please select a record from datagrid to delete");
            }
            else
            {
                new DataHandlerDGV().Delete(txtID.Text);
                //the next line refreshes the datagridview by reloading form again with proper connections
                FormDeleteAircraft_Load(this,null);



            }
            
        }

        private void dgvDeleteAircraft_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDeleteAircraft.Rows[e.RowIndex];
            if (!String.IsNullOrEmpty(row.Cells["Aircraft_ID"].Value.ToString()))
            {
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
                //if clicked on cell with no content then nothing happens
            }
        }

        private void txtAircraftID_TextChanged(object sender, EventArgs e)
        {
            if (txtAircraftID.Text == null)
            {
                dgvDeleteAircraft.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Aircraft_ID, 'System.String') LIKE '%{0}%'", txtAircraftID.Text);//show records containing part of this search
                dgvDeleteAircraft.DataSource = dv.ToTable();
            }
        }

        private void txtModName_TextChanged(object sender, EventArgs e)
        {
            if (txtModelName.Text == null)
            {
                dgvDeleteAircraft.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Model_Name, 'System.String') LIKE '%{0}%'", txtModName.Text);//show records containing part of this search
                dgvDeleteAircraft.DataSource = dv.ToTable();
            }
        }

        private void txtTyp_TextChanged(object sender, EventArgs e)
        {
            if (txtType.Text == null)
            {
                dgvDeleteAircraft.DataSource = table; // if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Type, 'System.String') LIKE '%{0}%'", txtTyp.Text);//show records containing part of this search
                dgvDeleteAircraft.DataSource = dv.ToTable();
            }
        }

        private void txtManufacture_TextChanged(object sender, EventArgs e)
        {
            if (txtManufacturer.Text == null)
            {
                dgvDeleteAircraft.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Manufacturer, 'System.String') LIKE '%{0}%'", txtManufacture.Text);//show records containing part of this search
                dgvDeleteAircraft.DataSource = dv.ToTable();
            }
        }
    }
}

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
    public partial class FormViewAllAircraft : Form
    {
        public FormViewAllAircraft()
        {
            InitializeComponent();
        }
        static string Path = $"Data Source =.; Initial Catalog = MilitarySimulatorDB; Integrated Security = SSPI";//path of database
        string Q;
        SqlConnection Conn = new SqlConnection(Path);
        DataTable table = new DataTable();


        private void FormViewAllAircraft_Load(object sender, EventArgs e)
        {
            Q = string.Format(@"SELECT * FROM Aircraft");

            SqlDataAdapter reader = new SqlDataAdapter(Q, Conn);
           

            reader.Fill(table);
            dgvViewAllAircraft.DataSource = table;
            
        }

        private void FormViewAllAircraft_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conn.Close(); //closes connection on form close which was opened on form load
        }

        private void txtAircraftID_TextChanged(object sender, EventArgs e)
        {
            if (txtAircraftID.Text == null)
            {
                dgvViewAllAircraft.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Aircraft_ID, 'System.String') LIKE '%{0}%'", txtAircraftID.Text);//show records containing part of this search
                dgvViewAllAircraft.DataSource = dv.ToTable();
            }
        }

        private void txtModelName_TextChanged(object sender, EventArgs e)
        {
            if (txtModelName.Text == null)
            {
                dgvViewAllAircraft.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Model_Name, 'System.String') LIKE '%{0}%'", txtModelName.Text);//show records containing part of this search
                dgvViewAllAircraft.DataSource = dv.ToTable();
            }
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (txtType.Text == null)
            {
                dgvViewAllAircraft.DataSource = table; // if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Type, 'System.String') LIKE '%{0}%'", txtType.Text);//show records containing part of this search
                dgvViewAllAircraft.DataSource = dv.ToTable();
            }
        }

        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {
            if (txtManufacturer.Text == null)
            {
                dgvViewAllAircraft.DataSource = table;// if textbox empty show all records
            }
            else
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("convert(Manufacturer, 'System.String') LIKE '%{0}%'", txtManufacturer.Text);//show records containing part of this search
                dgvViewAllAircraft.DataSource = dv.ToTable();
            }
        }

    }
}

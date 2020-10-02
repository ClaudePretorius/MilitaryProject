using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Military_Simulation
{
    class DataHandlerDGV
    {

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

        public void GetValues(string AirID, string ModName, string Typ, string Manufactur, int health, int Fuelcap, float FuelConsump, float DistPerTank, int sped, string AmmoTyp, int AmmoAmount,int DamagePerAm)
        {
            AircraftID =AirID;
            ModelName =ModName;
            Type =Typ;
            Manufacturer =Manufactur;
            Health = health;
            Fuelcapacity = Fuelcap;
            FuelConsumption =FuelConsump;
            DistancePerTank = DistPerTank;
            Speed = sped;
            AmmoType = AmmoTyp;
            AmmoAmnt = AmmoAmount;
            DamagePerAmmo = DamagePerAm;
            MessageBox.Show(DamagePerAmmo.ToString()) ;
        }
        static string Path = $"Data Source =.; Initial Catalog = MilitarySimulatorDB; Integrated Security = SSPI";
        string Q;
        SqlConnection Conn = new SqlConnection(Path);

        public void Delete(string _ID)
        {
            try
            {
                Q = $"DELETE FROM Aircraft WHERE Aircraft_ID = '{_ID}'";
                SqlCommand Cmd = new SqlCommand(Q, Conn);

                Conn.Open();
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Database was updated");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Conn.Close();
            }
        }


        public void Insert(string ModName, string Type, string manufacturer, int Health, int FuelCapacity, float fuelConsumption, float DistancePerTank,int Speed,string AmmoType, int AmmoAmnt, int DamagePerAmmo)
        {
            try
            {
                //sql suery line to insert record into database
                Q = @"INSERT INTO Aircraft VALUES ('" + ModName + "','" + Type + "','" + manufacturer + "','" + Health + "','" + FuelCapacity + "','" + fuelConsumption + "','" + DistancePerTank + "','" + Speed + "','" + AmmoType + "','" + AmmoAmnt + "','" + DamagePerAmmo + "' )";

                SqlCommand Cmd = new SqlCommand(Q, Conn);

                Conn.Open();
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Values inserted");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Error! Try using realistic values to prevent column overflow.Use datagrid below as a guide.");

            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(string AircraftID,string ModName, string Type, string manufacturer, int Health, int FuelCapacity, float fuelConsumption, float DistancePerTank, int Speed, string AmmoType, int AmmoAmnt, int DamagePerAmmo)
        {
            try
            {
                Q = @"UPDATE Aircraft SET [Model_Name] = ('" + ModName + "'), Type = ('" + Type + "') , Manufacturer = ('" + manufacturer + "'),"+
                "Health = ('" + Health + "'), [Fuel_Capacity(L)] = ('" + FuelCapacity + "'),[Fuel_Consumption(L/km)] = ('" + fuelConsumption + "'),"+
                "[Distance_Per_Tank(km)] = ('" + DistancePerTank + "'),[Speed(km/h)] = ('" + Speed + "'),[Ammunition_Type] = ('" + AmmoType + "'),"+
                "[Ammunition_Amount] = ('" + AmmoAmnt + "'), [Damage(Per_Ammunition_Type)] = ('" + DamagePerAmmo + "' ) WHERE Aircraft_ID = ('" + AircraftID + "' )";


            SqlCommand Cmd = new SqlCommand(Q, Conn);

            Conn.Open();
            Cmd.ExecuteNonQuery();
                MessageBox.Show("Value updated");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Error! Try using realistic values to prevent column overflow.Use datagrid below as a guide.");
            }
            finally
            {
                Conn.Close();
            }

        }

      




    }
}

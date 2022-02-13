using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bus_Ticket_Management.Controller
{
    class GetSetID
    {
        static public string BusIdDatabase
        {
            get
            {
                string busId = 100.ToString();
                SqlDataReader reader = Model.DatabaseConnection.GetBusId();
                while (reader.Read())
                {
                    string ID = reader["ID"].ToString();
                    busId = reader["busIdCount"].ToString();
                }
                
                return busId;
            }
            set
            {
                string busID = value;
                busID = (int.Parse(busID) + 1).ToString();
                //MessageBox.Show(busID);
                Model.DatabaseConnection.SetBusId(busID);
            }
        }
        static public string PassengerIdDatabase
        {
            get
            {
                string passengerId = 1.ToString();
                SqlDataReader reader = Model.DatabaseConnection.GetPassengerId();
                while (reader.Read())
                {
                    string ID = reader["ID"].ToString();
                    string busId = reader["busIdCount"].ToString();
                    string empID = reader["employeeIdCount"].ToString();
                    passengerId = reader["passengerIdCount"].ToString();
                }

                return passengerId;
            }
            set
            {
                string passengerId = value;
                passengerId = (int.Parse(passengerId) + 1).ToString();
                Model.DatabaseConnection.SetPassengerId(passengerId);
            }
        }
    }
}

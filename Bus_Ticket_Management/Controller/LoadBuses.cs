using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;
using System.Data.SqlClient;
using Model;
using System.Windows.Forms;

namespace Bus_Ticket_Management.Controller
{
    class LoadBuses
    {
        public static List<Bus> GetBusList()
        {
            SqlDataReader reader = Model.DatabaseConnection.GetBusesReader();
            List<Bus> bus = new List<Bus>();
            while(reader.Read())
            {
                
                string id = reader["busID"].ToString();
                int seats = int.Parse(reader["noOfSeats"].ToString());
                string type = reader["busType"].ToString();
                DateTime time = DateTime.Parse(reader["time"].ToString());
                string driverID = reader["driverID"].ToString();
                string source = reader["source"].ToString();
                string destination = reader["destination"].ToString();
                Bus b = new Bus(id, seats, type, time, driverID, source, destination);
                bus.Add(b);
            }
            return bus;
        }

    }
}

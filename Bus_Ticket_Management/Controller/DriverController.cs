using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace Bus_Ticket_Management.Controller
{
    class DriverController
    {
        public static List<Driver> LoadDrivers()
        {
            SqlDataReader reader = Model.DatabaseConnection.GetDriverReader();
            List<Driver> driver = new List<Driver>();
            while (reader.Read())
            {

                string id = reader["ID"].ToString();
                string name = reader["name"].ToString();
                string title = reader["title"].ToString();
                int salary = int.Parse(reader["salary"].ToString());
                //string driverID = reader["driverID"].ToString();
                //string source = reader["source"].ToString();
                //string destination = reader["destination"].ToString();
                //Bus b = new Bus(id, seats, type, new DateTime(2022, 01, 30, int.Parse(time[0].ToString() + time[1].ToString()), int.Parse(time[3].ToString() + time[4].ToString()), int.Parse(time[6].ToString() + time[7].ToString())), driverID, source, destination);
                Driver d = new Driver(name, id, title, salary);
                driver.Add(d);
            }
            return driver;
        }
    }
}

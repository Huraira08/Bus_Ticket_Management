using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Model;
namespace Bus_Ticket_Management.Model
{
    class DatabaseConnection
    {
        private static string dataSource = "DESKTOP-4SE3ITK";
        public static string DataSource { get { return dataSource; } set { dataSource = value; } }
        public static SqlConnection GetConnection()
        {
            string strConnection = "Data Source = " + dataSource + "; Initial Catalog = BusManagementDatabase; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(strConnection);
            try
            {
                connection.Open();
                //MessageBox.Show("Succesfully Connected to Database");

            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
            return connection;
        }
        public static DataSet GetBusesDataSet()
        {
            string qry = "select * from bus;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, "Bus");

            }
            catch (Exception)
            {
                MessageBox.Show("Could not load buses from Database");
            }
            return ds;
        }
        public static SqlDataReader GetBusesReader()
        {
            string qry = "select * from Bus;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }
        public static SqlDataReader GetDriverReader()
        {
            string qry = "select * from Driver;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }
        public static SqlDataReader GetTicketReader()
        {
            string qry = "select * from Ticket;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }
        public static SqlDataReader GetPassengerReader()
        {
            string qry = "select * from Passenger;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }
        public static SqlDataReader GetCredentialReader()
        {
            string qry = "select * from Credential;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }

        public static void AddBus(Bus b)
        {
            string qry = "Insert into Bus Values(@busID, @noOfSeats, @busType, @time, @driverID, @source, @destination);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@busID", b.BusID);
            command.Parameters.AddWithValue("@noOfSeats", b.NoOfSeats);
            command.Parameters.AddWithValue("@busType", b.BusType);
            command.Parameters.AddWithValue("@time", b.Time.ToString("hh:mm:ss tt"));
            command.Parameters.AddWithValue("@driverID", b.Driver.EmployeeID);
            command.Parameters.AddWithValue("@source", b.BusSource);
            command.Parameters.AddWithValue("@destination", b.BusDestination);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Bus Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured. Record Not added.");
            }

        }
        public static SqlDataReader GetBusId()
        {
            string qry = "select * from IdCount;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection)
            {
                CommandType = CommandType.Text
            };
            return command.ExecuteReader();
            //string id = reader["ID"].ToString();
            //return reader["busIdCount"].ToString();
        }
        public static SqlDataReader GetPassengerId()
        {
            string qry = "select * from IdCount;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection)
            {
                CommandType = CommandType.Text
            };
            return command.ExecuteReader();
        }
        public static void SetBusId(string busIdCount)
        {
            string qry = "Update IdCount Set busIdCount = @busIdCount where ID = 1;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@busIdCount", busIdCount);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured. Record Not added.");
            }
        }
        public static void SetPassengerId(string passengerId)
        {
            string qry = "Update IdCount Set passengerIdCount = @passengerIdCount where ID = 1;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@passengerIdCount", passengerId);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured. Record Not added.");
            }
        }
        public static void DeleteBus(string busId)
        {
            string qry = "delete from Bus where busId = @busId;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@busId", busId);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Bus Deleted Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not delete Bus");
            }
        }

        public static void UpdateBus(Bus b)
        {
            string qry = "Update Bus Set busID = @busID, noOfSeats = @noOfSeats, busType = @busType, time = @time, driverID = @driverID, source = @source, destination = @destination where busID = @busID;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@busID", b.BusID);
            command.Parameters.AddWithValue("@noOfSeats", b.NoOfSeats);
            command.Parameters.AddWithValue("@busType", b.BusType);
            command.Parameters.AddWithValue("@time", b.Time.ToString("hh:mm:ss tt"));
            command.Parameters.AddWithValue("@driverID", b.Driver.EmployeeID);
            command.Parameters.AddWithValue("@source", b.BusSource);
            command.Parameters.AddWithValue("@destination", b.BusDestination);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Bus Updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured. Record Not added.");
            }
        }
        public static void AddTicket(Ticket t)
        {
            string qry = "Insert into Ticket Values(@ID, @passengerID, @source, @destination, @date, @price, @busID);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ID", t.TicketID);
            command.Parameters.AddWithValue("@passengerID", t.Passenger1.PassengerID);
            command.Parameters.AddWithValue("@source", t.Source);
            command.Parameters.AddWithValue("@destination", t.Destination);
            string date = (t.Date.Year + "-" + t.Date.Month + "-" + t.Date.Day);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@price", t.Price);
            command.Parameters.AddWithValue("@busID", t.BusID);
            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show("Ticket Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured. Ticket Not added.");
            }
        }
        public static void AddPassenger(Passenger p)
        {
            string qry = "Insert into Passenger Values(@ID, @name);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ID", p.PassengerID);
            command.Parameters.AddWithValue("@name", p.Name);
            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show("Passenger Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured. Passenger Not added.");
            }
        }
        //public static void AddSeatsBooked(string busId,int 1)
        //{
        //    string qry = "Insert into SeatsBooked Values(@ID, @name);";
        //    SqlConnection connection = GetConnection();
        //    SqlCommand command = new SqlCommand(qry, connection);
        //    command.CommandType = CommandType.Text;
        //    command.Parameters.AddWithValue("@ID", p.PassengerID);
        //    command.Parameters.AddWithValue("@name", p.Name);
        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        //MessageBox.Show("Passenger Added");
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error Occured. Passenger Not added.");
        //    }
        //}
    }
}

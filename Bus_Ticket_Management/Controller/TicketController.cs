using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Bus_Ticket_Management.Controller
{
    static class TicketController
    {
        public static List<Ticket> LoadTicket()
        {
            SqlDataReader reader = Model.DatabaseConnection.GetTicketReader();
            List<Ticket> ticket = new List<Ticket>();
            while (reader.Read())
            {

                string id = reader["ID"].ToString();
                string passengerID = reader["passengerID"].ToString();
                string source = reader["source"].ToString();
                string destination = reader["destination"].ToString();
                DateTime date = DateTime.Parse(reader["date"].ToString());
                int price = int.Parse(reader["price"].ToString());
                string busID = reader["busID"].ToString();
                //SqlDataReader passengerReader = Model.DatabaseConnection.GetPassengerReader();
                Passenger pas = new Passenger("");
                //while(passengerReader.Read())
                //{
                //    pas.PassengerID = passengerReader["ID"].ToString();
                //    pas.Name = passengerReader["name"].ToString();
                //    if (passengerID.ToString() == pas.PassengerID)
                //        break;
                //}
                Ticket t = new Ticket(pas, id, source, destination, date, price, busID);
                ticket.Add(t);
            }
            return ticket;
        }
    }
}

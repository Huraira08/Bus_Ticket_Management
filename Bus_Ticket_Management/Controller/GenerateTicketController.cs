using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Bus_Ticket_Management.Controller
{
    static class GenerateTicketController
    {
        public static Ticket GenerateTicket(string passengerName, string busNo, string source, string destination, Bus[] busList)
        {

            int index = 0;
            foreach(Bus b in busList)
            {
                if (busNo == busList[index].BusID)
                    break;
                index++;
            }
            List<Ticket> tickets = TicketController.LoadTicket();
            int tCount = 0;
            foreach(Ticket t in tickets)
            {
                if(t.Date.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    if(t.BusID == busList[index].BusID)
                    {
                        tCount++;
                    }
                }
            }
            if (busList[index].Count < busList[index].NoOfSeats && tCount < busList[index].NoOfSeats)
            {
                Passenger p = new Passenger(passengerName);
                //Model.DatabaseConnection.AddPassenger(p);
                int price = Ticket.GetPrice(destination); //Model.PlacePrice.GetPrice(destination);
                Ticket t = busList[index].GenerateTicket(p, source, destination, price);
                try
                {
                    Model.DatabaseConnection.AddTicket(t);
                }
                catch (Exception)
                {

                    return null;
                }
                
                return t;
            }
            else
            {
                //MessageBox.Show("Ticket cannot be generated");
                return null;
            }
            
        }
    }
}

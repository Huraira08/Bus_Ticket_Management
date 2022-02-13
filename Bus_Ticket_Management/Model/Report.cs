using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Management.Model
{
    class Report
    {
        //private int totalPrice;
        private int ticketPrice;
        public string BusId { get; set; }
        public int Tickets_Sold { get; set; }
        public int TicketPrice { get => ticketPrice; set => ticketPrice = value; }
        public int Total_Earned { get { return ticketPrice * Tickets_Sold; } }

        public Report()
        {

        }
        public Report(string busName, int count, int ticketPrice=0)
        {
            BusId = busName;
            Tickets_Sold = count;
            this.TicketPrice = ticketPrice;
        }
    }
}

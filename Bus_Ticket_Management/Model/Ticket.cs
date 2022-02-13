using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Ticket
    {
        private Passenger passenger;
        private string ticketID;
        private string source;
        private string destination;
        private DateTime date;
        private int price;
        private string busID;

        public Ticket(Passenger passenger, string ticketID, string source, string destination, DateTime date, int price, string busID)
        {
            this.Passenger1 = passenger;
            TicketID = ticketID;
            Source = source;
            Destination = destination;
            Date = date;
            Price = price;
            BusID = busID;
        }

        public Passenger Passenger
        {
            get;
            set;
        }
        public static int GetPrice(string place)
        {
            switch (place)
            {
                case "Shaikhupra":
                    return 100;
                    break;
                case "Shakot":
                    return 120;
                    break;
                case "Khurriawala":
                    return 150;
                    break;
                case "Faisalabad":
                    return 200;
                    break;
                default:
                    return 0;
            }
        }
        public static string[] GetPlaces()
        {
            string[] places = new string[] { "Shaikhupra", "Shakot", "Khurriawala", "Faisalabad" };
            return places;
        }
        public Passenger Passenger1 { get => passenger; set => passenger = value; }
        public string Passenger_Name { get { return passenger.Name; } set { passenger.Name = value; } }
        public string TicketID { get => ticketID; set => ticketID = value; }
        public string Source { get => source; set => source = value; }
        public string Destination { get => destination; set => destination = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Price { get => price; set => price = value; }
        public string BusID { get => busID; set => busID = value; }
    }
}
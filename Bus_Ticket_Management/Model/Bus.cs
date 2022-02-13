using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Model
{
    public class Bus
    {
        private string busID;
        private int noOfSeats;
        private string busType;
        private DateTime time;
        private Passenger[] passenger;
        private Driver driver;
        private string busSource;
        private string busDestination;
        private Ticket[] ticket;
        private int count;
        private static int busIdCount = 1;
        //public bool available;

        public bool AvailableStatus 
        {
            get
            {
                if(DateTime.Now.Hour > time.Hour)
                {
                    return false;
                }
                else if(DateTime.Now.Hour == time.Hour)
                {
                    if(DateTime.Now.Minute > time.Minute || DateTime.Now.Minute == time.Minute)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
        }
        public Bus(string busID, int noOfSeats, string busType, DateTime time, string driverID, string busSource, string busDestination)
        {
            this.busID = busID;
            Bus.BusIdCount++;
            NoOfSeats = noOfSeats;
            BusType = busType;
            Time = time;
            driver = new Driver();
            Driver.EmployeeID = driverID;
            BusSource = busSource;
            BusDestination = busDestination;
            passenger = new Passenger[noOfSeats];
            ticket = new Ticket[noOfSeats];
            Count = 0;
        }
        public Bus(int noOfSeats, string busType, DateTime time, string driverID, string busSource, string busDestination)
        {
            busID = Bus.BusIdCount.ToString();
            Bus.BusIdCount++;
            NoOfSeats = noOfSeats;
            BusType = busType;
            Time = time;
            driver = new Driver();
            Driver.EmployeeID = driverID;
            BusSource = busSource;
            BusDestination = busDestination;
            passenger = new Passenger[noOfSeats];
            ticket = new Ticket[noOfSeats];
            Count = 0;
        }
        public Bus(int noOfSeats, string busType, DateTime time, Driver driver, string busSource, string busDestination)
        {
            busID = Bus.BusIdCount.ToString();
            Bus.BusIdCount++;
            NoOfSeats = noOfSeats;
            BusType = busType;
            Time = time;
            Driver = driver;
            BusSource = busSource;
            BusDestination = busDestination;
            passenger = new Passenger[noOfSeats];
            ticket = new Ticket[noOfSeats];
            Count = 0;
        }
        public Bus()
        {
            Count = 0;
            passenger = new Passenger[noOfSeats];
            ticket = new Ticket[noOfSeats];
        }
        public string BusID { get => busID; /*set => busID = value;*/ }
        public int NoOfSeats { get => noOfSeats; set => noOfSeats = value; }
        public string BusType { get => busType; set => busType = value; }
        public DateTime Time { get => time; set => time = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public string BusSource { get => busSource; set => busSource = value; }
        public string BusDestination { get => busDestination; set => busDestination = value; }

        public Passenger Passenger
        {
            get;
            set;
        }

        public Ticket Ticket
        {
            get;
            set;
        }

        public static int BusIdCount { get => busIdCount; set => busIdCount = value; }
        public int Count { get => count; set => count = value; }
        public string Driver_ID
        {
            get { return driver.EmployeeID; }
        }
        public string Dispatch_Time
        {
            get { return time.ToLongTimeString(); }
        }

        //public static int BusIdCount { get => busIdCount; set => busIdCount = value; }

        private string GenerateTicketID()
        {
            return Count.ToString() + busID + DateTime.Now.Year.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Second.ToString();
        }
        public Ticket GenerateTicket(Passenger p, string source, string destination, int price)
        {
            if (Count < NoOfSeats)
            {
                passenger[Count] = p;
                Ticket t = new Ticket(p, GenerateTicketID(), source, destination, DateTime.Now, price, busID);
                ticket[Count] = t;
                Count = Count + 1;
                //MessageBox.Show(t.TicketID);
                return ticket[Count-1];
            }
            else
            {
                return null;
            }
        }
    }
}
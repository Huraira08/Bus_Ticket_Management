using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Passenger : Person
    {
        private string passengerID;
        private static int count = 1;
        public Passenger(string name, int num) : base(name)
        {
            this.name = name;
            count = int.Parse(Bus_Ticket_Management.Controller.GetSetID.PassengerIdDatabase);
            passengerID = count.ToString();
            Bus_Ticket_Management.Controller.GetSetID.PassengerIdDatabase = count.ToString();

            //count++;
        }
        public Passenger(string name) : base(name)
        {
            DateTime t = new DateTime(2010, 01, 01);
            passengerID = (t.Ticks - DateTime.Now.Ticks).ToString();
        }

        public string PassengerID
        {
            get
            {
                return passengerID;
            }
            set
            {
                passengerID = value;
            }
        }
    }
}
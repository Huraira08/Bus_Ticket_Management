using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bus_Ticket_Management.Controller;

namespace Bus_Ticket_Management.VIEW
{
    public partial class GenerateTicket : Form
    {
        Bus[] bus;
        public GenerateTicket()
        {
            InitializeComponent();
        }

        private void btnGenerateTicket_Click(object sender, EventArgs e)
        {
            //label7.Text = txtTicketId.Text;
            if (txtPassengerName.Text == string.Empty || cmbBusNoPlate.Text == string.Empty || cmbBusSource.Text == string.Empty || cmbBusDestination.Text == string.Empty)
            {
                MessageBox.Show("Kindly enter All Fields");
            }
            else
            {
                try
                {
                    string PName = txtPassengerName.Text;
                    Ticket t = GenerateTicketController.GenerateTicket(txtPassengerName.Text, cmbBusNoPlate.Text, cmbBusSource.Text, cmbBusDestination.Text, bus);
                    if (t == null)
                    {
                        MessageBox.Show("Ticket cannot be generated. All tickets are sold");
                    }
                    else
                    {
                        //MessageBox.Show("Ticket Generated. The Price of Ticket is : " + t.Price);
                        t.Passenger_Name = PName;
                        ShowTicketForm st = new ShowTicketForm(t);
                        st.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ticket cannot be generated. All tickets are Sold");
                }
                
            }
        }

        private void GenerateTicket_Load(object sender, EventArgs e)
        {
            cmbBusSource.Items.Add("Lahore");
            //string[] places = Ticket.GetPlaces();
            //foreach(string place in places)
            //{
            //    cmbBusDestination.Items.Add(place);
            //}
            #region
            //for(int i=0;i<5;i++)
            //{
            //    bus[i] = new Bus(40, "A.C.", DateTime.Now, new Driver((i + 1 * 2).ToString(), (i + 1).ToString(), "Driver", 25000), "lahore", "Faisalabad");
            //    cmbBusNoPlate.Items.Add(bus[i].BusID);
            //}
            #endregion
            List<Bus> busList =  Controller.LoadBuses.GetBusList();
            int count = 0;
            foreach(Bus b in busList)
            {
                if(b.AvailableStatus)
                {
                    cmbBusNoPlate.Items.Add(b.BusID);
                    //List<Ticket> tickets = TicketController.LoadTicket();
                    //int tCount = 0;
                    //foreach (Ticket t in tickets)
                    //{
                    //    if (t.Date == DateTime.Now)
                    //    {
                    //        if (t.BusID == b.BusID)
                    //        {
                    //            tCount++;
                    //        }
                    //    }
                    //}
                    //if(b.Count < tCount)
                    //{
                    //    cmbBusNoPlate.Items.Add(b.BusID);
                    //}
                }
                    
                count++;
            }
            bus = new Bus[count];
            int i = 0;
            foreach (Bus b in busList)
            {
                bus[i] = b;
                i++;
            }
        }

        private void cmbBusNoPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBusDestination.Items.Clear();
            int i = 0;
            for(;i<bus.Length;i++)
            {
                if (bus[i].BusID == cmbBusNoPlate.Text)
                    break;
            }
            string[] places = Ticket.GetPlaces();
            foreach (string place in places)
            {
                if(place == bus[i].BusDestination)
                {
                    cmbBusDestination.Items.Add(place);
                    break;
                }
                cmbBusDestination.Items.Add(place);
            }
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ticket_Management.VIEW
{
    public partial class DeleteBusRecord : Form
    {
        Bus bus = new Bus();
        public DeleteBusRecord()
        {
            InitializeComponent();
        }

        private void DeleteBusRecord_Load(object sender, EventArgs e)
        {
            List<Bus> busList = Controller.LoadBuses.GetBusList();
            foreach(Bus b in busList)
            {
                cmbBusNoPlate.Items.Add(b.BusID);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmbBusNoPlate.Text != string.Empty)
            {
                //Model.DatabaseConnection.DeleteBus(bus.BusID);
                Controller.DeleteBusFromDatabase.DeleteBus(bus.BusID);
                cmbBusNoPlate.Items.Remove(bus.BusID);
                cmbBusNoPlate.SelectedItem = null;
                txtBusDestination.Text = "";
                txtBusDispatchTime.Text = "";
                txtBusSource.Text = "";
                txtBusType.Text = "";
                txtDriverId.Text = "";
                txtNoOfseats.Text = "";
            }
        }

        private void cmbBusNoPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Bus> busList = Controller.LoadBuses.GetBusList();
            
            foreach (Bus b in busList)
            {
                if(b.BusID == cmbBusNoPlate.Text)
                {
                    bus = b;
                    break;
                }
            }
            txtDriverId.Text = bus.Driver.EmployeeID;
            txtBusType.Text = bus.BusType;
            txtNoOfseats.Text = bus.NoOfSeats.ToString();
            txtBusDispatchTime.Text = bus.Time.ToString("hh:mm:ss");
            txtBusSource.Text = bus.BusSource;
            txtBusDestination.Text = bus.BusDestination;
        }
    }
}

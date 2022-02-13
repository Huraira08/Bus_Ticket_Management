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

namespace Bus_Ticket_Management.VIEW
{
    public partial class UpdateBusRecord : Form
    {
        Bus bus = new Bus();
        public UpdateBusRecord()
        {
            InitializeComponent();
        }

        private void cmbBusNoPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Bus> busList = Controller.LoadBuses.GetBusList();

            foreach (Bus b in busList)
            {
                if (b.BusID == cmbBusNoPlate.Text)
                {
                    bus = b;
                    break;
                }
            }
            txtDriverId.Text = bus.Driver.EmployeeID;
            txtBusType.Text = bus.BusType;
            txtNoOfseats.Text = bus.NoOfSeats.ToString();
            dtpDispatchTime.Value = bus.Time;
            txtBusSource.Text = bus.BusSource;
            txtBusDestination.Text = bus.BusDestination;
        }

        private void UpdateBusRecord_Load(object sender, EventArgs e)
        {
            List<Bus> busList = Controller.LoadBuses.GetBusList();
            foreach (Bus b in busList)
            {
                cmbBusNoPlate.Items.Add(b.BusID);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cmbBusNoPlate.Text != string.Empty)
            {//), int.Parse(time[3].ToString() + time[4].ToString()), int.Parse(time[6].ToString() + time[7].ToString()))

                if (cmbBusNoPlate.Text==string.Empty|| txtDriverId.Text == string.Empty || txtBusType.Text == string.Empty
                 || txtNoOfseats.Text == string.Empty || dtpDispatchTime.Text == string.Empty || txtBusSource.Text == string.Empty || txtBusDestination.Text == string.Empty)
                {

                    MessageBox.Show("Kindly Enter All Fields");
                }
                else
                {
                    bus.Driver.EmployeeID = txtDriverId.Text;
                    bus.BusType = txtBusType.Text;
                    bus.NoOfSeats = int.Parse(txtNoOfseats.Text);

                    txtBusSource.Text = bus.BusSource;
                    txtBusDestination.Text = bus.BusDestination;
                    DateTime time = dtpDispatchTime.Value;
                    Bus newBus = new Bus(bus.BusID, bus.NoOfSeats, bus.BusType, time, bus.Driver.EmployeeID, bus.BusSource, bus.BusDestination);
                    Model.DatabaseConnection.UpdateBus(newBus);
                }
            }
        }

        private void txtNoOfseats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Kindly enter only digit in No of Seats!");

            }
        }
    }
}

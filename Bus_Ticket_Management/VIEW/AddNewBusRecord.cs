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
    public partial class AddNewBusRecord : Form
    {
        Driver[] driver;
        public AddNewBusRecord()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbDriverId.Text == string.Empty || cmbBusType.Text == string.Empty
                  || txtNoOfseats.Text == string.Empty || dtpDispatchTime.Text == string.Empty || cmbBusSource.Text == string.Empty || cmbBusDestination.Text == string.Empty)
            {

                MessageBox.Show("Kindly Enter All Fields");
            }
            else
            {
                //string id = txtBusNoPlate.Text;
                string busID = Controller.GetSetID.BusIdDatabase;
                string driverID = cmbDriverId.Text;
                string type = cmbBusType.Text;
                int seats = int.Parse(txtNoOfseats.Text);
                DateTime time = dtpDispatchTime.Value;
                string source = cmbBusSource.Text;
                string destination = cmbBusDestination.Text;
                Bus.BusIdCount = int.Parse(busID);
                Controller.GetSetID.BusIdDatabase = Bus.BusIdCount.ToString();
                Bus b = new Bus(seats, type, time, driverID, source, destination);
                Model.DatabaseConnection.AddBus(b);

                cmbBusDestination.SelectedItem = null;
                cmbBusSource.SelectedItem = null;
                cmbBusType.SelectedItem = null;
                cmbDriverId.SelectedItem = null;
                txtNoOfseats.Text = "";
            }
            
        }

        private void AddNewBusRecord_Load(object sender, EventArgs e)
        {
            List<Driver> driverList = Controller.DriverController.LoadDrivers();
            int count = 0;
            List<Bus> bus = Controller.LoadBuses.GetBusList();
            bool check = false;
            foreach (Driver d in driverList)
            {
                foreach(Bus bus1 in bus)
                {
                    if (d.EmployeeID == bus1.Driver_ID)
                    {
                        check = true;
                        //MessageBox.Show("Not adding : "+d.EmployeeID);
                        //continue;
                    }
                }
                if(!check)
                {
                    cmbDriverId.Items.Add(d.EmployeeID);
                    //MessageBox.Show(d.EmployeeID);
                }
                check = false;
                count++;
            }
            driver = new Driver[count];
            int i = 0;
            foreach(Driver d in driverList)
            {
                driver[i] = d;
            }
            cmbBusSource.Items.Add("Lahore");
            string[] places = Ticket.GetPlaces();
            foreach (string place in places)
            {
                cmbBusDestination.Items.Add(place);
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

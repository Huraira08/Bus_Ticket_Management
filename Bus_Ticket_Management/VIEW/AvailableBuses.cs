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
    public partial class AvailableBuses : Form
    {
        public AvailableBuses()
        {
            InitializeComponent();
        }

        private void AvailableBuses_Load(object sender, EventArgs e)
        {
            //DataSet ds = Model.DatabaseConnection.GetBusesDataSet();
            //dgvBuses.DataSource = ds.Tables["Bus"];
            List<Bus> busList = Controller.LoadBuses.GetBusList();
            List<Bus> newBusList = new List<Bus>();
            foreach(Bus b in busList)
            {
                if(b.AvailableStatus)
                {
                    newBusList.Add(b);
                }
            }
            dgvBuses.DataSource = newBusList;
            dgvBuses.Columns[0].Visible = false;
            dgvBuses.Columns[4].Visible = false;
            dgvBuses.Columns[5].Visible = false;
            dgvBuses.Columns[8].Visible = false;
            dgvBuses.Columns[9].Visible = false;
            dgvBuses.Columns[10].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

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
    public partial class ViewAllBusRecord : Form
    {
        public ViewAllBusRecord()
        {
            InitializeComponent();
        }

        private void dataGridViewAllBusRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewAllBusRecord_Load(object sender, EventArgs e)
        {
            List<Bus> busList = Controller.LoadBuses.GetBusList();
            dgvAllBusRecord.DataSource = busList;
            dgvAllBusRecord.Columns[5].Visible = false;
            dgvAllBusRecord.Columns[4].Visible = false;
            dgvAllBusRecord.Columns[0].Visible = false;
            //dgvAllBusRecord.Columns[7].Visible = false;
            dgvAllBusRecord.Columns[8].Visible = false;
            dgvAllBusRecord.Columns[9].Visible = false;
            dgvAllBusRecord.Columns[10].Visible = false;
        }
    }
}

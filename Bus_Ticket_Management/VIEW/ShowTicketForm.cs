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
    public partial class ShowTicketForm : Form
    {
        Ticket t;
        public ShowTicketForm(Ticket t)
        {
            InitializeComponent();
            this.t = t;

        }

        private void ShowTicketForm_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(t);
            dgvTicketShow.DataSource = tickets;
            dgvTicketShow.Columns[0].Visible = false;
            dgvTicketShow.Columns[1].Visible = false;
        }
    }
}

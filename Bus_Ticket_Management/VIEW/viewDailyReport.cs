using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bus_Ticket_Management.Model;

namespace Bus_Ticket_Management.VIEW
{
    public partial class viewDailyReport : Form
    {
        public viewDailyReport()
        {
            InitializeComponent();
        }

        private void viewDailyReport_Load(object sender, EventArgs e)
        {
            List<Ticket> t = Controller.TicketController.LoadTicket();
            List<Ticket> newTicketList = new List<Ticket>();
            foreach(Ticket ticket in t)
            {
                if(ticket.Date.ToShortDateString() == DateTime.Now.Date.ToShortDateString())
                {
                    newTicketList.Add(ticket);
                }
            }

            List<Report> r = new List<Report>();
            List<Bus> b = Controller.LoadBuses.GetBusList();

            foreach(Bus bus in b)
            {
                Report report = new Report(bus.BusID, 0);
                r.Add(report);
            }
            foreach(Ticket ticket1 in newTicketList)
            {
                foreach(Report report in r)
                {
                    if(report.BusId == ticket1.BusID)
                    {
                        report.Tickets_Sold++;
                        report.TicketPrice = ticket1.Price;
                    }
                }
            }
            dgvDailyReport.DataSource = r;
            dgvDailyReport.Columns[2].Visible = false;
        }
    }
}

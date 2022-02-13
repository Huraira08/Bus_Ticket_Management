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
    public partial class HOME2 : Form
    {
        public HOME2()
        {
            InitializeComponent();
        }

        private void HOME2_Load(object sender, EventArgs e)
        {
            this.Show();
        }
        public object loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
            return f;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateBusRecord_Click(object sender, EventArgs e)
        {
            loadform(new UpdateBusRecord());
            LblTextChange.Text = btnUpdateBusRecord.Text;
        }

        private void btnGenerateTickets_Click(object sender, EventArgs e)
        {
            object f = loadform(new GenerateTicket());
            LblTextChange.Text = btnGenerateTickets.Text;
        }

        private void btnAddBusRecord_Click(object sender, EventArgs e)
        {
            loadform(new AddNewBusRecord());
            LblTextChange.Text = btnAddBusRecord.Text;
        }

        private void btnDeleteBusRecord_Click(object sender, EventArgs e)
        {
            loadform(new DeleteBusRecord());
            LblTextChange.Text = btnDeleteBusRecord.Text;

        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            loadform(new viewDailyReport());
            LblTextChange.Text = btnDailyReport.Text;
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvailableBuses_Click(object sender, EventArgs e)
        {
            loadform(new AvailableBuses());
            LblTextChange.Text = btnAvailableBuses.Text;
        }

        private void btnViewAllBusRecord_Click(object sender, EventArgs e)
        {
            loadform(new ViewAllBusRecord());
            LblTextChange.Text = btnViewAllBusRecord.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelWithRespectToButtonText_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LblTextChange_Click(object sender, EventArgs e)
        {

        }
    }
}

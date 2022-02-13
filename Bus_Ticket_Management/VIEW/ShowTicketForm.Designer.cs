
namespace Bus_Ticket_Management.VIEW
{
    partial class ShowTicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTicketShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicketShow
            // 
            this.dgvTicketShow.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvTicketShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTicketShow.Location = new System.Drawing.Point(0, 0);
            this.dgvTicketShow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTicketShow.Name = "dgvTicketShow";
            this.dgvTicketShow.RowTemplate.Height = 24;
            this.dgvTicketShow.Size = new System.Drawing.Size(697, 450);
            this.dgvTicketShow.TabIndex = 1;
            // 
            // ShowTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.dgvTicketShow);
            this.Name = "ShowTicketForm";
            this.Text = "ShowTicketForm";
            this.Load += new System.EventHandler(this.ShowTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicketShow;
    }
}
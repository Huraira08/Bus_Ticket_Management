namespace Bus_Ticket_Management.VIEW
{
    partial class viewDailyReport
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
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDailyReport.Location = new System.Drawing.Point(0, 0);
            this.dgvDailyReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.RowTemplate.Height = 24;
            this.dgvDailyReport.Size = new System.Drawing.Size(614, 511);
            this.dgvDailyReport.TabIndex = 0;
            // 
            // viewDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 511);
            this.Controls.Add(this.dgvDailyReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "viewDailyReport";
            this.Text = "viewDailyReport";
            this.Load += new System.EventHandler(this.viewDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDailyReport;
    }
}
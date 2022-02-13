namespace Bus_Ticket_Management.VIEW
{
    partial class ViewAllBusRecord
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
            this.dgvAllBusRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBusRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllBusRecord
            // 
            this.dgvAllBusRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAllBusRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBusRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllBusRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvAllBusRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAllBusRecord.Name = "dgvAllBusRecord";
            this.dgvAllBusRecord.RowTemplate.Height = 24;
            this.dgvAllBusRecord.Size = new System.Drawing.Size(654, 541);
            this.dgvAllBusRecord.TabIndex = 2;
            this.dgvAllBusRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllBusRecord_CellContentClick);
            // 
            // ViewAllBusRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(654, 541);
            this.Controls.Add(this.dgvAllBusRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewAllBusRecord";
            this.Text = "ViewAllBusRecord";
            this.Load += new System.EventHandler(this.ViewAllBusRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBusRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllBusRecord;
    }
}
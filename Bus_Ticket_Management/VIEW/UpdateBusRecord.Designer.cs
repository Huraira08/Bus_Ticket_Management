namespace Bus_Ticket_Management.VIEW
{
    partial class UpdateBusRecord
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
            this.cmbBusNoPlate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusDestination = new System.Windows.Forms.TextBox();
            this.txtBusSource = new System.Windows.Forms.TextBox();
            this.txtDriverId = new System.Windows.Forms.TextBox();
            this.txtBusType = new System.Windows.Forms.TextBox();
            this.txtNoOfseats = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpDispatchTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbBusNoPlate
            // 
            this.cmbBusNoPlate.FormattingEnabled = true;
            this.cmbBusNoPlate.Location = new System.Drawing.Point(261, 47);
            this.cmbBusNoPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusNoPlate.Name = "cmbBusNoPlate";
            this.cmbBusNoPlate.Size = new System.Drawing.Size(295, 24);
            this.cmbBusNoPlate.TabIndex = 60;
            this.cmbBusNoPlate.SelectedIndexChanged += new System.EventHandler(this.cmbBusNoPlate_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(57, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Driver Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(57, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Bus Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(57, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Bus Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(57, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Bus Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(57, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Bus Dispatch time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(57, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "No of Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Bus No. Plate";
            // 
            // txtBusDestination
            // 
            this.txtBusDestination.Location = new System.Drawing.Point(261, 290);
            this.txtBusDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusDestination.Name = "txtBusDestination";
            this.txtBusDestination.Size = new System.Drawing.Size(295, 22);
            this.txtBusDestination.TabIndex = 58;
            // 
            // txtBusSource
            // 
            this.txtBusSource.Location = new System.Drawing.Point(261, 250);
            this.txtBusSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusSource.Name = "txtBusSource";
            this.txtBusSource.Size = new System.Drawing.Size(295, 22);
            this.txtBusSource.TabIndex = 57;
            // 
            // txtDriverId
            // 
            this.txtDriverId.Location = new System.Drawing.Point(261, 90);
            this.txtDriverId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(295, 22);
            this.txtDriverId.TabIndex = 45;
            // 
            // txtBusType
            // 
            this.txtBusType.Location = new System.Drawing.Point(261, 130);
            this.txtBusType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusType.Name = "txtBusType";
            this.txtBusType.Size = new System.Drawing.Size(295, 22);
            this.txtBusType.TabIndex = 47;
            // 
            // txtNoOfseats
            // 
            this.txtNoOfseats.Location = new System.Drawing.Point(261, 170);
            this.txtNoOfseats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoOfseats.Name = "txtNoOfseats";
            this.txtNoOfseats.Size = new System.Drawing.Size(295, 22);
            this.txtNoOfseats.TabIndex = 46;
            this.txtNoOfseats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfseats_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(261, 330);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(295, 39);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseCompatibleTextRendering = true;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpDispatchTime
            // 
            this.dtpDispatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDispatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDispatchTime.Location = new System.Drawing.Point(261, 207);
            this.dtpDispatchTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDispatchTime.Name = "dtpDispatchTime";
            this.dtpDispatchTime.ShowUpDown = true;
            this.dtpDispatchTime.Size = new System.Drawing.Size(295, 26);
            this.dtpDispatchTime.TabIndex = 61;
            // 
            // UpdateBusRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(680, 526);
            this.Controls.Add(this.dtpDispatchTime);
            this.Controls.Add(this.cmbBusNoPlate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusDestination);
            this.Controls.Add(this.txtBusSource);
            this.Controls.Add(this.txtDriverId);
            this.Controls.Add(this.txtBusType);
            this.Controls.Add(this.txtNoOfseats);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateBusRecord";
            this.Text = "UpdateBusRecord";
            this.Load += new System.EventHandler(this.UpdateBusRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBusNoPlate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusDestination;
        private System.Windows.Forms.TextBox txtBusSource;
        private System.Windows.Forms.TextBox txtDriverId;
        private System.Windows.Forms.TextBox txtBusType;
        private System.Windows.Forms.TextBox txtNoOfseats;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpDispatchTime;
    }
}
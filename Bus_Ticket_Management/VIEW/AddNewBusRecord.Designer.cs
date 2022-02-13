namespace Bus_Ticket_Management.VIEW
{
    partial class AddNewBusRecord
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNoOfseats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBusType = new System.Windows.Forms.ComboBox();
            this.cmbDriverId = new System.Windows.Forms.ComboBox();
            this.dtpDispatchTime = new System.Windows.Forms.DateTimePicker();
            this.cmbBusSource = new System.Windows.Forms.ComboBox();
            this.cmbBusDestination = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(269, 336);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 39);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCompatibleTextRendering = true;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNoOfseats
            // 
            this.txtNoOfseats.Location = new System.Drawing.Point(269, 176);
            this.txtNoOfseats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoOfseats.Name = "txtNoOfseats";
            this.txtNoOfseats.Size = new System.Drawing.Size(295, 22);
            this.txtNoOfseats.TabIndex = 11;
            this.txtNoOfseats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfseats_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(67, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "No of Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(67, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bus Dispatch time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(67, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bus Source";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(67, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bus Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(67, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bus Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(67, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Driver Id";
            // 
            // cmbBusType
            // 
            this.cmbBusType.FormattingEnabled = true;
            this.cmbBusType.Items.AddRange(new object[] {
            "A.C.",
            "Non-A.C."});
            this.cmbBusType.Location = new System.Drawing.Point(269, 134);
            this.cmbBusType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusType.Name = "cmbBusType";
            this.cmbBusType.Size = new System.Drawing.Size(295, 24);
            this.cmbBusType.TabIndex = 24;
            // 
            // cmbDriverId
            // 
            this.cmbDriverId.FormattingEnabled = true;
            this.cmbDriverId.Location = new System.Drawing.Point(269, 87);
            this.cmbDriverId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDriverId.Name = "cmbDriverId";
            this.cmbDriverId.Size = new System.Drawing.Size(295, 24);
            this.cmbDriverId.TabIndex = 25;
            // 
            // dtpDispatchTime
            // 
            this.dtpDispatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDispatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDispatchTime.Location = new System.Drawing.Point(269, 215);
            this.dtpDispatchTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDispatchTime.Name = "dtpDispatchTime";
            this.dtpDispatchTime.ShowUpDown = true;
            this.dtpDispatchTime.Size = new System.Drawing.Size(295, 26);
            this.dtpDispatchTime.TabIndex = 26;
            // 
            // cmbBusSource
            // 
            this.cmbBusSource.FormattingEnabled = true;
            this.cmbBusSource.Location = new System.Drawing.Point(268, 257);
            this.cmbBusSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusSource.Name = "cmbBusSource";
            this.cmbBusSource.Size = new System.Drawing.Size(295, 24);
            this.cmbBusSource.TabIndex = 51;
            // 
            // cmbBusDestination
            // 
            this.cmbBusDestination.FormattingEnabled = true;
            this.cmbBusDestination.Location = new System.Drawing.Point(268, 294);
            this.cmbBusDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusDestination.Name = "cmbBusDestination";
            this.cmbBusDestination.Size = new System.Drawing.Size(295, 24);
            this.cmbBusDestination.TabIndex = 52;
            // 
            // AddNewBusRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(739, 532);
            this.Controls.Add(this.cmbBusDestination);
            this.Controls.Add(this.cmbBusSource);
            this.Controls.Add(this.dtpDispatchTime);
            this.Controls.Add(this.cmbDriverId);
            this.Controls.Add(this.cmbBusType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoOfseats);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewBusRecord";
            this.Text = "AddNewBusRecord";
            this.Load += new System.EventHandler(this.AddNewBusRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNoOfseats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBusType;
        private System.Windows.Forms.ComboBox cmbDriverId;
        private System.Windows.Forms.DateTimePicker dtpDispatchTime;
        private System.Windows.Forms.ComboBox cmbBusSource;
        private System.Windows.Forms.ComboBox cmbBusDestination;
    }
}
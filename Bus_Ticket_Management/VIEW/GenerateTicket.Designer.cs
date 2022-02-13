namespace Bus_Ticket_Management.VIEW
{
    partial class GenerateTicket
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
            this.btnGenerateTicket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBusNoPlate = new System.Windows.Forms.ComboBox();
            this.cmbBusSource = new System.Windows.Forms.ComboBox();
            this.cmbBusDestination = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerateTicket
            // 
            this.btnGenerateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTicket.Location = new System.Drawing.Point(171, 212);
            this.btnGenerateTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateTicket.Name = "btnGenerateTicket";
            this.btnGenerateTicket.Size = new System.Drawing.Size(221, 32);
            this.btnGenerateTicket.TabIndex = 44;
            this.btnGenerateTicket.Text = "Generate Ticket";
            this.btnGenerateTicket.UseCompatibleTextRendering = true;
            this.btnGenerateTicket.UseVisualStyleBackColor = true;
            this.btnGenerateTicket.Click += new System.EventHandler(this.btnGenerateTicket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(38, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Destination";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(171, 63);
            this.txtPassengerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(222, 20);
            this.txtPassengerName.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(38, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Passenger Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(38, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Bus No. Plate";
            // 
            // cmbBusNoPlate
            // 
            this.cmbBusNoPlate.FormattingEnabled = true;
            this.cmbBusNoPlate.Location = new System.Drawing.Point(171, 96);
            this.cmbBusNoPlate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBusNoPlate.Name = "cmbBusNoPlate";
            this.cmbBusNoPlate.Size = new System.Drawing.Size(222, 21);
            this.cmbBusNoPlate.TabIndex = 45;
            this.cmbBusNoPlate.SelectedIndexChanged += new System.EventHandler(this.cmbBusNoPlate_SelectedIndexChanged);
            // 
            // cmbBusSource
            // 
            this.cmbBusSource.FormattingEnabled = true;
            this.cmbBusSource.Location = new System.Drawing.Point(171, 130);
            this.cmbBusSource.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBusSource.Name = "cmbBusSource";
            this.cmbBusSource.Size = new System.Drawing.Size(222, 21);
            this.cmbBusSource.TabIndex = 48;
            // 
            // cmbBusDestination
            // 
            this.cmbBusDestination.FormattingEnabled = true;
            this.cmbBusDestination.Location = new System.Drawing.Point(170, 162);
            this.cmbBusDestination.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBusDestination.Name = "cmbBusDestination";
            this.cmbBusDestination.Size = new System.Drawing.Size(222, 21);
            this.cmbBusDestination.TabIndex = 49;
            // 
            // GenerateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(505, 406);
            this.Controls.Add(this.cmbBusDestination);
            this.Controls.Add(this.cmbBusSource);
            this.Controls.Add(this.cmbBusNoPlate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.btnGenerateTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateTicket";
            this.Text = "GenerateTicket";
            this.Load += new System.EventHandler(this.GenerateTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerateTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBusNoPlate;
        private System.Windows.Forms.ComboBox cmbBusSource;
        private System.Windows.Forms.ComboBox cmbBusDestination;
    }
}
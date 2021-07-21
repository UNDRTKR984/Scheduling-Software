
namespace SchedulingSoftware
{
    partial class Appointments
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
            this.components = new System.ComponentModel.Container();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentGrid = new System.Windows.Forms.DataGridView();
            this.modifyDeleteButton = new System.Windows.Forms.Button();
            this.viewAppointmentsByGroupBox = new System.Windows.Forms.GroupBox();
            this.filterDateButton = new System.Windows.Forms.Button();
            this.filterDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.weekAppointmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.allAppointmentsButton = new System.Windows.Forms.RadioButton();
            this.monthAppointmentRadioButton = new System.Windows.Forms.RadioButton();
            this.reportsButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allAppointmentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).BeginInit();
            this.viewAppointmentsByGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(325, 279);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(153, 54);
            this.addAppointmentButton.TabIndex = 2;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // appointmentGrid
            // 
            this.appointmentGrid.AllowUserToAddRows = false;
            this.appointmentGrid.AllowUserToDeleteRows = false;
            this.appointmentGrid.AllowUserToResizeRows = false;
            this.appointmentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.appointmentGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.appointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGrid.Location = new System.Drawing.Point(325, 35);
            this.appointmentGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentGrid.MultiSelect = false;
            this.appointmentGrid.Name = "appointmentGrid";
            this.appointmentGrid.RowHeadersWidth = 51;
            this.appointmentGrid.RowTemplate.Height = 24;
            this.appointmentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentGrid.Size = new System.Drawing.Size(684, 239);
            this.appointmentGrid.TabIndex = 3;
            // 
            // modifyDeleteButton
            // 
            this.modifyDeleteButton.Location = new System.Drawing.Point(482, 279);
            this.modifyDeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyDeleteButton.Name = "modifyDeleteButton";
            this.modifyDeleteButton.Size = new System.Drawing.Size(153, 54);
            this.modifyDeleteButton.TabIndex = 4;
            this.modifyDeleteButton.Text = "Modify / Delete\r\nSelected Appointment";
            this.modifyDeleteButton.UseVisualStyleBackColor = true;
            this.modifyDeleteButton.Click += new System.EventHandler(this.modifyDeleteButton_Click);
            // 
            // viewAppointmentsByGroupBox
            // 
            this.viewAppointmentsByGroupBox.Controls.Add(this.filterDateButton);
            this.viewAppointmentsByGroupBox.Controls.Add(this.filterDateCalendar);
            this.viewAppointmentsByGroupBox.Controls.Add(this.weekAppointmentsRadioButton);
            this.viewAppointmentsByGroupBox.Controls.Add(this.allAppointmentsButton);
            this.viewAppointmentsByGroupBox.Controls.Add(this.monthAppointmentRadioButton);
            this.viewAppointmentsByGroupBox.Location = new System.Drawing.Point(26, 25);
            this.viewAppointmentsByGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewAppointmentsByGroupBox.Name = "viewAppointmentsByGroupBox";
            this.viewAppointmentsByGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewAppointmentsByGroupBox.Size = new System.Drawing.Size(266, 308);
            this.viewAppointmentsByGroupBox.TabIndex = 49;
            this.viewAppointmentsByGroupBox.TabStop = false;
            this.viewAppointmentsByGroupBox.Text = "View Appointments By:";
            // 
            // filterDateButton
            // 
            this.filterDateButton.Location = new System.Drawing.Point(16, 255);
            this.filterDateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterDateButton.Name = "filterDateButton";
            this.filterDateButton.Size = new System.Drawing.Size(231, 38);
            this.filterDateButton.TabIndex = 47;
            this.filterDateButton.Text = "Filter Dates";
            this.filterDateButton.UseVisualStyleBackColor = true;
            this.filterDateButton.Click += new System.EventHandler(this.filterDateButton_Click);
            // 
            // filterDateCalendar
            // 
            this.filterDateCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterDateCalendar.Location = new System.Drawing.Point(17, 59);
            this.filterDateCalendar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.filterDateCalendar.Name = "filterDateCalendar";
            this.filterDateCalendar.TabIndex = 46;
            // 
            // weekAppointmentsRadioButton
            // 
            this.weekAppointmentsRadioButton.AutoSize = true;
            this.weekAppointmentsRadioButton.Location = new System.Drawing.Point(165, 27);
            this.weekAppointmentsRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weekAppointmentsRadioButton.Name = "weekAppointmentsRadioButton";
            this.weekAppointmentsRadioButton.Size = new System.Drawing.Size(54, 17);
            this.weekAppointmentsRadioButton.TabIndex = 45;
            this.weekAppointmentsRadioButton.Text = "Week";
            this.weekAppointmentsRadioButton.UseVisualStyleBackColor = true;
            // 
            // allAppointmentsButton
            // 
            this.allAppointmentsButton.AutoSize = true;
            this.allAppointmentsButton.Checked = true;
            this.allAppointmentsButton.Location = new System.Drawing.Point(47, 27);
            this.allAppointmentsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allAppointmentsButton.Name = "allAppointmentsButton";
            this.allAppointmentsButton.Size = new System.Drawing.Size(62, 17);
            this.allAppointmentsButton.TabIndex = 43;
            this.allAppointmentsButton.TabStop = true;
            this.allAppointmentsButton.Text = "View All";
            this.allAppointmentsButton.UseVisualStyleBackColor = true;
            // 
            // monthAppointmentRadioButton
            // 
            this.monthAppointmentRadioButton.AutoSize = true;
            this.monthAppointmentRadioButton.Location = new System.Drawing.Point(110, 27);
            this.monthAppointmentRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthAppointmentRadioButton.Name = "monthAppointmentRadioButton";
            this.monthAppointmentRadioButton.Size = new System.Drawing.Size(55, 17);
            this.monthAppointmentRadioButton.TabIndex = 44;
            this.monthAppointmentRadioButton.Text = "Month";
            this.monthAppointmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            this.reportsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsButton.Location = new System.Drawing.Point(699, 280);
            this.reportsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(153, 54);
            this.reportsButton.TabIndex = 50;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customersButton.Location = new System.Drawing.Point(856, 280);
            this.customersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(153, 54);
            this.customersButton.TabIndex = 51;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(856, 411);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 54);
            this.exitButton.TabIndex = 52;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(Scheduling_Software_C969.appointment);
            // 
            // allAppointmentsLabel
            // 
            this.allAppointmentsLabel.AutoSize = true;
            this.allAppointmentsLabel.Location = new System.Drawing.Point(325, 16);
            this.allAppointmentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allAppointmentsLabel.Name = "allAppointmentsLabel";
            this.allAppointmentsLabel.Size = new System.Drawing.Size(85, 13);
            this.allAppointmentsLabel.TabIndex = 53;
            this.allAppointmentsLabel.Text = "All Appointments";
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 476);
            this.Controls.Add(this.allAppointmentsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.viewAppointmentsByGroupBox);
            this.Controls.Add(this.modifyDeleteButton);
            this.Controls.Add(this.appointmentGrid);
            this.Controls.Add(this.addAppointmentButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Appointments";
            this.Text = "All Appointments";
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).EndInit();
            this.viewAppointmentsByGroupBox.ResumeLayout(false);
            this.viewAppointmentsByGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.DataGridView appointmentGrid;
        private System.Windows.Forms.Button modifyDeleteButton;
        private System.Windows.Forms.GroupBox viewAppointmentsByGroupBox;
        private System.Windows.Forms.Button filterDateButton;
        private System.Windows.Forms.MonthCalendar filterDateCalendar;
        private System.Windows.Forms.RadioButton weekAppointmentsRadioButton;
        private System.Windows.Forms.RadioButton allAppointmentsButton;
        private System.Windows.Forms.RadioButton monthAppointmentRadioButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label allAppointmentsLabel;
    }
}
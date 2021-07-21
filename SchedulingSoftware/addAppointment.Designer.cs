
namespace SchedulingSoftware
{
    partial class addAppointment
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
            this.appointmentIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTypeLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTimeBox = new System.Windows.Forms.GroupBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerAsterisk = new System.Windows.Forms.Label();
            this.appointmentTypeAsterisk = new System.Windows.Forms.Label();
            this.titleAsterisk = new System.Windows.Forms.Label();
            this.locationAsterisk = new System.Windows.Forms.Label();
            this.userAsterisk = new System.Windows.Forms.Label();
            this.requiredInformationAsterisk = new System.Windows.Forms.Label();
            this.requiredInformation = new System.Windows.Forms.Label();
            this.userNameComboBox = new System.Windows.Forms.ComboBox();
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.appointmentInfoBox = new System.Windows.Forms.GroupBox();
            this.customerAppointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.userAppointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.userAppointmentTableLabel = new System.Windows.Forms.Label();
            this.customerAppointmentTableLabel = new System.Windows.Forms.Label();
            this.scheduledAppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.viewAppointmentsByGroupBox = new System.Windows.Forms.GroupBox();
            this.filterDateButton = new System.Windows.Forms.Button();
            this.filterDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.weekAppointmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.allAppointmentsButton = new System.Windows.Forms.RadioButton();
            this.monthAppointmentRadioButton = new System.Windows.Forms.RadioButton();
            this.businessHoursGroupBox = new System.Windows.Forms.GroupBox();
            this.businessDaysLabel = new System.Windows.Forms.Label();
            this.businessHoursLabel = new System.Windows.Forms.Label();
            this.appointmentTimeBox.SuspendLayout();
            this.appointmentInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerAppointmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAppointmentDataGrid)).BeginInit();
            this.scheduledAppointmentsGroupBox.SuspendLayout();
            this.viewAppointmentsByGroupBox.SuspendLayout();
            this.businessHoursGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentIDTextbox
            // 
            this.appointmentIDTextbox.Enabled = false;
            this.appointmentIDTextbox.Location = new System.Drawing.Point(137, 121);
            this.appointmentIDTextbox.Name = "appointmentIDTextbox";
            this.appointmentIDTextbox.ReadOnly = true;
            this.appointmentIDTextbox.Size = new System.Drawing.Size(60, 22);
            this.appointmentIDTextbox.TabIndex = 0;
            this.appointmentIDTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment ID:";
            // 
            // customersComboBox
            // 
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(137, 160);
            this.customersComboBox.MaxDropDownItems = 50;
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(150, 24);
            this.customersComboBox.TabIndex = 30;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.customersComboBox_SelectedIndexChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(59, 163);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(72, 17);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Customer:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(92, 246);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(137, 243);
            this.titleTextBox.MaxLength = 255;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(212, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // appointmentTypeLabel
            // 
            this.appointmentTypeLabel.AutoSize = true;
            this.appointmentTypeLabel.Location = new System.Drawing.Point(4, 205);
            this.appointmentTypeLabel.Name = "appointmentTypeLabel";
            this.appointmentTypeLabel.Size = new System.Drawing.Size(127, 17);
            this.appointmentTypeLabel.TabIndex = 6;
            this.appointmentTypeLabel.Text = "Appointment Type:";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(38, 82);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(93, 17);
            this.currentUserLabel.TabIndex = 9;
            this.currentUserLabel.Text = "Current User:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(48, 417);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(137, 417);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(212, 162);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.Text = "";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(65, 287);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 17);
            this.locationLabel.TabIndex = 12;
            this.locationLabel.Text = "Location:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(137, 328);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(212, 22);
            this.contactTextBox.TabIndex = 2;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(71, 331);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(60, 17);
            this.contactLabel.TabIndex = 14;
            this.contactLabel.Text = "Contact:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(137, 375);
            this.urlTextBox.MaxLength = 255;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(212, 22);
            this.urlTextBox.TabIndex = 3;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(91, 378);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(40, 17);
            this.urlLabel.TabIndex = 16;
            this.urlLabel.Text = "URL:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(59, 36);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(124, 22);
            this.startDatePicker.TabIndex = 5;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(11, 36);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(42, 17);
            this.startDateLabel.TabIndex = 19;
            this.startDateLabel.Text = "Start:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(16, 83);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(37, 17);
            this.endDateLabel.TabIndex = 21;
            this.endDateLabel.Text = "End:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.endDatePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.endDatePicker.CustomFormat = "MM/dd/yyyy | hh:mm    tttt";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(59, 82);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(124, 22);
            this.endDatePicker.TabIndex = 20;
            // 
            // appointmentTimeBox
            // 
            this.appointmentTimeBox.Controls.Add(this.endTimePicker);
            this.appointmentTimeBox.Controls.Add(this.startTimePicker);
            this.appointmentTimeBox.Controls.Add(this.startDateLabel);
            this.appointmentTimeBox.Controls.Add(this.endDateLabel);
            this.appointmentTimeBox.Controls.Add(this.startDatePicker);
            this.appointmentTimeBox.Controls.Add(this.endDatePicker);
            this.appointmentTimeBox.Location = new System.Drawing.Point(417, 5);
            this.appointmentTimeBox.Name = "appointmentTimeBox";
            this.appointmentTimeBox.Size = new System.Drawing.Size(570, 132);
            this.appointmentTimeBox.TabIndex = 22;
            this.appointmentTimeBox.TabStop = false;
            this.appointmentTimeBox.Text = "Appointment Time";
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(199, 82);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(124, 22);
            this.endTimePicker.TabIndex = 7;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(199, 36);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(124, 22);
            this.startTimePicker.TabIndex = 6;
            // 
            // appointmentTypeComboBox
            // 
            this.appointmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appointmentTypeComboBox.FormattingEnabled = true;
            this.appointmentTypeComboBox.Items.AddRange(new object[] {
            "Personal",
            "Presentation",
            "Scrum"});
            this.appointmentTypeComboBox.Location = new System.Drawing.Point(137, 202);
            this.appointmentTypeComboBox.MaxDropDownItems = 50;
            this.appointmentTypeComboBox.Name = "appointmentTypeComboBox";
            this.appointmentTypeComboBox.Size = new System.Drawing.Size(212, 24);
            this.appointmentTypeComboBox.TabIndex = 23;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Items.AddRange(new object[] {
            "Toronto, Canada",
            "Vancouver, Canada",
            "Oslo, Norway",
            "New York, USA",
            "Los Angeles, USA"});
            this.locationComboBox.Location = new System.Drawing.Point(137, 284);
            this.locationComboBox.MaxDropDownItems = 50;
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(212, 24);
            this.locationComboBox.TabIndex = 24;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1066, 602);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 58);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add / Save";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1212, 602);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 58);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // customerAsterisk
            // 
            this.customerAsterisk.AutoSize = true;
            this.customerAsterisk.BackColor = System.Drawing.Color.Transparent;
            this.customerAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAsterisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerAsterisk.Location = new System.Drawing.Point(355, 160);
            this.customerAsterisk.Name = "customerAsterisk";
            this.customerAsterisk.Size = new System.Drawing.Size(21, 25);
            this.customerAsterisk.TabIndex = 27;
            this.customerAsterisk.Text = "*";
            // 
            // appointmentTypeAsterisk
            // 
            this.appointmentTypeAsterisk.AutoSize = true;
            this.appointmentTypeAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypeAsterisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.appointmentTypeAsterisk.Location = new System.Drawing.Point(355, 201);
            this.appointmentTypeAsterisk.Name = "appointmentTypeAsterisk";
            this.appointmentTypeAsterisk.Size = new System.Drawing.Size(21, 25);
            this.appointmentTypeAsterisk.TabIndex = 28;
            this.appointmentTypeAsterisk.Text = "*";
            // 
            // titleAsterisk
            // 
            this.titleAsterisk.AutoSize = true;
            this.titleAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAsterisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleAsterisk.Location = new System.Drawing.Point(355, 243);
            this.titleAsterisk.Name = "titleAsterisk";
            this.titleAsterisk.Size = new System.Drawing.Size(21, 25);
            this.titleAsterisk.TabIndex = 29;
            this.titleAsterisk.Text = "*";
            // 
            // locationAsterisk
            // 
            this.locationAsterisk.AutoSize = true;
            this.locationAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationAsterisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.locationAsterisk.Location = new System.Drawing.Point(355, 284);
            this.locationAsterisk.Name = "locationAsterisk";
            this.locationAsterisk.Size = new System.Drawing.Size(21, 25);
            this.locationAsterisk.TabIndex = 30;
            this.locationAsterisk.Text = "*";
            // 
            // userAsterisk
            // 
            this.userAsterisk.AutoSize = true;
            this.userAsterisk.BackColor = System.Drawing.Color.Transparent;
            this.userAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAsterisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userAsterisk.Location = new System.Drawing.Point(355, 63);
            this.userAsterisk.Name = "userAsterisk";
            this.userAsterisk.Size = new System.Drawing.Size(21, 25);
            this.userAsterisk.TabIndex = 31;
            this.userAsterisk.Text = "*";
            // 
            // requiredInformationAsterisk
            // 
            this.requiredInformationAsterisk.AutoSize = true;
            this.requiredInformationAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredInformationAsterisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.requiredInformationAsterisk.Location = new System.Drawing.Point(117, 29);
            this.requiredInformationAsterisk.Name = "requiredInformationAsterisk";
            this.requiredInformationAsterisk.Size = new System.Drawing.Size(21, 25);
            this.requiredInformationAsterisk.TabIndex = 32;
            this.requiredInformationAsterisk.Text = "*";
            // 
            // requiredInformation
            // 
            this.requiredInformation.AutoSize = true;
            this.requiredInformation.Location = new System.Drawing.Point(134, 36);
            this.requiredInformation.Name = "requiredInformation";
            this.requiredInformation.Size = new System.Drawing.Size(140, 17);
            this.requiredInformation.TabIndex = 33;
            this.requiredInformation.Text = "Required Information";
            // 
            // userNameComboBox
            // 
            this.userNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userNameComboBox.FormattingEnabled = true;
            this.userNameComboBox.Location = new System.Drawing.Point(137, 79);
            this.userNameComboBox.MaxDropDownItems = 50;
            this.userNameComboBox.Name = "userNameComboBox";
            this.userNameComboBox.Size = new System.Drawing.Size(150, 24);
            this.userNameComboBox.TabIndex = 8;
            this.userNameComboBox.SelectedIndexChanged += new System.EventHandler(this.userNameComboBox_SelectedIndexChanged);
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.customerIDComboBox.Enabled = false;
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(322, 160);
            this.customerIDComboBox.MaxDropDownItems = 50;
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(27, 24);
            this.customerIDComboBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID:";
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.userIDComboBox.Enabled = false;
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(322, 79);
            this.userIDComboBox.MaxDropDownItems = 50;
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(27, 24);
            this.userIDComboBox.TabIndex = 37;
            // 
            // appointmentInfoBox
            // 
            this.appointmentInfoBox.Controls.Add(this.requiredInformation);
            this.appointmentInfoBox.Controls.Add(this.userIDComboBox);
            this.appointmentInfoBox.Controls.Add(this.appointmentIDTextbox);
            this.appointmentInfoBox.Controls.Add(this.label3);
            this.appointmentInfoBox.Controls.Add(this.label1);
            this.appointmentInfoBox.Controls.Add(this.label2);
            this.appointmentInfoBox.Controls.Add(this.customersComboBox);
            this.appointmentInfoBox.Controls.Add(this.customerIDComboBox);
            this.appointmentInfoBox.Controls.Add(this.customerLabel);
            this.appointmentInfoBox.Controls.Add(this.titleLabel);
            this.appointmentInfoBox.Controls.Add(this.requiredInformationAsterisk);
            this.appointmentInfoBox.Controls.Add(this.titleTextBox);
            this.appointmentInfoBox.Controls.Add(this.userAsterisk);
            this.appointmentInfoBox.Controls.Add(this.appointmentTypeLabel);
            this.appointmentInfoBox.Controls.Add(this.locationAsterisk);
            this.appointmentInfoBox.Controls.Add(this.userNameComboBox);
            this.appointmentInfoBox.Controls.Add(this.titleAsterisk);
            this.appointmentInfoBox.Controls.Add(this.currentUserLabel);
            this.appointmentInfoBox.Controls.Add(this.appointmentTypeAsterisk);
            this.appointmentInfoBox.Controls.Add(this.descriptionLabel);
            this.appointmentInfoBox.Controls.Add(this.customerAsterisk);
            this.appointmentInfoBox.Controls.Add(this.descriptionTextBox);
            this.appointmentInfoBox.Controls.Add(this.locationLabel);
            this.appointmentInfoBox.Controls.Add(this.contactLabel);
            this.appointmentInfoBox.Controls.Add(this.locationComboBox);
            this.appointmentInfoBox.Controls.Add(this.contactTextBox);
            this.appointmentInfoBox.Controls.Add(this.appointmentTypeComboBox);
            this.appointmentInfoBox.Controls.Add(this.urlLabel);
            this.appointmentInfoBox.Controls.Add(this.urlTextBox);
            this.appointmentInfoBox.Location = new System.Drawing.Point(12, 5);
            this.appointmentInfoBox.Name = "appointmentInfoBox";
            this.appointmentInfoBox.Size = new System.Drawing.Size(399, 591);
            this.appointmentInfoBox.TabIndex = 38;
            this.appointmentInfoBox.TabStop = false;
            this.appointmentInfoBox.Text = "Appointment Information";
            // 
            // customerAppointmentDataGrid
            // 
            this.customerAppointmentDataGrid.AllowUserToAddRows = false;
            this.customerAppointmentDataGrid.AllowUserToDeleteRows = false;
            this.customerAppointmentDataGrid.AllowUserToResizeColumns = false;
            this.customerAppointmentDataGrid.AllowUserToResizeRows = false;
            this.customerAppointmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerAppointmentDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerAppointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerAppointmentDataGrid.Location = new System.Drawing.Point(19, 263);
            this.customerAppointmentDataGrid.MultiSelect = false;
            this.customerAppointmentDataGrid.Name = "customerAppointmentDataGrid";
            this.customerAppointmentDataGrid.ReadOnly = true;
            this.customerAppointmentDataGrid.RowHeadersWidth = 51;
            this.customerAppointmentDataGrid.RowTemplate.Height = 24;
            this.customerAppointmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerAppointmentDataGrid.Size = new System.Drawing.Size(550, 178);
            this.customerAppointmentDataGrid.TabIndex = 39;
            // 
            // userAppointmentDataGrid
            // 
            this.userAppointmentDataGrid.AllowUserToAddRows = false;
            this.userAppointmentDataGrid.AllowUserToDeleteRows = false;
            this.userAppointmentDataGrid.AllowUserToResizeColumns = false;
            this.userAppointmentDataGrid.AllowUserToResizeRows = false;
            this.userAppointmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userAppointmentDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userAppointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAppointmentDataGrid.Location = new System.Drawing.Point(19, 55);
            this.userAppointmentDataGrid.MultiSelect = false;
            this.userAppointmentDataGrid.Name = "userAppointmentDataGrid";
            this.userAppointmentDataGrid.ReadOnly = true;
            this.userAppointmentDataGrid.RowHeadersWidth = 51;
            this.userAppointmentDataGrid.RowTemplate.Height = 24;
            this.userAppointmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userAppointmentDataGrid.Size = new System.Drawing.Size(550, 178);
            this.userAppointmentDataGrid.TabIndex = 40;
            // 
            // userAppointmentTableLabel
            // 
            this.userAppointmentTableLabel.AutoSize = true;
            this.userAppointmentTableLabel.Location = new System.Drawing.Point(19, 35);
            this.userAppointmentTableLabel.Name = "userAppointmentTableLabel";
            this.userAppointmentTableLabel.Size = new System.Drawing.Size(179, 17);
            this.userAppointmentTableLabel.TabIndex = 41;
            this.userAppointmentTableLabel.Text = "Current User Appointments";
            // 
            // customerAppointmentTableLabel
            // 
            this.customerAppointmentTableLabel.AutoSize = true;
            this.customerAppointmentTableLabel.Location = new System.Drawing.Point(19, 243);
            this.customerAppointmentTableLabel.Name = "customerAppointmentTableLabel";
            this.customerAppointmentTableLabel.Size = new System.Drawing.Size(209, 17);
            this.customerAppointmentTableLabel.TabIndex = 42;
            this.customerAppointmentTableLabel.Text = "Current Customer Appointments";
            // 
            // scheduledAppointmentsGroupBox
            // 
            this.scheduledAppointmentsGroupBox.Controls.Add(this.viewAppointmentsByGroupBox);
            this.scheduledAppointmentsGroupBox.Controls.Add(this.userAppointmentDataGrid);
            this.scheduledAppointmentsGroupBox.Controls.Add(this.customerAppointmentTableLabel);
            this.scheduledAppointmentsGroupBox.Controls.Add(this.customerAppointmentDataGrid);
            this.scheduledAppointmentsGroupBox.Controls.Add(this.userAppointmentTableLabel);
            this.scheduledAppointmentsGroupBox.Location = new System.Drawing.Point(417, 143);
            this.scheduledAppointmentsGroupBox.Name = "scheduledAppointmentsGroupBox";
            this.scheduledAppointmentsGroupBox.Size = new System.Drawing.Size(935, 453);
            this.scheduledAppointmentsGroupBox.TabIndex = 43;
            this.scheduledAppointmentsGroupBox.TabStop = false;
            this.scheduledAppointmentsGroupBox.Text = "Currently Scheduled Appointments";
            // 
            // viewAppointmentsByGroupBox
            // 
            this.viewAppointmentsByGroupBox.Controls.Add(this.filterDateButton);
            this.viewAppointmentsByGroupBox.Controls.Add(this.filterDateCalendar);
            this.viewAppointmentsByGroupBox.Controls.Add(this.weekAppointmentsRadioButton);
            this.viewAppointmentsByGroupBox.Controls.Add(this.allAppointmentsButton);
            this.viewAppointmentsByGroupBox.Controls.Add(this.monthAppointmentRadioButton);
            this.viewAppointmentsByGroupBox.Location = new System.Drawing.Point(575, 35);
            this.viewAppointmentsByGroupBox.Name = "viewAppointmentsByGroupBox";
            this.viewAppointmentsByGroupBox.Size = new System.Drawing.Size(354, 406);
            this.viewAppointmentsByGroupBox.TabIndex = 48;
            this.viewAppointmentsByGroupBox.TabStop = false;
            this.viewAppointmentsByGroupBox.Text = "View Appointments By:";
            // 
            // filterDateButton
            // 
            this.filterDateButton.Location = new System.Drawing.Point(21, 314);
            this.filterDateButton.Name = "filterDateButton";
            this.filterDateButton.Size = new System.Drawing.Size(308, 47);
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
            this.filterDateCalendar.Location = new System.Drawing.Point(23, 73);
            this.filterDateCalendar.Name = "filterDateCalendar";
            this.filterDateCalendar.TabIndex = 46;
            // 
            // weekAppointmentsRadioButton
            // 
            this.weekAppointmentsRadioButton.AutoSize = true;
            this.weekAppointmentsRadioButton.Location = new System.Drawing.Point(220, 33);
            this.weekAppointmentsRadioButton.Name = "weekAppointmentsRadioButton";
            this.weekAppointmentsRadioButton.Size = new System.Drawing.Size(65, 21);
            this.weekAppointmentsRadioButton.TabIndex = 45;
            this.weekAppointmentsRadioButton.Text = "Week";
            this.weekAppointmentsRadioButton.UseVisualStyleBackColor = true;
            // 
            // allAppointmentsButton
            // 
            this.allAppointmentsButton.AutoSize = true;
            this.allAppointmentsButton.Checked = true;
            this.allAppointmentsButton.Location = new System.Drawing.Point(63, 33);
            this.allAppointmentsButton.Name = "allAppointmentsButton";
            this.allAppointmentsButton.Size = new System.Drawing.Size(77, 21);
            this.allAppointmentsButton.TabIndex = 43;
            this.allAppointmentsButton.TabStop = true;
            this.allAppointmentsButton.Text = "View All";
            this.allAppointmentsButton.UseVisualStyleBackColor = true;
            // 
            // monthAppointmentRadioButton
            // 
            this.monthAppointmentRadioButton.AutoSize = true;
            this.monthAppointmentRadioButton.Location = new System.Drawing.Point(146, 33);
            this.monthAppointmentRadioButton.Name = "monthAppointmentRadioButton";
            this.monthAppointmentRadioButton.Size = new System.Drawing.Size(68, 21);
            this.monthAppointmentRadioButton.TabIndex = 44;
            this.monthAppointmentRadioButton.Text = "Month";
            this.monthAppointmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // businessHoursGroupBox
            // 
            this.businessHoursGroupBox.Controls.Add(this.businessDaysLabel);
            this.businessHoursGroupBox.Controls.Add(this.businessHoursLabel);
            this.businessHoursGroupBox.Location = new System.Drawing.Point(992, 5);
            this.businessHoursGroupBox.Name = "businessHoursGroupBox";
            this.businessHoursGroupBox.Size = new System.Drawing.Size(360, 132);
            this.businessHoursGroupBox.TabIndex = 44;
            this.businessHoursGroupBox.TabStop = false;
            this.businessHoursGroupBox.Text = "Business Hours";
            // 
            // businessDaysLabel
            // 
            this.businessDaysLabel.AutoSize = true;
            this.businessDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessDaysLabel.Location = new System.Drawing.Point(117, 63);
            this.businessDaysLabel.Name = "businessDaysLabel";
            this.businessDaysLabel.Size = new System.Drawing.Size(125, 17);
            this.businessDaysLabel.TabIndex = 1;
            this.businessDaysLabel.Text = "Monday - Friday";
            // 
            // businessHoursLabel
            // 
            this.businessHoursLabel.AutoSize = true;
            this.businessHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessHoursLabel.Location = new System.Drawing.Point(116, 36);
            this.businessHoursLabel.Name = "businessHoursLabel";
            this.businessHoursLabel.Size = new System.Drawing.Size(131, 17);
            this.businessHoursLabel.TabIndex = 0;
            this.businessHoursLabel.Text = "9 AM - 5 PM EST";
            // 
            // addAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 675);
            this.Controls.Add(this.businessHoursGroupBox);
            this.Controls.Add(this.scheduledAppointmentsGroupBox);
            this.Controls.Add(this.appointmentInfoBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.appointmentTimeBox);
            this.Name = "addAppointment";
            this.Text = "Add Appointment";
            this.appointmentTimeBox.ResumeLayout(false);
            this.appointmentTimeBox.PerformLayout();
            this.appointmentInfoBox.ResumeLayout(false);
            this.appointmentInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerAppointmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAppointmentDataGrid)).EndInit();
            this.scheduledAppointmentsGroupBox.ResumeLayout(false);
            this.scheduledAppointmentsGroupBox.PerformLayout();
            this.viewAppointmentsByGroupBox.ResumeLayout(false);
            this.viewAppointmentsByGroupBox.PerformLayout();
            this.businessHoursGroupBox.ResumeLayout(false);
            this.businessHoursGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox appointmentIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label appointmentTypeLabel;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.GroupBox appointmentTimeBox;
        private System.Windows.Forms.ComboBox appointmentTypeComboBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label customerAsterisk;
        private System.Windows.Forms.Label appointmentTypeAsterisk;
        private System.Windows.Forms.Label titleAsterisk;
        private System.Windows.Forms.Label locationAsterisk;
        private System.Windows.Forms.Label userAsterisk;
        private System.Windows.Forms.Label requiredInformationAsterisk;
        private System.Windows.Forms.Label requiredInformation;
        private System.Windows.Forms.ComboBox userNameComboBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.ComboBox customerIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.GroupBox appointmentInfoBox;
        private System.Windows.Forms.DataGridView customerAppointmentDataGrid;
        private System.Windows.Forms.DataGridView userAppointmentDataGrid;
        private System.Windows.Forms.Label userAppointmentTableLabel;
        private System.Windows.Forms.Label customerAppointmentTableLabel;
        private System.Windows.Forms.GroupBox scheduledAppointmentsGroupBox;
        private System.Windows.Forms.MonthCalendar filterDateCalendar;
        private System.Windows.Forms.GroupBox viewAppointmentsByGroupBox;
        private System.Windows.Forms.Button filterDateButton;
        private System.Windows.Forms.RadioButton weekAppointmentsRadioButton;
        private System.Windows.Forms.RadioButton allAppointmentsButton;
        private System.Windows.Forms.RadioButton monthAppointmentRadioButton;
        private System.Windows.Forms.GroupBox businessHoursGroupBox;
        private System.Windows.Forms.Label businessHoursLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label businessDaysLabel;
    }
}
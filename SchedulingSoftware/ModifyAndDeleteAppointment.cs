using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using MySql.Data.EntityFramework;

namespace SchedulingSoftware
{
    public partial class ModifyAndDeleteAppointment : Form
    {
        // Entity Framework DbContext
        private Scheduling_Software_C969.U08aMCEntities dbcontext = new Scheduling_Software_C969.U08aMCEntities();

        // constructor
        public ModifyAndDeleteAppointment(int appointmentID)
        {
            InitializeComponent();
            var currentAppointment = dbcontext.appointments.Where(app => app.appointmentId == appointmentID).ToList()[0];

            // set username Field and userId field
            var users = dbcontext.users.OrderBy(user => user.userName) // order users by username using lambda
                .ToList();
            var userIds = dbcontext.users.OrderBy(user => user.userName).Select(user => user.userId).ToList(); // order users by username and select the userID using lambda

            // set appointment ID field
            appointmentIDTextbox.Text = currentAppointment.appointmentId.ToString();


            int findIndex = 0;



            // load usernames into userNameComboBox
            foreach (var user in users)
            {
                userNameComboBox.Items.Add(user.userName);
                userIDComboBox.Items.Add(user.userId);

                if (currentAppointment.userId == user.userId)
                {
                    userIDComboBox.SelectedIndex = findIndex;
                    userNameComboBox.SelectedIndex = findIndex;
                }
                findIndex++;
            }

            // set customer fields
            var customers = dbcontext.customers.OrderBy(cus => cus.customerName).ToList(); // order customers by customer name using lambda
            var customerIds = dbcontext.customers.OrderBy(cus => cus.customerName).Select(cus => cus.customerId).ToList(); // order customers by customer name and select the customerIds using lambda

            findIndex = 0;

            // add customerNames to customersComboBox
            foreach (var customer in customers)
            {
                customersComboBox.Items.Add(customer.customerName);
                customerIDComboBox.Items.Add(customer.customerId);

                if (customer.customerId == currentAppointment.customerId)
                {
                    customerIDComboBox.SelectedIndex = findIndex;
                    customersComboBox.SelectedIndex = findIndex;
                }
                findIndex++;
            }


            findIndex = 0;
            // set all remaining form fields
            foreach (var item in appointmentTypeComboBox.Items)
            {
                if (currentAppointment.type == (string)item)
                {
                    appointmentTypeComboBox.SelectedIndex = findIndex;
                }
                findIndex++;
            }

            titleTextBox.Text = currentAppointment.title;

            findIndex = 0;
            foreach (var item in locationComboBox.Items)
            {
                if (currentAppointment.location == (string)item)
                {
                    locationComboBox.SelectedIndex = findIndex;
                }
                findIndex++;
            }

            contactTextBox.Text = currentAppointment.contact;
            urlTextBox.Text = currentAppointment.url;
            descriptionTextBox.Text = currentAppointment.url;
            startDatePicker.Value = currentAppointment.start.ToLocalTime();
            startTimePicker.Value = currentAppointment.start.ToLocalTime();
            endDatePicker.Value = currentAppointment.end.ToLocalTime();
            endTimePicker.Value = currentAppointment.end.ToLocalTime();


           
        }

        // addButton_Click
        //      try to add and save the appointment when the Add/Save button is clicked
        private void modifyButton_Click(object sender, EventArgs e)
        {
            // reset asterisk colors
            userAsterisk.ForeColor = SystemColors.ControlText;
            customerAsterisk.ForeColor = SystemColors.ControlText;
            appointmentTypeAsterisk.ForeColor = SystemColors.ControlText;
            titleAsterisk.ForeColor = SystemColors.ControlText;
            locationAsterisk.ForeColor = SystemColors.ControlText;

            // get starting and ending appointment times            
            DateTime startTime = (startDatePicker.Value.Date.AddHours(startTimePicker.Value.Hour).AddMinutes(startTimePicker.Value.Minute)).ToUniversalTime();            
            DateTime endTime = (endDatePicker.Value.Date.AddHours(endTimePicker.Value.Hour).AddMinutes(endTimePicker.Value.Minute)).ToUniversalTime();
                        
            DateTime UTCStartTime = startTime;
            DateTime UTCEndTime = endTime;

            // convert to easter time for checking business hours
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            startTime = TimeZoneInfo.ConvertTimeFromUtc(startTime, easternZone);          
            endTime = TimeZoneInfo.ConvertTimeFromUtc(endTime, easternZone);

            string endTimeString = UTCEndTime.ToString("yyyy-MM-dd HH:mm:ss");
            string startTimeString = UTCStartTime.ToString("yyyy-MM-dd HH:mm:ss");

            // field validation
            bool error = false;
            string errorMessage = "";

            if (userNameComboBox.Text == "")
            {
                errorMessage += "Please select or input a username.\n";
                error = true;
                userAsterisk.ForeColor = Color.Red;
            }
            if (customersComboBox.Text == "")
            {
                errorMessage += "Please select a customer.\n";
                error = true;
                customerAsterisk.ForeColor = Color.Red;
            }
            if (appointmentTypeComboBox.Text == "")
            {
                errorMessage += "Please select an appointment type.\n";
                error = true;
                appointmentTypeAsterisk.ForeColor = Color.Red;
            }
            if (titleTextBox.Text == "")
            {
                errorMessage += "Please add a title to the appointment.\n";
                error = true;
                titleAsterisk.ForeColor = Color.Red;
            }
            if (locationComboBox.Text == "")
            {
                errorMessage += "Please select a location.\n";
                error = true;
                locationAsterisk.ForeColor = Color.Red;
            }

            // schedule checking and validation
            if (startTime == endTime)
            {
                errorMessage += "Please change the end time to be after your start time.\n";
                error = true;
            }
            if ((startTime.DayOfWeek == DayOfWeek.Saturday || startTime.DayOfWeek == DayOfWeek.Sunday || endTime.DayOfWeek == DayOfWeek.Saturday || startTime.DayOfWeek == DayOfWeek.Sunday) || startTime.Hour < 9 || startTime.Hour > 17 || (startTime.Hour == 17 && startTime.Minute > 0) || endTime.Hour < 9 || endTime.Hour > 17 || (endTime.Hour == 17 && endTime.Minute > 0) || (endTime.TimeOfDay - startTime.TimeOfDay >= TimeSpan.FromHours(8)))
            {
                errorMessage += "Please schedule the start and end times during business hours.\n";
                error = true;
            }
            if (error)
            {
                MessageBox.Show(errorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validate that the date and time selected don't conflict with the customer or user

            int tempUserId = int.Parse(userIDComboBox.Text);
            var userAppointmentTimes = dbcontext.appointments.Where(user => user.userId == tempUserId)
                .Select(user => new {appointmentId = user.appointmentId, start = user.start, end = user.end }) // use lamdba to select the start and end dates for each appointment associated with this user, quicker to code this on the spot using lambda instead of having to code a whole function that passes in and object and returns another object
                .ToList();

            

            foreach (var user in userAppointmentTimes)
            {
                // skip over the current apointment ID because it is the one being changed
                if (user.appointmentId == int.Parse(appointmentIDTextbox.Text))
                {
                    Console.WriteLine(user.start);
                    continue;
                }

                if ((UTCStartTime >= user.start && UTCStartTime <= user.end)
                    || (UTCEndTime >= user.start && UTCEndTime <= user.end)
                    || (UTCStartTime <= user.start && UTCEndTime >= user.end))
                {
                    Console.WriteLine("app ID" + user.appointmentId);
                    Console.WriteLine("Start: " + user.start);
                    Console.WriteLine("End: " + user.end);
                    try
                    {
                        throw new ScheduleConflictException();
                    }
                    catch (ScheduleConflictException)
                    {
                        Console.WriteLine("user conflict");
                        MessageBox.Show("The appointment date and time that was selected conflicts with the user's or the customer's appointment schedule.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }

            int tempCustomerId = int.Parse(customerIDComboBox.Text);
            var customerAppointmentTimes = dbcontext.appointments.Where(customer => customer.customerId == tempCustomerId)
                .Select(customer => new { appointmentId = customer.appointmentId, start = customer.start, end = customer.end }) // use lamda to select the start and end dates for each appointment associated with this customer, quicker to code this on the spot using lambda instead of having to code a whole function that passes in and object and returns another object
                .ToList();

            foreach (var customer in customerAppointmentTimes)
            {
                // skip over the current apointment ID because it is the one being changed
                if (customer.appointmentId == int.Parse(appointmentIDTextbox.Text))
                {
                    continue;
                }
                if ((UTCStartTime >= customer.start && UTCStartTime <= customer.end)
                    || (UTCEndTime >= customer.start && UTCEndTime <= customer.end)
                    || (UTCStartTime <= customer.start && UTCEndTime >= customer.end))
                {
                    try
                    {
                        throw new ScheduleConflictException();
                    }
                    catch (ScheduleConflictException)
                    {
                        Console.WriteLine("customer conflict");
                        MessageBox.Show("The appointment date and time that was selected conflicts with the user's or the customer's appointment schedule.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // insert information into the database
            try
            {

                Console.WriteLine("Updating!");

                // convert original times back to local
                
                Console.WriteLine(startTime);
                

                string description;
                string url;
                string contact;

                if (descriptionTextBox.Text == "")
                {
                    description = "none";
                }
                else
                {
                    description = descriptionTextBox.Text;
                }
                if (urlTextBox.Text == "")
                {
                    url = "none";
                }
                else
                {
                    url = urlTextBox.Text;
                }
                if (contactTextBox.Text == "")
                {
                    contact = "none";
                }
                else
                {
                    contact = contactLabel.Text;
                }

                

                // create a new appointment to add to the appointment table
             
                var updatedApp = new Scheduling_Software_C969.appointment
                {
                    appointmentId = int.Parse(appointmentIDTextbox.Text),
                    customerId = int.Parse(customerIDComboBox.Text),
                    userId = int.Parse(userIDComboBox.Text),
                    title = titleTextBox.Text,
                    description = description,
                    location = locationComboBox.Text,
                    contact = contact,
                    type = appointmentTypeComboBox.Text,
                    url = url,
                    start = UTCStartTime,
                    end = UTCEndTime,
                    lastUpdate = DateTime.UtcNow,
                    createdBy = userNameComboBox.Text,
                    lastUpdateBy = userNameComboBox.Text
                };

                string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                // SQL command
                string SQLstring = $"UPDATE appointment SET customerId = {updatedApp.customerId}, userId = {updatedApp.userId}, title = '{updatedApp.title}', description = '{updatedApp.description}', location = '{updatedApp.location}', contact = '{updatedApp.contact}', type = '{updatedApp.type}', url = '{updatedApp.url}', start = '{updatedApp.start.ToString("yyyy-MM-dd HH:mm:ss")}', end = '{updatedApp.end.ToString("yyyy-MM-dd HH:mm:ss")}', createdBy = '{updatedApp.createdBy}', lastUpdateBy = '{updatedApp.lastUpdateBy}', lastUpdate = '{updatedApp.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE appointmentId = {updatedApp.appointmentId}; ";

                MySqlCommand command = new MySqlCommand(SQLstring, con);
                MySqlDataReader sqlDataReader;
                sqlDataReader = command.ExecuteReader();
                
                con.Close();

            }

            catch
            {
                MessageBox.Show("Could not add this record to the database.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Appointments appointmentsPage = new Appointments();
            var currentMain = Program.MyAppCxt.MainForm;
            Program.MyAppCxt.MainForm = appointmentsPage;
            currentMain.Close();
            appointmentsPage.Show();
            this.Close();

        }

        // startDateTimePicker_ValueChanged
        //      sets the endDateTimePicker min value to be the same as what is currently selected in the start date
        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.MinDate = startDatePicker.Value;
        }

        // userNameComboBox_SelectedIndexChanged
        //      set the userID and their appointment table to the corresponding username and convert UTC time to Local Time
        private void userNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the user ID to match the user's name
            userIDComboBox.SelectedIndex = userNameComboBox.SelectedIndex;
            int tempID = int.Parse(userIDComboBox.Text);

            // set the label to user's name
            userAppointmentTableLabel.Text = userNameComboBox.Text + "'s Current Appointments";

            // SQL command
            string sqlString = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN user u ON u.userId = appointment.userId WHERE appointment.userId = {tempID} ORDER BY start;";

            getUserData(sqlString);

        }

        // customersComboBox_SelectedIndexChanged
        //      set the customerID and their appointment table to the corresponding customername and convert UTC Time to Local Time
        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the customer ID to match the customers's name
            customerIDComboBox.SelectedIndex = customersComboBox.SelectedIndex;
            int tempID = int.Parse(customerIDComboBox.Text);
            customerAppointmentTableLabel.Text = customersComboBox.Text + "'s Current Appointments";

            // SQL command
            string sqlString = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN customer c ON c.customerId = appointment.customerId WHERE appointment.customerId = {tempID} ORDER BY start;";

            // set customer data
            getCustomerData(sqlString);
        }

        // getUserData
        //      gets data related to user to load up it's data table.  A SQL query to execute is passed into the function
        private void getUserData(string sqlQuery)
        {
            // mysql connection
            string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand command = new MySqlCommand(sqlQuery, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            // Convert from UTC to Local
            DataTable dataTableUTC = new DataTable();
            DataTable userDataTableLocal = new DataTable();
            adapter.Fill(dataTableUTC);
            adapter.Fill(userDataTableLocal);

            for (int i = 0; i < dataTableUTC.Rows.Count; i++)
            {
                DateTime dateTimeStart = (DateTime)dataTableUTC.Rows[i]["start"];
                DateTime dateTimeEnd = (DateTime)dataTableUTC.Rows[i]["end"];
                userDataTableLocal.Rows[i]["Start"] = dateTimeStart.ToLocalTime();
                userDataTableLocal.Rows[i]["End"] = dateTimeEnd.ToLocalTime();
            }

            // Assign Data Source to datagridview
            userAppointmentDataGrid.DataSource = userDataTableLocal;
        }

        // getCustomerData
        //      loads the customer appointmenets in the customer appointment table
        private void getCustomerData(string sqlQuery)
        {
            // mysql connection
            string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand command = new MySqlCommand(sqlQuery, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            // Convert from UTC to Local
            DataTable dataTableUTC = new DataTable();
            DataTable customerDataTableLocal = new DataTable();
            adapter.Fill(dataTableUTC);
            adapter.Fill(customerDataTableLocal);

            for (int i = 0; i < dataTableUTC.Rows.Count; i++)
            {
                DateTime dateTimeStart = (DateTime)dataTableUTC.Rows[i]["start"];
                DateTime dateTimeEnd = (DateTime)dataTableUTC.Rows[i]["end"];
                customerDataTableLocal.Rows[i]["Start"] = dateTimeStart.ToLocalTime();
                customerDataTableLocal.Rows[i]["End"] = dateTimeEnd.ToLocalTime();
            }
          
            // Assign Data Source to datagridview
            customerAppointmentDataGrid.DataSource = customerDataTableLocal;

        }

        // allAppointments
        //      gets all the appointments associated with the selected user and selected customer
        private void allAppointments()
        {
            filterDateCalendar.BoldedDates = null;

            // set the user ID to match the user's name
            userIDComboBox.SelectedIndex = userNameComboBox.SelectedIndex;
            int userTempID = int.Parse(userIDComboBox.Text);

            // set the label to user's name
            userAppointmentTableLabel.Text = userNameComboBox.Text + "'s Current Appointments";

            // set the customer ID to match the customers's name
            customerIDComboBox.SelectedIndex = customersComboBox.SelectedIndex;
            int customerTempID = int.Parse(customerIDComboBox.Text);
            customerAppointmentTableLabel.Text = customersComboBox.Text + "'s Current Appointments";

            // SQL command
            string sqlString = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN user u ON u.userId = appointment.userId WHERE appointment.userId = {userTempID} ORDER BY start;";
            getUserData(sqlString);

            // SQL command
            sqlString = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN customer c ON c.customerId = appointment.customerId WHERE appointment.customerId = {customerTempID} ORDER BY start;";

            // set customer data
            getCustomerData(sqlString);


        }

        // filterAppointments
        //      gets the appoints of the selected user and the selected customer filtered by selected Month or selected Week
        private void filterAppointments()
        {
            filterDateCalendar.RemoveAllBoldedDates();

            string sqlStatement;

            int tempUserID = int.Parse(userIDComboBox.Text);
            int tempCustomerID = int.Parse(customerIDComboBox.Text);

            // filter by month if selected
            if (monthAppointmentRadioButton.Checked)
            {
                var tempMonth = filterDateCalendar.SelectionRange.Start.Month;
                var tempYear = filterDateCalendar.SelectionRange.Start.Year;
                int tempEndDay = 0;

                string startDate = tempMonth.ToString() + "/01/" + tempYear.ToString();
                DateTime tempStartDate = Convert.ToDateTime(startDate).ToUniversalTime();

                // find how many days in selected mongth
                switch (tempMonth)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                        tempEndDay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        tempEndDay = 30;
                        break;
                    default:
                        if (tempYear % 4 == 0)
                        {
                            tempEndDay = 29;
                        }
                        else
                        {
                            tempEndDay = 28;
                        }
                        break;
                }

                // add dates to be bolded in calendar and update
                for (int i = 0; i < tempEndDay; i++)
                {
                    filterDateCalendar.AddBoldedDate(tempStartDate.AddDays(i));
                }
                filterDateCalendar.UpdateBoldedDates();

                string endDate = tempMonth.ToString() + $"/{tempEndDay}/" + tempYear.ToString();
                DateTime tempEndDate = Convert.ToDateTime(endDate).ToUniversalTime();
                tempEndDate = tempEndDate.AddDays(1);

                // get strings into MySQL format
                endDate = tempEndDate.ToString("yyyy-MM-dd HH:mm:ss");
                startDate = tempStartDate.ToString("yyyy-MM-dd HH:mm:ss");

                // exeucte SQL statements for user and customer
                sqlStatement = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN customer c ON c.customerId = appointment.customerId WHERE appointment.customerId = {tempCustomerID} AND start BETWEEN '{startDate}' AND '{endDate}' ORDER BY start;";
                getCustomerData(sqlStatement);
                sqlStatement = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN user u ON u.userId = appointment.userId WHERE appointment.userId = {tempUserID} AND start BETWEEN '{startDate}' AND '{endDate}' ORDER BY start;";
                getUserData(sqlStatement);
            }
            // if the month isn't checked, sort the selected week
            else
            {
                var tempDayOfWeek = filterDateCalendar.SelectionStart.DayOfWeek;
                var tempYear = filterDateCalendar.SelectionRange.Start.Year;

                int tempDay = filterDateCalendar.SelectionStart.Day;
                int tempMonth = filterDateCalendar.SelectionStart.Month;

                int tempStartDay = 0;

                string startDate;
                string endDate;

                // determine how many days back to start from the current date highlighted to get beginning of the week
                switch (tempDayOfWeek)
                {
                    case System.DayOfWeek.Sunday:
                        tempStartDay = 0;
                        break;
                    case System.DayOfWeek.Monday:
                        tempStartDay = 1;
                        break;
                    case System.DayOfWeek.Tuesday:
                        tempStartDay = 2;
                        break;
                    case System.DayOfWeek.Wednesday:
                        tempStartDay = 3;
                        break;
                    case System.DayOfWeek.Thursday:
                        tempStartDay = 4;
                        break;
                    case System.DayOfWeek.Friday:
                        tempStartDay = 5;
                        break;
                    case System.DayOfWeek.Saturday:
                        tempStartDay = 6;
                        break;
                }
                startDate = tempMonth.ToString() + $"/{tempDay}/" + tempYear.ToString();

                // get start and end dates and convert to universal because functions convert back to local
                DateTime tempStartDate = Convert.ToDateTime(startDate).AddDays(-tempStartDay).ToUniversalTime(); // start of the week
                
                DateTime tempEndDate = tempStartDate.AddDays(7).ToUniversalTime(); // end of the week
                
                // add bolded dates to calendar
                for (int i = 0; i < 7; i++)
                {
                    filterDateCalendar.AddBoldedDate(tempStartDate.AddDays(i));
                }
                filterDateCalendar.UpdateBoldedDates();

                startDate = tempStartDate.ToString("yyyy-MM-dd HH:mm:ss"); // customize for mysql
                endDate = tempEndDate.ToString("yyyy-MM-dd HH:mm:ss"); // customize for mysql

                // execute SQL statements
                sqlStatement = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN customer c ON c.customerId = appointment.customerId WHERE appointment.customerId = {tempCustomerID} AND start BETWEEN '{startDate}' AND '{endDate}' ORDER BY start;";
                getCustomerData(sqlStatement);
                sqlStatement = $"Select start AS 'Start', end AS 'End', title AS 'Title', appointmentId AS 'ID' FROM appointment JOIN user u ON u.userId = appointment.userId WHERE appointment.userId = {tempUserID} AND start BETWEEN '{startDate}' AND '{endDate}' ORDER BY start;";
                getUserData(sqlStatement);

            }
        }

        // filterDateButton_Click
        //      checks to make sure a user and customer are selected and then gets all appointments or filtered appointments depending on what is selected
        private void filterDateButton_Click(object sender, EventArgs e)
        {
            if (userNameComboBox.Text == "" || customerIDComboBox.Text == "")
            {
                MessageBox.Show("Please select a user and a customer before filtering the appointment dates.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (allAppointmentsButton.Checked)
            {
                allAppointments();
            }
            else
            {
                filterAppointments();
            }
        }

        // cancelButton_Click
        //      closes the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Appointments appointmentsPage = new Appointments();
            var currentMain = Program.MyAppCxt.MainForm;
            Program.MyAppCxt.MainForm = appointmentsPage;
            currentMain.Close();
            appointmentsPage.Show();
            this.Close();
        }

        // deleteButton_Click
        //      deletes the appointment in the form
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int tempAppointmentId = int.Parse(appointmentIDTextbox.Text);

                string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                // SQL command
                string SQLstring = $"DELETE FROM appointment WHERE appointmentId = {tempAppointmentId}; ";

                MySqlCommand command = new MySqlCommand(SQLstring, con);
                MySqlDataReader sqlDataReader;
                sqlDataReader = command.ExecuteReader();

                con.Close();

                Appointments appointmentsPage = new Appointments();
                var currentMain = Program.MyAppCxt.MainForm;
                Program.MyAppCxt.MainForm = appointmentsPage;
                currentMain.Close();
                appointmentsPage.Show();
                this.Close();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;
using MySql.Data.EntityFramework;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SchedulingSoftware
{
    public partial class Reports : Form
    {
        private Scheduling_Software_C969.U08aMCEntities dbContext = new Scheduling_Software_C969.U08aMCEntities();

        // constructor
        public Reports()
        {
            InitializeComponent();
        }

        // runReportButton_Click
        //      runs the selected report and displays it to the screen
        private void runReportButton_Click(object sender, EventArgs e)
        {
            reportTextBox.Text = "";


            // if appointments types by each month is selected
            if (appointmentTypesRadioButton.Checked)
            {
                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
                
                // get appointments
                var appointmentsQuery = from appointment in dbContext.appointments
                                        select new
                                        {
                                            appointment.type,
                                            appointment.start,
                                        };
                // convert the query to a list
                var appointmentsQueryConvert = appointmentsQuery.Select(app => app).ToList();

                // convert start times to local times
                var allAppointments = appointmentsQueryConvert.Select(app => new // using lamba to select the specific items needed and to convert to local time on the spot rather than having to declare a function/method elsewhere
                {
                    app.type,
                    start = app.start.ToLocalTime()
                }).ToList();


                foreach (var month in months)
                {
                    int monthNumber = Array.IndexOf(months, month)+1;
                    reportTextBox.Text += $"{month}:\n";

                    var appointments = allAppointments.Where(app => app.start.Month == monthNumber).ToList(); // using lambda here on the spot to save time and code from having to right another function elsewhere -- this lambda returns appointments that match the month


                    var appointmentTypes = appointments.Where(appointment => appointment.start.Month == monthNumber).Select(app => app.type).Distinct(); // using lambda here on the spot to save time and code from having to right another function elsewhere -- this lambda returns appointments that match the month and another lambda to select only the type of appointments


                    foreach (var type in appointmentTypes)
                    {
                        reportTextBox.Text += $"\t{type, -10}: {appointments.Count(app => app.type == type), -10}\n";  // using lambda here to find all the types that match the current type in appointment types, using lambda here is easier/quicker than writing a seperate function elsewhere
                    }
                }
            }
            // if the Schedule for each consultant is selected
            else if (eachConsultantRadioButton.Checked)
            {
                var consultantQuery = dbContext.appointments.Select(app => app).ToList(); // using lambda here to select all categories of each appointment, which is easier/quicker than writing a function elsewhere 
                var consultants = dbContext.appointments.OrderBy(app => app.user.userName).Select(app => app.user).Distinct().ToList(); // using lambda here to order the usernames of the associated userId, which is easier/quicker to do here than writing a function elsewhere
                foreach (var consultant in consultants)
                {
                    reportTextBox.Text += $"{consultant.userName}'s Appointments:\n";

                    var appointmentList = dbContext.appointments.Where(app => consultant.userId == app.userId).OrderBy(app => app.start).ToList(); // using lambda here to select appointments where the appointments match the user ID and sort them by start time, which is easier/quicker than writing a function elsewhere

                    reportTextBox.Text += $"\t{"Customer",-15}\t{"Start",-35}\t\t{"End",-30}\n";

                    foreach (var appointment in appointmentList)
                    {
                        reportTextBox.Text += $"\t{appointment.customer.customerName,-15}\t{(appointment.start).ToLocalTime(),-35}\t{(appointment.end).ToLocalTime(),-30}\n";
                    }
                    reportTextBox.Text += "\n";
                }
            }
            // if schedule for each customer is seletected
            else if (eachCustomerRadioButton.Checked)
            {
                var customerQuery = dbContext.appointments.Select(app => app).ToList(); // using lambda here to select all categories of each appointment, which is easier/quicker than writing a function elsewhere
                var customers = dbContext.customers.OrderBy(cus => cus.customerName).Select(cus => cus).ToList(); // using lambda here to order the customer names of each customer, which is easier/quicker to do here than writing a function elsewhere
                foreach (var customer in customers)
                {
                    reportTextBox.Text += $"{customer.customerName}'s Appointments:\n";

                    var appointmentList = dbContext.appointments.Where(app => app.customerId == customer.customerId).OrderBy(app => app.start).ToList(); // using lambda here to select appointments where the appointments match the customer ID and sort them by start time, which is easier/quicker than writing a function elsewhere

                    reportTextBox.Text += $"\t{"Consultant",-15}\t{"Start",-35}\t\t{"End",-30}\n";

                    foreach (var appointment in appointmentList)
                    {
                        reportTextBox.Text += $"\t{appointment.user.userName,-15}\t{(appointment.start).ToLocalTime(),-35}\t{(appointment.end).ToLocalTime(),-30}\n";
                    }

                    reportTextBox.Text += "\n";
                }
            }
        }

        // closeButton_Click
        //      executes when the button is clicked and closes this form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace SchedulingSoftware
{
    public partial class Appointments : Form
    {
        // Entity Framework DbContext
        private Scheduling_Software_C969.U08aMCEntities dbcontext = new Scheduling_Software_C969.U08aMCEntities();
        
        // constructor
        public Appointments()
        {
            InitializeComponent();
        }

        // Appointments_Load
        //      calls loadAllAppointments when form loads
        private void Appointments_Load(object sender, EventArgs e)
        {
            loadAllAppointments();
            
        }

        // addAppointmentButton_Click
        //      opens the addAppointment form
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            var addAppointment = new addAppointment();
            addAppointment.Show();
        }

        // modifyDeleteButton_Click
        //      calls the loadModifyDeleteForm function
        private void modifyDeleteButton_Click(object sender, EventArgs e)
        {
            loadModifyDeleteForm();   
        }


        // loadModifyDeleteForm
        //      opens the modify and delete appointments page
        private void loadModifyDeleteForm()
        {
            if (appointmentGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit or delete", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var appointmentID = (int)appointmentGrid.SelectedRows[0].Cells[0].Value;
            
            // switch the Application form to appointments
            var modifyOrDeleteForm = new ModifyAndDeleteAppointment(appointmentID);
            modifyOrDeleteForm.Show();
        }

        // filterDateButton_Click
        //      filters the dates according to what is selected
        private void filterDateButton_Click(object sender, EventArgs e)
        {

            {
                filterDateCalendar.RemoveAllBoldedDates();

                // filter by month if selected
                if (monthAppointmentRadioButton.Checked)
                {
                    filterByMonth();
                }
                // if the month isn't checked, sort the selected week
                else if(weekAppointmentsRadioButton.Checked)
                {
                    filterByWeek();
                }
                else
                {
                    filterDateCalendar.BoldedDates = null;
                    loadAllAppointments();
                }
            }
        }

        // loadAllAppointments
        //      fills the calendar with all the appointments
        private void loadAllAppointments()
        {
            //dbcontext.appointments.OrderBy(app => app.appointmentId).Load(); // easier to sort on the spot using lambda than to create a seperate function or write a full function

            var namesToIDs = from appointment in dbcontext.appointments
                             join customer in dbcontext.customers on appointment.customerId equals customer.customerId
                             join user in dbcontext.users on appointment.userId equals user.userId
                             select new
                             {
                                 appointment.appointmentId,
                                 customer.customerName,
                                 user.userName,
                                 appointment.type,
                                 appointment.start,
                                 appointment.end,
                                 appointment.createDate,
                                 appointment.createdBy,
                                 appointment.lastUpdate,
                                 appointment.lastUpdateBy
                             };

            var loadingData = namesToIDs.OrderBy(record => record.start).ToList(); // easier to use lambda here and order the data on the spot rather than creating a function somewhere else

            // convert data values to local time
            var updatedData = loadingData.Select(item => new //easiest to select and convert everything using lambda while it's iterating through the list of data rather than create a seperate function somewhere else
            {
                item.appointmentId,
                item.customerName,
                item.userName,
                item.type,
                start = item.start.ToLocalTime(),
                end = item.end.ToLocalTime(),
                createDate = item.createDate.ToLocalTime(),
                item.createdBy,
                lastUpdate = item.lastUpdate.ToLocalTime(),
                item.lastUpdateBy
            })
                .ToList();



            appointmentGrid.DataSource = updatedData;

            appointmentBindingSource.DataSource = updatedData;
        }

        // filterByMonth
        //      filters the calendar to show only the dates within the selcted month
        private void filterByMonth()
        {
            var tempMonth = filterDateCalendar.SelectionRange.Start.Month;
            var tempYear = filterDateCalendar.SelectionRange.Start.Year;
            int tempEndDay = 0;

            string startDate = tempMonth.ToString() + "/01/" + tempYear.ToString();
            DateTime tempStartDate = Convert.ToDateTime(startDate);

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
            DateTime tempEndDate = Convert.ToDateTime(endDate);

            tempStartDate = tempStartDate.ToUniversalTime();
            tempEndDate = tempEndDate.AddDays(1).ToUniversalTime();


            dbcontext.appointments.OrderBy(app => app.start).Load(); // easier to sort on the spot using lambda than to create a seperate function or write a full function

            //var selections = dbcontext.appointments.SqlQuery("Select * from appointment").ToList();

            var namesToIDs = from appointment in dbcontext.appointments
                             join customer in dbcontext.customers on appointment.customerId equals customer.customerId
                             join user in dbcontext.users on appointment.userId equals user.userId
                             select new
                             {
                                 appointment.appointmentId,
                                 customer.customerName,
                                 user.userName,
                                 appointment.type,
                                 appointment.start,
                                 appointment.end,
                                 appointment.createDate,
                                 appointment.createdBy,
                                 appointment.lastUpdate,
                                 appointment.lastUpdateBy
                             };

            var loadingData = namesToIDs.Where(record => record.start >= tempStartDate && record.end <= tempEndDate).OrderBy(record => record.start).ToList(); // easier to use lambda here and order the data on the spot rather than creating a function somewhere else

            // convert data values to local time
            var updatedData = loadingData.Select(item => new //easiest to select and convert everything using lambda while it's iterating through the list of data rather than create a seperate function somewhere else
            {
                item.appointmentId,
                item.customerName,
                item.userName,
                item.type,
                start = item.start.ToLocalTime(),
                end = item.end.ToLocalTime(),
                createDate = item.createDate.ToLocalTime(),
                item.createdBy,
                lastUpdate = item.lastUpdate.ToLocalTime(),
                item.lastUpdateBy
            })
                .ToList();

            // convert back to local for selecting and sorting
            tempStartDate = tempStartDate.ToLocalTime();
            tempEndDate = tempEndDate.ToLocalTime();

            var filteredData = updatedData.Where(item => item.start >= tempStartDate && item.start < tempEndDate).Select(item => item).ToList(); // I can use lambda here to select what I need on the spot rather than write an entire function

            appointmentGrid.DataSource = filteredData;

            appointmentBindingSource.DataSource = filteredData;
        }

        // filterByWeek
        //      filters the calendar to show only the dates within the selcted week
        private void filterByWeek()
        {
            var tempDayOfWeek = filterDateCalendar.SelectionStart.DayOfWeek;
            var tempYear = filterDateCalendar.SelectionRange.Start.Year;

            int tempDay = filterDateCalendar.SelectionStart.Day;
            int tempMonth = filterDateCalendar.SelectionStart.Month;

            int tempStartDay = 0;

            string startDate;

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

            dbcontext.appointments.OrderBy(app => app.start).Load(); // easier to sort on the spot using lambda than to create a seperate function or write a full function

            //var selections = dbcontext.appointments.SqlQuery("Select * from appointment").ToList();

            var namesToIDs = from appointment in dbcontext.appointments
                             join customer in dbcontext.customers on appointment.customerId equals customer.customerId
                             join user in dbcontext.users on appointment.userId equals user.userId
                             select new
                             {
                                 appointment.appointmentId,
                                 customer.customerName,
                                 user.userName,
                                 appointment.type,
                                 appointment.start,
                                 appointment.end,
                                 appointment.createDate,
                                 appointment.createdBy,
                                 appointment.lastUpdate,
                                 appointment.lastUpdateBy
                             };

            var loadingData = namesToIDs.OrderBy(record => record.start).ToList(); // easier to use lambda here and order the data on the spot rather than creating a function somewhere else

            // convert data values to local time
            var updatedData = loadingData.Select(item => new //easiest to select and convert everything using lambda while it's iterating through the list of data rather than create a seperate function somewhere else
            {
                item.appointmentId,
                item.customerName,
                item.userName,
                item.type,
                start = item.start.ToLocalTime(),
                end = item.end.ToLocalTime(),
                createDate = item.createDate.ToLocalTime(),
                item.createdBy,
                lastUpdate = item.lastUpdate.ToLocalTime(),
                item.lastUpdateBy
            })
                .ToList();

            var filteredData = updatedData.Where(item => item.start >= tempStartDate && item.start <= tempEndDate).Select(item => item).ToList();  // using lambda here is quicker and easier to write on the spot than creating a whole function on it's own


            appointmentGrid.DataSource = filteredData;

            appointmentBindingSource.DataSource = filteredData;
        }

        // customersButton_Click
        //      opens the customers form
        private void customersButton_Click(object sender, EventArgs e)
        {
            Customers customersForm = new Customers(this);
            customersForm.Show();
        }

        // exitButton_Click
        //      exits this form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // reportsButton_click
        //      opens the reports button
        private void reportsButton_Click(object sender, EventArgs e)
        {
            Reports reportForm = new Reports();
            reportForm.Show();
        }
    }
}

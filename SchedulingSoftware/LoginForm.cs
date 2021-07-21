using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.IO;
using System.Data.Entity;
using System.Data.Entity.Validation;
using MySql.Data.EntityFramework;
using MySql.Data;
using System.Configuration;

namespace SchedulingSoftware
{
    public partial class LoginForm : Form
    {
        // Geographical and Cultural info for translation
        public static CultureInfo culture = CultureInfo.CurrentCulture;
        public static RegionInfo region = RegionInfo.CurrentRegion;

        // StreamWriter for tracking login in data into a text file
        private StreamWriter fileWriter;
        readonly string filename = "logins.txt";
        FileStream stream;

        // Where error text info is stored for validation instructions
        private string errorText;

        Scheduling_Software_C969.U08aMCEntities dbContext = new Scheduling_Software_C969.U08aMCEntities();

        public LoginForm()
        {
            InitializeComponent();

            stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fileWriter = new StreamWriter(stream);
        }

        // LoginScreen_Load
        //      executes when form loads, detects culture and changes language if needed
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            Console.WriteLine("The current culture is {0} [{1}]",
                        culture.NativeName, culture.Name);
            Console.WriteLine("The current region is {0} [{1}]", region.NativeName, region.Name);
            
            // if spanish is spoken, change to spanish
            if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
            {
                titleLabel.Text = "Software de Programación";
                loginBox.Text = "Acceso";
                usernameLabel.Text = "Nombre de Usuario";
                passwordLabel.Text = "Contraseña";
            }
        }

        // submitButton_Click
        //      calls the logIn function
        private void submitButton_Click(object sender, EventArgs e)
        {
            logIn();
        }

        // logIn
        //      displays in English or Spanish depending on the region and checks and validates the username and password before giving the user access
        private void logIn()
        {
            bool error = false;
            errorText = "";
            usernameTextBox.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;

            // check to see if text boxes are filled out
            if (incompleteEntry())
            {
                MessageBox.Show(errorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check input for correctness
            if (usernameTextBox.Text.ToLower() != "test")
            {
                error = true;
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "El nombre de usuario que ingresaste es incorrecto, inténtalo de nuevo.\n";
                }
                else
                {
                    errorText += "The username that was entered is incorrect, please try again.\n";
                }

                usernameTextBox.BackColor = Color.LightSalmon;
            }
            if (passwordTextBox.Text.ToLower() != "test")
            {
                error = true;
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "La contraseña que ingresó es incorrecta, inténtelo de nuevo.\n";
                }
                else
                {
                    errorText += "The passord that was entered is incorrect, please try again.\n";
                }

                passwordTextBox.BackColor = Color.LightSalmon;
            }
            if (usernameTextBox.Text.ToLower() != passwordTextBox.Text.ToLower())
            {
                error = true;
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "El nombre de usuario y la contraseña no coinciden, inténtelo de nuevo.\n";
                }
                else
                {
                    errorText += "The username and password do not match, please try again.\n";
                }
            }

            if (error)
            {
                MessageBox.Show(errorText, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // write unsuccessful login attempt to file
                try
                {
                    stream.Seek(0, SeekOrigin.End);
                    fileWriter.WriteLine($"Username: {usernameTextBox.Text} -- {DateTime.Now} -- Unsuccessful");
                    fileWriter.Flush();
                }
                catch
                {
                    MessageBox.Show("Error opening or writing to login file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            // write successful log in attempt to file
            try
            {
                stream.Seek(0, SeekOrigin.End);
                fileWriter.WriteLine($"Username: {usernameTextBox.Text} -- {DateTime.Now} -- Successful");
                fileWriter?.Close(); // close the file
            }
            catch
            {
                MessageBox.Show("Error opening or writing to login file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // obtain all the appointments to alert the user if there is an appointment within 15 minutes
            var namesToIDs = from appointment in dbContext.appointments
                             join customer in dbContext.customers on appointment.customerId equals customer.customerId
                             join user in dbContext.users on appointment.userId equals user.userId
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

            // convert data values to local time and take the ones that are still in the future

            var updatedData = loadingData.Where(item => item.start >= DateTime.UtcNow).Select(item => new //easiest to select and convert everything using lambda while it's iterating through the list of data rather than create a seperate function somewhere else
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

            foreach (var appointment in updatedData)
            {

                if (DateTime.Now.TimeOfDay - appointment.start.TimeOfDay <= TimeSpan.FromMinutes(15) && appointment.start.Date == DateTime.Now.Date)
                {
                    MessageBox.Show($"You have an appointment scheduled with {appointment.customerName} at {appointment.start.ToString("hh:mm tt")}.\n\n", "Appointment Alert\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            // switch the Application form to appointments
            Appointments appointmentsPage = new Appointments();
            Program.MyAppCxt.MainForm = appointmentsPage;
            appointmentsPage.Show();
            this.Close();
        }

        // incompleteEntry
        //      checks to see if any of the text box fields are missing information
        private bool incompleteEntry()
        {
            bool incomplete = false;

            if (usernameTextBox.Text.Length == 0)
            {
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "Por favor, especifique un nombre de usuario.\n";
                }
                else
                {
                    errorText += "Please specify a username.\n";
                }

                usernameTextBox.BackColor = Color.LightSalmon;
                incomplete = true;
            }
            if (passwordTextBox.Text.Length == 0)
            {
                if (culture.Name.StartsWith("es") || region.Name.StartsWith("es"))
                {
                    errorText += "Por favor especifique una contraseña.\n";
                }
                else
                {
                    errorText += "Please specify a password.\n";
                }
                passwordTextBox.BackColor = Color.LightSalmon;
                incomplete = true;
            }

            return incomplete;
        }

        // LoginForm_KeyDown
        //      if 'Enter' is pressed, it calls the logIn function
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logIn();
            }
        }
    }
}

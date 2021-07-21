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
    public partial class ModifyDeleteCustomer : Form
    {
        // create access to Entities
        Scheduling_Software_C969.U08aMCEntities dbContext = new Scheduling_Software_C969.U08aMCEntities();

        // used to capture the form that generated this form
        Customers previousForm;

        // used to regenerate the main form
        Appointments mainForm;

        // constructor
        public ModifyDeleteCustomer(Appointments mainPreviousForm, Customers cameFromForm, int customerID)
        {
            InitializeComponent();                 
         
            previousForm = cameFromForm;
            mainForm = mainPreviousForm;
            
            // set customer ID field
            
            customerIdTextBox.Text = customerID.ToString();
            
            var customerFields = dbContext.customers.OrderBy(customer => customer.customerName); // easier to use lamba here to order records on the spot than create a seperate function elsewhere
            var addressFields = dbContext.addresses.OrderBy(address => address.address1); // easier to use lamba here to order records on the spot than create a seperate function elsewhere
            var cityFields = dbContext.cities.OrderBy(city => city.city1); // easier to use lamba here to order records on the spot than create a seperate function elsewhere
            var countryFields = dbContext.countries.OrderBy(country => country.country1); // easier to use lamba here to order records on the spot than create a seperate function elsewhere

            // load auto completes for the different fields
            foreach (var field in addressFields)
            {
                addressTextBox.AutoCompleteCustomSource.Add(field.address1);
                address2TextBox.AutoCompleteCustomSource.Add(field.address2);
                postalCodeTextBox.AutoCompleteCustomSource.Add(field.postalCode);
                phoneTextBox.AutoCompleteCustomSource.Add(field.phone);
            }
            
            foreach (var field in cityFields)
            {
                city1TextBox.AutoCompleteCustomSource.Add(field.city1);
            }
            
            foreach (var field in countryFields)
            {
                countryTextBox.AutoCompleteCustomSource.Add(field.country1);
            }

            // load customer info into the form
            foreach (var field in customerFields)
            {
                if (field.customerId == customerID)
                {
                    customerNameTextBox.Text = field.customerName;
                    addressIdTextBox1.Text = field.addressId.ToString();
                    addressTextBox.Text = field.address.address1;
                    address2TextBox.Text = field.address.address2;
                    city1TextBox.Text = field.address.city.city1;
                    cityIdTextBox.Text = field.address.cityId.ToString();
                    postalCodeTextBox.Text = field.address.postalCode;
                    phoneTextBox.Text = field.address.phone;
                    countryTextBox.Text = field.address.city.country.country1;
                    countryIdTextBox.Text = field.address.city.countryId.ToString();
                    createdByComboBox.Text = field.createdBy;
                }
            }
        
        }

        // findIDs
        //      looks to see if the information added matches ID's that are already in the system, if so, sets the text boxes in each ID field to the
        //      corresponding ID.
        private void findIDs()
        {
            var customerFields = dbContext.customers.OrderBy(customer => customer.customerName).ToList(); // easier to use lamba here to order records on the spot than create a seperate function elsewhere
            var addressFields = dbContext.addresses.OrderBy(address => address.address1); // easier to use lamba here to order records on the spot than create a seperate function elsewhere
            var cityFields = dbContext.cities.OrderBy(city => city.city1); // easier to use lamba here to order records on the spot than create a seperate function elsewhere
            var countryFields = dbContext.countries.OrderBy(country => country.country1); // easier to use lamba here to order records on the spot than create a seperate function elsewhere

            countryIdTextBox.Text = "";
            cityIdTextBox.Text = "";
            addressIdTextBox1.Text = "";

            bool addressFound = false;
            bool address2Found = false;
            bool cityFound = false;
            bool postalFound = false;
            bool phoneFound = false;

            // search the country Table for a matching country
            foreach (var field in countryFields)
            {
                if (field.country1 == countryTextBox.Text)
                {
                    countryIdTextBox.Text = field.countryId.ToString();
                }
            }

            // search the city Table for a matching city
            foreach (var field in cityFields)
            {
                if (field.city1 == city1TextBox.Text && field.country.country1 == countryTextBox.Text)
                {
                    cityIdTextBox.Text = field.cityId.ToString();
                }
            }

            // search the address table for a matching address
            foreach (var field in addressFields)
            {
                if (field.address1 == addressTextBox.Text)
                {
                    addressFound = true;
                }
                if (field.address2 == address2TextBox.Text)
                {
                    address2Found = true;
                }
                if (field.postalCode == postalCodeTextBox.Text)
                {
                    postalFound = true;
                }
                if (field.phone == phoneTextBox.Text)
                {
                    phoneFound = true;
                }
                if (field.city.city1 == city1TextBox.Text)
                {
                    cityFound = true;
                }
                if (cityFound && phoneFound && postalFound && address2Found && addressFound && field.city.city1 == city1TextBox.Text && field.city.country.country1 == countryTextBox.Text)
                {
                    addressIdTextBox1.Text = field.addressId.ToString();
                }

            }


        }

        // AddNewCustomer_Load
        //      executes when form is loaded... code is commented out for now because it is not needed
        private void AddNewCustomer_Load(object sender, EventArgs e)
        {

            /*// TODO: This line of code loads data into the 'u08aMCDataSet.country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.u08aMCDataSet.country);
            // TODO: This line of code loads data into the 'u08aMCDataSet.country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.u08aMCDataSet.country);
            // TODO: This line of code loads data into the 'u08aMCDataSet.address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.u08aMCDataSet.address);
            // TODO: This line of code loads data into the 'u08aMCDataSet.address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.u08aMCDataSet.address);
            // TODO: This line of code loads data into the 'u08aMCDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.u08aMCDataSet.customer);*/

        }

        // saveButton_Click
        //      adds the customer to the database
        private void saveButton_Click(object sender, EventArgs e)
        {
            // finds any ID's that match this record
            findIDs();

            // reset the asterisks
            nameAsterisk.ForeColor = Color.Black;
            addressAsterisk.ForeColor = Color.Black;
            cityAsterisk.ForeColor = Color.Black;
            postalCodeAsterisk.ForeColor = Color.Black;
            phoneAsterisk.ForeColor = Color.Black;
            countryAsterisk.ForeColor = Color.Black;
            createdAsterisk.ForeColor = Color.Black;


            // field validation
            bool errorFound = false;
            string errorMessage = "";

            if (customerNameTextBox.Text == "")
            {
                errorFound = true;
                errorMessage += "Please fill out the customer name.\n";
                nameAsterisk.ForeColor = Color.Red;
            }
            if (addressTextBox.Text == "")
            {
                errorFound = true;
                errorMessage += "Please fill out an address.\n";
                addressAsterisk.ForeColor = Color.Red;
            }
            if (city1TextBox.Text == "")
            {
                errorFound = true;
                errorMessage += "Please fill out the city section.\n";
                cityAsterisk.ForeColor = Color.Red;
            }
            if (postalCodeTextBox.Text == "")
            {
                errorFound = true;
                errorMessage += "Please fill out the postal code section.\n";
                postalCodeAsterisk.ForeColor = Color.Red;
            }
            if (phoneTextBox.Text == "")
            {
                errorFound = true;
                errorMessage += "Please fill out the phone section.\n";
                phoneAsterisk.ForeColor = Color.Red;
            }
            if (countryTextBox.Text == "")
            {
                errorFound = true;
                errorMessage += "Please fill out the country section.\n";
                countryAsterisk.ForeColor = Color.Red;
            }
            if (createdByComboBox.Text == "")
            {
                errorFound = true;
                errorMessage += "Please indicate who is creating this customer record.\n";
                createdAsterisk.ForeColor = Color.Red;
            }
            // commented out because you can have non-numeric postal codes
            /*try
            {
                int.Parse(postalCodeTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter in numeric characters [0-9] for the postal code.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                postalCodeAsterisk.ForeColor = Color.Red;
                errorFound = true;
            }*/
            if (errorFound)
            {
                MessageBox.Show(errorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            // if still here insert data
            int tempCustomerId = int.Parse(customerIdTextBox.Text);
            var modifiedCustomer = dbContext.customers.SingleOrDefault(customer => customer.customerId == tempCustomerId);
            

            if (addressIdTextBox1.Text != "")
            {
                // if ID's are found, just simply insert the new customer information
                try
                {
                    modifiedCustomer.customerName = customerNameTextBox.Text;
                    modifiedCustomer.addressId = int.Parse(addressIdTextBox1.Text);
                    modifiedCustomer.active = activeCheckBox.Checked;
                    modifiedCustomer.lastUpdateBy = createdByComboBox.Text;
                    modifiedCustomer.lastUpdate = DateTime.UtcNow;

                    string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();
                    // SQL command
                    string SQLstring = $"UPDATE customer SET customerName = '{modifiedCustomer.customerName}', addressId = {modifiedCustomer.addressId}, active = {modifiedCustomer.active}, lastUpdateBy = '{modifiedCustomer.lastUpdateBy}', lastUpdate = '{modifiedCustomer.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE customerId = {modifiedCustomer.customerId}; ";

                    MySqlCommand command = new MySqlCommand(SQLstring, con);
                    MySqlDataReader sqlDataReader;
                    sqlDataReader = command.ExecuteReader();

                    con.Close();

                    // reload previous form and close this one
                    Customers customersForm = new Customers(mainForm);
                    previousForm.Close();
                    customersForm.Show();
                    this.Close();


                }
                catch
                {
                    MessageBox.Show("Failed to insert new customer", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // if ID's are not found, insert new countries, cities, or addresses to their respective tables before adding a new customer
                int newCountryId = -1;
                int newCityId = -1;
                int newAddressId = -1;

                if (countryIdTextBox.Text == "")
                {

                    try
                    {
                        // add new country to country table
                        var countryToAdd = new Scheduling_Software_C969.country
                        {
                            country1 = countryTextBox.Text,
                            createDate = DateTime.UtcNow,
                            createdBy = createdByComboBox.Text,
                            lastUpdate = DateTime.UtcNow,
                            lastUpdateBy = createdByComboBox.Text
                        };

                        dbContext.countries.Add(countryToAdd);
                        dbContext.SaveChanges();

                        newCountryId = dbContext.countries.Where(country => country.country1 == countryTextBox.Text).Select(country => country.countryId).First(); // easier and quicker to use lambdas here instead of creating seperate functions to find specific records or select specific items
                    }
                    catch
                    {
                        MessageBox.Show("Unable to add country, and therefore the customer record to the database.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    newCountryId = int.Parse(countryIdTextBox.Text);
                }
                if (cityIdTextBox.Text == "")
                {
                    // add new city to city table
                    var cityToAdd = new Scheduling_Software_C969.city
                    {
                        city1 = city1TextBox.Text,
                        countryId = newCountryId,
                        createDate = DateTime.UtcNow,
                        createdBy = createdByComboBox.Text,
                        lastUpdate = DateTime.UtcNow,
                        lastUpdateBy = createdByComboBox.Text
                    };

                    try
                    {
                        dbContext.cities.Add(cityToAdd);
                        dbContext.SaveChanges();

                        newCityId = dbContext.cities.Where(city => city.city1 == city1TextBox.Text).Select(city => city.cityId).First(); // easier and quicker to use lambdas here instead of creating seperate functions to find specific records or select specific items
                    }
                    catch
                    {
                        MessageBox.Show("Unable to add city, and therefore the customer record to the database.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    newCityId = int.Parse(cityIdTextBox.Text);
                }

                // add new address to address table
                var addressToAdd = new Scheduling_Software_C969.address
                {
                    address1 = addressTextBox.Text,
                    address2 = address2TextBox.Text,
                    cityId = newCityId,
                    postalCode = postalCodeTextBox.Text,
                    phone = phoneTextBox.Text,
                    createDate = DateTime.UtcNow,
                    createdBy = createdByComboBox.Text,
                    lastUpdate = DateTime.UtcNow,
                    lastUpdateBy = createdByComboBox.Text
                };
                try
                {
                    dbContext.addresses.Add(addressToAdd);
                    dbContext.SaveChanges();

                    newAddressId = dbContext.addresses.Where(address => address.address1 == addressTextBox.Text).Select(address => address.addressId).First(); // easier and quicker to use lambdas here instead of creating seperate functions to find specific records or select specific items
                }
                catch
                {
                    MessageBox.Show("Unable to add address, and therefore the customer record to the database.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // update the customer
                var customerModified = new Scheduling_Software_C969.customer
                {
                    customerName = customerNameTextBox.Text,
                    addressId = newAddressId,
                    active = activeCheckBox.Checked,
                    createDate = DateTime.UtcNow,
                    createdBy = createdByComboBox.Text,
                    lastUpdate = DateTime.UtcNow,
                    lastUpdateBy = createdByComboBox.Text
                };
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();
                    // SQL command
                    string SQLstring = $"UPDATE customer SET customerName = '{customerModified.customerName}', addressId = {customerModified.addressId}, active = {customerModified.active}, lastUpdateBy = '{customerModified.lastUpdateBy}', lastUpdate = '{customerModified.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE customerId = {modifiedCustomer.customerId}; ";

                    MySqlCommand command = new MySqlCommand(SQLstring, con);
                    MySqlDataReader sqlDataReader;
                    sqlDataReader = command.ExecuteReader();

                    con.Close();
                                        
                }
                catch
                {
                    MessageBox.Show("Unable to add customer.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // reload previous form and close this one
                Customers customersForm = new Customers(mainForm);
                previousForm.Close();
                customersForm.Show();
                this.Close();
            }
        }

        // cancelButton_Click
        //      closes this form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // deleteButton_Click
        //      deletes the customer from the customer table
        //      will also delete all appointments that are associated with the customer if given the "OK"
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int tempCustomerId = int.Parse(customerIdTextBox.Text);

                    string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();

                    // SQL command
                    string SQLstring = $"DELETE FROM customer WHERE customerId = {tempCustomerId}; ";

                    MySqlCommand command = new MySqlCommand(SQLstring, con);
                    MySqlDataReader sqlDataReader;
                    sqlDataReader = command.ExecuteReader();

                    con.Close();                                      

                    Customers customersForm = new Customers(mainForm);
                    previousForm.Close();
                    customersForm.Show();
                    this.Close();
                    return;
                }
                catch
                {
                    
                }
                result = MessageBox.Show("There is at least one appointment associated with this customer (foreign key).\n\nDeleting this customer will also delete all of their associated appointments.\n\nIs this OK?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    int tempCustomerId = int.Parse(customerIdTextBox.Text);

                    string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(connectionString);


                    // SQL command to delete all associate appointments
                    con.Open();
                    string SQLstring = $"DELETE FROM appointment WHERE customerId = {tempCustomerId}; ";
                    MySqlCommand command = new MySqlCommand(SQLstring, con);
                    MySqlDataReader sqlDataReader;
                    sqlDataReader = command.ExecuteReader();
                    con.Close();

                    // SQL command to delete customer
                    con.Open();
                    SQLstring = $"DELETE FROM customer WHERE customerId = {tempCustomerId}; ";
                    command = new MySqlCommand(SQLstring, con);
                    sqlDataReader = command.ExecuteReader();
                    con.Close();

                    // reload previous form, and main form, and close this one
                    Appointments appointmentsPage = new Appointments();
                    var currentMain = Program.MyAppCxt.MainForm;
                    Program.MyAppCxt.MainForm = appointmentsPage;
                    currentMain.Close();
                    appointmentsPage.Show();

                    Customers customersForm = new Customers(appointmentsPage);
                    previousForm.Close();
                    customersForm.Show();
                    this.Close();

                }
            }
        }
    }
}

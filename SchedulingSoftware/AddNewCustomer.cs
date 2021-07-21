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
    public partial class AddNewCustomer : Form
    {
        // create access to Entities
        Scheduling_Software_C969.U08aMCEntities dbContext = new Scheduling_Software_C969.U08aMCEntities();

        // used to capture the form that generated this form
        Customers previousForm;
        Appointments mainForm;

        // constructor
        public AddNewCustomer(Appointments originalAppointmentForm, Customers cameFromForm)
        {
            InitializeComponent();

            previousForm = cameFromForm;
            mainForm = originalAppointmentForm;

            // set customer ID field
            string sqlQuery = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'U08aMC' AND TABLE_NAME = 'customer'";
            string connectionString = ConfigurationManager.ConnectionStrings["SchedulingSoftware.Properties.Settings.U08aMCConnectionString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand command = new MySqlCommand(sqlQuery, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable nextID = new DataTable();
            adapter.Fill(nextID);
            customerIdTextBox.Text = nextID.Rows[0][0].ToString();

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
        }


        // customerBindingNavigatorSaveItem_Click
        //      left here just for reference
        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.u08aMCDataSet);

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
            if (addressIdTextBox1.Text != "")
            {
                // if ID's are found, just simply insert the new customer information
                try
                {
                    var customerToAdd = new Scheduling_Software_C969.customer
                    {
                        customerName = customerNameTextBox.Text,
                        addressId = int.Parse(addressIdTextBox1.Text),
                        active = activeCheckBox.Checked,
                        createdBy = createdByComboBox.Text,
                        createDate = DateTime.UtcNow,
                        lastUpdateBy = createdByComboBox.Text,
                        lastUpdate = DateTime.UtcNow,
                    };

                    dbContext.customers.Add(customerToAdd);
                    dbContext.SaveChanges();

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

                // insert the customer
                var customerToAdd = new Scheduling_Software_C969.customer
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
                    dbContext.customers.Add(customerToAdd);
                    dbContext.SaveChanges();
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
    }
}

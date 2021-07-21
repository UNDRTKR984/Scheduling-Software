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
    public partial class Customers : Form
    {
        Scheduling_Software_C969.U08aMCEntities dbContext = new Scheduling_Software_C969.U08aMCEntities();
        Appointments mainForm;
        public Customers(Appointments mainAppointmentsForm)
        {
            InitializeComponent();
            mainForm = mainAppointmentsForm;
        }

        // kept here in case I want to use it later
        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.u08aMCDataSet);

        }

        // Customers_Load
        //      executes when the form loads... gets all the customers and places them into the data grid
        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u08aMCDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.u08aMCDataSet.customer);

            
            // query by joining tables
            var data =
                from customer in dbContext.customers
                join address in dbContext.addresses on customer.addressId equals address.addressId
                join city in dbContext.cities on address.cityId equals city.cityId
                join country in dbContext.countries on city.countryId equals country.countryId
                select new
                {
                    Name = customer.customerName,
                    CustomerId = customer.customerId,
                    Address = address.address1,
                    Address2 = address.address2,
                    City = city.city1,
                    Zip = address.postalCode,
                    Country = country.country1,
                    Phone = address.phone,
                    CreatedBy = customer.createdBy,
                    CreateDate = customer.createDate,
                    LastUpdateBy = customer.lastUpdateBy,
                    LastUpdated = customer.lastUpdate,
                    AddressID = customer.addressId
                };

            // get data ready to load and sotr customer names
            var loadingData = data.OrderBy(customer => customer.Name).ToList(); // using lambda here to sort the customers by name on the spots rather than create a seperate function elsewhere
            var updatedData = loadingData.Select(cus => new  // using lambda to convert the times to local, can do this on the spot rather than create a function somewhere else
            {
                cus.Name,
                cus.CustomerId,
                cus.Address,
                cus.Address2,
                cus.City,
                cus.Zip,
                cus.Country,
                cus.Phone,
                cus.CreatedBy,
                CreateDate = cus.CreateDate.ToLocalTime(),
                cus.LastUpdateBy,
                LateUpdated = cus.LastUpdated.ToLocalTime(),
                cus.AddressID
            }).ToList();

            dataGridView1.DataSource = updatedData;            


            /* dbContext.customer
            .Join(
            dbContext.address,
            customer => customer.addressId,
            address => address.addressId,
            (customer, address) => new
            {
                CustomerId = customer.customerId,
                Name = customer.customerName,
                Address = address.address,
                CityID = address.cityId
            }).Select(customer => new { CustomerID = customer.CustomerId, Name = customer.Name, Address = customer.Address, CityID = customer.CityID })
            .Join(
            dbContext.city,
            address => address.CityID,
            city => city.cityId,
            (address, city) => new
            {
                City = city.city,
                CountryID = city.countryId
            }).Select(address => new { City = address.City, CountryID = address.CountryID })
            .Join(
            dbContext.country,
            city => city.CountryID,
            country => country.countryId,
            (city, country) => new
            {
                Country = country.country
            }).Select(country => country).ToList();*/




        }

        // addNewCustomerButton_Click
        //      opens up the new customer form
        private void addNewCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer(mainForm, this);
            addNewCustomer.Show();
            
        }

        // goBackCloseButton_Click
        //      closes this form
        private void goBackCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // modifyDeleteCustomerButton_Click
        //      opens the modifyDeleteCustomer form
        private void modifyDeleteCustomerButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            var data =
                from customer in dbContext.customers
                join address in dbContext.addresses on customer.addressId equals address.addressId
                join city in dbContext.cities on address.cityId equals city.cityId
                join country in dbContext.countries on city.countryId equals country.countryId
                select new
                {
                    Name = customer.customerName,
                    CustomerId = customer.customerId,
                    Address = address.address1,
                    Address2 = address.address2,
                    City = city.city1,
                    Zip = address.postalCode,
                    Country = country.country1,
                    Phone = address.phone,
                    CreatedBy = customer.createdBy,
                    CreateDate = customer.createDate,
                    LastUpdateBy = customer.lastUpdateBy,
                    LastUpdated = customer.lastUpdate,
                    AddressID = customer.addressId
                };

            var loadingData = data.OrderBy(customer => customer.Name).ToList();
            var updatedData = loadingData.Select(cus => new
            {
                cus.Name,
                cus.CustomerId,
                cus.Address,
                cus.Address2,
                cus.City,
                cus.Zip,
                cus.Country,
                cus.Phone,
                cus.CreatedBy,
                CreateDate = cus.CreateDate.ToLocalTime(),
                cus.LastUpdateBy,
                LateUpdated = cus.LastUpdated.ToLocalTime(),
                cus.AddressID
            }).ToList();

            var customerRecord = updatedData[selectedIndex];

            ModifyDeleteCustomer modifyCustomer = new ModifyDeleteCustomer(mainForm, this, customerRecord.CustomerId);
            modifyCustomer.Show();
        }
    }
}

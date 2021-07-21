
namespace SchedulingSoftware
{
    partial class AddNewCustomer
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
            System.Windows.Forms.Label addressIdLabel1;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityIdLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label countryIdLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label city1Label;
            this.u08aMCDataSet = new SchedulingSoftware.U08aMCDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new SchedulingSoftware.U08aMCDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new SchedulingSoftware.U08aMCDataSetTableAdapters.TableAdapterManager();
            this.addressTableAdapter = new SchedulingSoftware.U08aMCDataSetTableAdapters.addressTableAdapter();
            this.countryTableAdapter = new SchedulingSoftware.U08aMCDataSetTableAdapters.countryTableAdapter();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressIdTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityIdTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryIdTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.createdByComboBox = new System.Windows.Forms.ComboBox();
            this.city1TextBox = new System.Windows.Forms.TextBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.nameAsterisk = new System.Windows.Forms.Label();
            this.createdByAsterisk = new System.Windows.Forms.Label();
            this.addressAsterisk = new System.Windows.Forms.Label();
            this.cityAsterisk = new System.Windows.Forms.Label();
            this.postalCodeAsterisk = new System.Windows.Forms.Label();
            this.phoneAsterisk = new System.Windows.Forms.Label();
            this.countryAsterisk = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createdAsterisk = new System.Windows.Forms.Label();
            addressIdLabel1 = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityIdLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            countryIdLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            city1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.u08aMCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressIdLabel1
            // 
            addressIdLabel1.AutoSize = true;
            addressIdLabel1.Location = new System.Drawing.Point(129, 9);
            addressIdLabel1.Name = "addressIdLabel1";
            addressIdLabel1.Size = new System.Drawing.Size(78, 17);
            addressIdLabel1.TabIndex = 17;
            addressIdLabel1.Text = "address Id:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(24, 153);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 17);
            addressLabel.TabIndex = 19;
            addressLabel.Text = "address:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(24, 181);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(71, 17);
            address2Label.TabIndex = 21;
            address2Label.Text = "address2:";
            // 
            // cityIdLabel
            // 
            cityIdLabel.AutoSize = true;
            cityIdLabel.Location = new System.Drawing.Point(249, 9);
            cityIdLabel.Name = "cityIdLabel";
            cityIdLabel.Size = new System.Drawing.Size(48, 17);
            cityIdLabel.TabIndex = 23;
            cityIdLabel.Text = "city Id:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(24, 237);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(87, 17);
            postalCodeLabel.TabIndex = 25;
            postalCodeLabel.Text = "postal Code:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(24, 265);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 17);
            phoneLabel.TabIndex = 27;
            phoneLabel.Text = "phone:";
            // 
            // countryIdLabel
            // 
            countryIdLabel.AutoSize = true;
            countryIdLabel.Location = new System.Drawing.Point(339, 9);
            countryIdLabel.Name = "countryIdLabel";
            countryIdLabel.Size = new System.Drawing.Size(74, 17);
            countryIdLabel.TabIndex = 37;
            countryIdLabel.Text = "country Id:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(24, 299);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(59, 17);
            countryLabel.TabIndex = 39;
            countryLabel.Text = "country:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(2, 9);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(85, 17);
            customerIdLabel.TabIndex = 48;
            customerIdLabel.Text = "customer Id:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(24, 76);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(111, 17);
            customerNameLabel.TabIndex = 50;
            customerNameLabel.Text = "customer Name:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(24, 102);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(49, 17);
            activeLabel.TabIndex = 54;
            activeLabel.Text = "active:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(24, 417);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(80, 17);
            createdByLabel.TabIndex = 58;
            createdByLabel.Text = "created By:";
            // 
            // city1Label
            // 
            city1Label.AutoSize = true;
            city1Label.Location = new System.Drawing.Point(24, 209);
            city1Label.Name = "city1Label";
            city1Label.Size = new System.Drawing.Size(33, 17);
            city1Label.TabIndex = 63;
            city1Label.Text = "city:";
            // 
            // u08aMCDataSet
            // 
            this.u08aMCDataSet.DataSetName = "U08aMCDataSet";
            this.u08aMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u08aMCDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = this.addressTableAdapter;
            this.tableAdapterManager.appointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = this.countryTableAdapter;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = SchedulingSoftware.U08aMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.u08aMCDataSet;
            // 
            // addressIdTextBox1
            // 
            this.addressIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "addressId", true));
            this.addressIdTextBox1.Enabled = false;
            this.addressIdTextBox1.Location = new System.Drawing.Point(213, 6);
            this.addressIdTextBox1.Name = "addressIdTextBox1";
            this.addressIdTextBox1.Size = new System.Drawing.Size(30, 22);
            this.addressIdTextBox1.TabIndex = 18;
            // 
            // addressTextBox
            // 
            this.addressTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(140, 150);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(271, 22);
            this.addressTextBox.TabIndex = 2;
            // 
            // address2TextBox
            // 
            this.address2TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.address2TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(140, 178);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(271, 22);
            this.address2TextBox.TabIndex = 3;
            // 
            // cityIdTextBox
            // 
            this.cityIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "cityId", true));
            this.cityIdTextBox.Enabled = false;
            this.cityIdTextBox.Location = new System.Drawing.Point(303, 6);
            this.cityIdTextBox.Name = "cityIdTextBox";
            this.cityIdTextBox.Size = new System.Drawing.Size(30, 22);
            this.cityIdTextBox.TabIndex = 24;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.postalCodeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "postalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(140, 234);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(271, 22);
            this.postalCodeTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.phoneTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(140, 262);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(271, 22);
            this.phoneTextBox.TabIndex = 6;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.u08aMCDataSet;
            // 
            // countryIdTextBox
            // 
            this.countryIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "countryId", true));
            this.countryIdTextBox.Enabled = false;
            this.countryIdTextBox.Location = new System.Drawing.Point(419, 6);
            this.countryIdTextBox.Name = "countryIdTextBox";
            this.countryIdTextBox.Size = new System.Drawing.Size(30, 22);
            this.countryIdTextBox.TabIndex = 38;
            // 
            // countryTextBox
            // 
            this.countryTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.countryTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(140, 290);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(271, 22);
            this.countryTextBox.TabIndex = 7;
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerId", true));
            this.customerIdTextBox.Enabled = false;
            this.customerIdTextBox.Location = new System.Drawing.Point(93, 6);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(30, 22);
            this.customerIdTextBox.TabIndex = 49;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(141, 73);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(270, 22);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.Checked = true;
            this.activeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customerBindingSource, "active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(141, 97);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(270, 24);
            this.activeCheckBox.TabIndex = 55;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // createdByComboBox
            // 
            this.createdByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "createdBy", true));
            this.createdByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createdByComboBox.FormattingEnabled = true;
            this.createdByComboBox.Items.AddRange(new object[] {
            "test"});
            this.createdByComboBox.Location = new System.Drawing.Point(141, 414);
            this.createdByComboBox.Name = "createdByComboBox";
            this.createdByComboBox.Size = new System.Drawing.Size(271, 24);
            this.createdByComboBox.TabIndex = 8;
            // 
            // city1TextBox
            // 
            this.city1TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.city1TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.city1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "city1", true));
            this.city1TextBox.Location = new System.Drawing.Point(140, 206);
            this.city1TextBox.Name = "city1TextBox";
            this.city1TextBox.Size = new System.Drawing.Size(271, 22);
            this.city1TextBox.TabIndex = 4;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(Scheduling_Software_C969.city);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(161, 523);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 75);
            this.saveButton.TabIndex = 65;
            this.saveButton.Text = "Add Customer";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameAsterisk
            // 
            this.nameAsterisk.AutoSize = true;
            this.nameAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAsterisk.Location = new System.Drawing.Point(418, 74);
            this.nameAsterisk.Name = "nameAsterisk";
            this.nameAsterisk.Size = new System.Drawing.Size(14, 17);
            this.nameAsterisk.TabIndex = 66;
            this.nameAsterisk.Text = "*";
            // 
            // createdByAsterisk
            // 
            this.createdByAsterisk.AutoSize = true;
            this.createdByAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByAsterisk.Location = new System.Drawing.Point(1395, 381);
            this.createdByAsterisk.Name = "createdByAsterisk";
            this.createdByAsterisk.Size = new System.Drawing.Size(14, 17);
            this.createdByAsterisk.TabIndex = 67;
            this.createdByAsterisk.Text = "*";
            // 
            // addressAsterisk
            // 
            this.addressAsterisk.AutoSize = true;
            this.addressAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressAsterisk.Location = new System.Drawing.Point(418, 150);
            this.addressAsterisk.Name = "addressAsterisk";
            this.addressAsterisk.Size = new System.Drawing.Size(14, 17);
            this.addressAsterisk.TabIndex = 68;
            this.addressAsterisk.Text = "*";
            // 
            // cityAsterisk
            // 
            this.cityAsterisk.AutoSize = true;
            this.cityAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityAsterisk.Location = new System.Drawing.Point(418, 206);
            this.cityAsterisk.Name = "cityAsterisk";
            this.cityAsterisk.Size = new System.Drawing.Size(14, 17);
            this.cityAsterisk.TabIndex = 69;
            this.cityAsterisk.Text = "*";
            // 
            // postalCodeAsterisk
            // 
            this.postalCodeAsterisk.AutoSize = true;
            this.postalCodeAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeAsterisk.Location = new System.Drawing.Point(418, 234);
            this.postalCodeAsterisk.Name = "postalCodeAsterisk";
            this.postalCodeAsterisk.Size = new System.Drawing.Size(14, 17);
            this.postalCodeAsterisk.TabIndex = 70;
            this.postalCodeAsterisk.Text = "*";
            // 
            // phoneAsterisk
            // 
            this.phoneAsterisk.AutoSize = true;
            this.phoneAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneAsterisk.Location = new System.Drawing.Point(418, 262);
            this.phoneAsterisk.Name = "phoneAsterisk";
            this.phoneAsterisk.Size = new System.Drawing.Size(14, 17);
            this.phoneAsterisk.TabIndex = 71;
            this.phoneAsterisk.Text = "*";
            // 
            // countryAsterisk
            // 
            this.countryAsterisk.AutoSize = true;
            this.countryAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryAsterisk.Location = new System.Drawing.Point(418, 290);
            this.countryAsterisk.Name = "countryAsterisk";
            this.countryAsterisk.Size = new System.Drawing.Size(14, 17);
            this.countryAsterisk.TabIndex = 72;
            this.countryAsterisk.Text = "*";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(356, 523);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(189, 75);
            this.cancelButton.TabIndex = 73;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createdAsterisk
            // 
            this.createdAsterisk.AutoSize = true;
            this.createdAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdAsterisk.Location = new System.Drawing.Point(418, 414);
            this.createdAsterisk.Name = "createdAsterisk";
            this.createdAsterisk.Size = new System.Drawing.Size(14, 17);
            this.createdAsterisk.TabIndex = 74;
            this.createdAsterisk.Text = "*";
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 610);
            this.Controls.Add(this.createdAsterisk);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.countryAsterisk);
            this.Controls.Add(this.phoneAsterisk);
            this.Controls.Add(this.postalCodeAsterisk);
            this.Controls.Add(this.cityAsterisk);
            this.Controls.Add(this.addressAsterisk);
            this.Controls.Add(this.createdByAsterisk);
            this.Controls.Add(this.nameAsterisk);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(city1Label);
            this.Controls.Add(this.city1TextBox);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.createdByComboBox);
            this.Controls.Add(countryIdLabel);
            this.Controls.Add(this.countryIdTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(addressIdLabel1);
            this.Controls.Add(this.addressIdTextBox1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(cityIdLabel);
            this.Controls.Add(this.cityIdTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Name = "AddNewCustomer";
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.AddNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.u08aMCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private U08aMCDataSet u08aMCDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U08aMCDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private U08aMCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private U08aMCDataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.TextBox addressIdTextBox1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityIdTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private U08aMCDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.TextBox countryIdTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.ComboBox createdByComboBox;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.TextBox city1TextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameAsterisk;
        private System.Windows.Forms.Label createdByAsterisk;
        private System.Windows.Forms.Label addressAsterisk;
        private System.Windows.Forms.Label cityAsterisk;
        private System.Windows.Forms.Label postalCodeAsterisk;
        private System.Windows.Forms.Label phoneAsterisk;
        private System.Windows.Forms.Label countryAsterisk;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label createdAsterisk;
    }
}
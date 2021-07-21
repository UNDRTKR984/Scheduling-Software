
namespace SchedulingSoftware
{
    partial class Customers
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
            this.u08aMCDataSet = new SchedulingSoftware.U08aMCDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new SchedulingSoftware.U08aMCDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new SchedulingSoftware.U08aMCDataSetTableAdapters.TableAdapterManager();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new SchedulingSoftware.U08aMCDataSetTableAdapters.cityTableAdapter();
            this.addNewCustomerButton = new System.Windows.Forms.Button();
            this.modifyDeleteCustomerButton = new System.Windows.Forms.Button();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.u08aMCEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goBackCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.u08aMCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u08aMCEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.appointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = SchedulingSoftware.U08aMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.u08aMCDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // addNewCustomerButton
            // 
            this.addNewCustomerButton.Location = new System.Drawing.Point(9, 345);
            this.addNewCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNewCustomerButton.Name = "addNewCustomerButton";
            this.addNewCustomerButton.Size = new System.Drawing.Size(142, 62);
            this.addNewCustomerButton.TabIndex = 2;
            this.addNewCustomerButton.Text = "Add New Customer";
            this.addNewCustomerButton.UseVisualStyleBackColor = true;
            this.addNewCustomerButton.Click += new System.EventHandler(this.addNewCustomerButton_Click);
            // 
            // modifyDeleteCustomerButton
            // 
            this.modifyDeleteCustomerButton.Location = new System.Drawing.Point(156, 345);
            this.modifyDeleteCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyDeleteCustomerButton.Name = "modifyDeleteCustomerButton";
            this.modifyDeleteCustomerButton.Size = new System.Drawing.Size(142, 62);
            this.modifyDeleteCustomerButton.TabIndex = 3;
            this.modifyDeleteCustomerButton.Text = "Modify / Delete\r\nSelected Customer";
            this.modifyDeleteCustomerButton.UseVisualStyleBackColor = true;
            this.modifyDeleteCustomerButton.Click += new System.EventHandler(this.modifyDeleteCustomerButton_Click);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(Scheduling_Software_C969.customer);
            // 
            // u08aMCEntitiesBindingSource
            // 
            this.u08aMCEntitiesBindingSource.DataSource = typeof(Scheduling_Software_C969.U08aMCEntities);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 313);
            this.dataGridView1.TabIndex = 4;
            // 
            // goBackCloseButton
            // 
            this.goBackCloseButton.Location = new System.Drawing.Point(827, 345);
            this.goBackCloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goBackCloseButton.Name = "goBackCloseButton";
            this.goBackCloseButton.Size = new System.Drawing.Size(142, 62);
            this.goBackCloseButton.TabIndex = 5;
            this.goBackCloseButton.Text = "Close";
            this.goBackCloseButton.UseVisualStyleBackColor = true;
            this.goBackCloseButton.Click += new System.EventHandler(this.goBackCloseButton_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 457);
            this.Controls.Add(this.goBackCloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modifyDeleteCustomerButton);
            this.Controls.Add(this.addNewCustomerButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.u08aMCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u08aMCEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private U08aMCDataSet u08aMCDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U08aMCDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private U08aMCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private U08aMCDataSetTableAdapters.cityTableAdapter cityTableAdapter;
        private System.Windows.Forms.Button addNewCustomerButton;
        private System.Windows.Forms.Button modifyDeleteCustomerButton;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource u08aMCEntitiesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goBackCloseButton;
    }
}
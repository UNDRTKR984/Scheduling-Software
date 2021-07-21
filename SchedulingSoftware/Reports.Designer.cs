
namespace SchedulingSoftware
{
    partial class Reports
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
            this.reportTextBox = new System.Windows.Forms.RichTextBox();
            this.appointmentTypesRadioButton = new System.Windows.Forms.RadioButton();
            this.eachConsultantRadioButton = new System.Windows.Forms.RadioButton();
            this.eachCustomerRadioButton = new System.Windows.Forms.RadioButton();
            this.runReportButton = new System.Windows.Forms.Button();
            this.reportViewerLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportTextBox
            // 
            this.reportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTextBox.Location = new System.Drawing.Point(12, 29);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.Size = new System.Drawing.Size(671, 326);
            this.reportTextBox.TabIndex = 0;
            this.reportTextBox.Text = "";
            // 
            // appointmentTypesRadioButton
            // 
            this.appointmentTypesRadioButton.AutoSize = true;
            this.appointmentTypesRadioButton.Location = new System.Drawing.Point(80, 392);
            this.appointmentTypesRadioButton.Name = "appointmentTypesRadioButton";
            this.appointmentTypesRadioButton.Size = new System.Drawing.Size(214, 21);
            this.appointmentTypesRadioButton.TabIndex = 1;
            this.appointmentTypesRadioButton.TabStop = true;
            this.appointmentTypesRadioButton.Text = "Appointment Types By Month";
            this.appointmentTypesRadioButton.UseVisualStyleBackColor = true;
            // 
            // eachConsultantRadioButton
            // 
            this.eachConsultantRadioButton.AutoSize = true;
            this.eachConsultantRadioButton.Location = new System.Drawing.Point(80, 419);
            this.eachConsultantRadioButton.Name = "eachConsultantRadioButton";
            this.eachConsultantRadioButton.Size = new System.Drawing.Size(216, 21);
            this.eachConsultantRadioButton.TabIndex = 2;
            this.eachConsultantRadioButton.TabStop = true;
            this.eachConsultantRadioButton.Text = "Schedule for Each Consultant";
            this.eachConsultantRadioButton.UseVisualStyleBackColor = true;
            // 
            // eachCustomerRadioButton
            // 
            this.eachCustomerRadioButton.AutoSize = true;
            this.eachCustomerRadioButton.Location = new System.Drawing.Point(80, 446);
            this.eachCustomerRadioButton.Name = "eachCustomerRadioButton";
            this.eachCustomerRadioButton.Size = new System.Drawing.Size(209, 21);
            this.eachCustomerRadioButton.TabIndex = 3;
            this.eachCustomerRadioButton.TabStop = true;
            this.eachCustomerRadioButton.Text = "Schedule for Each Customer";
            this.eachCustomerRadioButton.UseVisualStyleBackColor = true;
            // 
            // runReportButton
            // 
            this.runReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runReportButton.Location = new System.Drawing.Point(366, 396);
            this.runReportButton.Name = "runReportButton";
            this.runReportButton.Size = new System.Drawing.Size(247, 66);
            this.runReportButton.TabIndex = 4;
            this.runReportButton.Text = "Run Report";
            this.runReportButton.UseVisualStyleBackColor = true;
            this.runReportButton.Click += new System.EventHandler(this.runReportButton_Click);
            // 
            // reportViewerLabel
            // 
            this.reportViewerLabel.AutoSize = true;
            this.reportViewerLabel.Location = new System.Drawing.Point(12, 6);
            this.reportViewerLabel.Name = "reportViewerLabel";
            this.reportViewerLabel.Size = new System.Drawing.Size(97, 17);
            this.reportViewerLabel.TabIndex = 5;
            this.reportViewerLabel.Text = "Report Viewer";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(559, 506);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(124, 43);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reportViewerLabel);
            this.Controls.Add(this.runReportButton);
            this.Controls.Add(this.eachCustomerRadioButton);
            this.Controls.Add(this.eachConsultantRadioButton);
            this.Controls.Add(this.appointmentTypesRadioButton);
            this.Controls.Add(this.reportTextBox);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox reportTextBox;
        private System.Windows.Forms.RadioButton appointmentTypesRadioButton;
        private System.Windows.Forms.RadioButton eachConsultantRadioButton;
        private System.Windows.Forms.RadioButton eachCustomerRadioButton;
        private System.Windows.Forms.Button runReportButton;
        private System.Windows.Forms.Label reportViewerLabel;
        private System.Windows.Forms.Button closeButton;
    }
}
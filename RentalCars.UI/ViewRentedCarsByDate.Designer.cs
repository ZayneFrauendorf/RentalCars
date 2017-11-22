namespace RentalCars.UI
{
    partial class ViewRentedCarsByDate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.SearchBetweenDates = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.currentCustomerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodystyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNGINENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wOFDueAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateItRentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDueBackInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currentCustomerNameDataGridViewTextBoxColumn,
            this.Brand,
            this.CarModel,
            this.statusDataGridViewTextBoxColumn,
            this.bodystyleDataGridViewTextBoxColumn,
            this.registrationDueDateDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.eNGINENUMBERDataGridViewTextBoxColumn,
            this.wOFDueAtDataGridViewTextBoxColumn,
            this.dateItRentsDataGridViewTextBoxColumn,
            this.dateDueBackInDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1137, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(RentalCars.Car);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date From: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date To: ";
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker.Location = new System.Drawing.Point(62, 2);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(100, 20);
            this.dateFromPicker.TabIndex = 3;
            // 
            // dateToPicker
            // 
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker.Location = new System.Drawing.Point(220, 2);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(100, 20);
            this.dateToPicker.TabIndex = 4;
            // 
            // SearchBetweenDates
            // 
            this.SearchBetweenDates.Location = new System.Drawing.Point(335, 1);
            this.SearchBetweenDates.Name = "SearchBetweenDates";
            this.SearchBetweenDates.Size = new System.Drawing.Size(75, 23);
            this.SearchBetweenDates.TabIndex = 5;
            this.SearchBetweenDates.Text = "Search";
            this.SearchBetweenDates.UseVisualStyleBackColor = true;
            this.SearchBetweenDates.Click += new System.EventHandler(this.SearchBetweenDates_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(1076, 226);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // currentCustomerNameDataGridViewTextBoxColumn
            // 
            this.currentCustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CurrentCustomerName";
            this.currentCustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.currentCustomerNameDataGridViewTextBoxColumn.Name = "currentCustomerNameDataGridViewTextBoxColumn";
            this.currentCustomerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.HeaderText = "CarModel";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodystyleDataGridViewTextBoxColumn
            // 
            this.bodystyleDataGridViewTextBoxColumn.DataPropertyName = "Bodystyle";
            this.bodystyleDataGridViewTextBoxColumn.HeaderText = "Body Style";
            this.bodystyleDataGridViewTextBoxColumn.Name = "bodystyleDataGridViewTextBoxColumn";
            this.bodystyleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationDueDateDataGridViewTextBoxColumn
            // 
            this.registrationDueDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDueDate";
            this.registrationDueDateDataGridViewTextBoxColumn.HeaderText = "Reg Due Date";
            this.registrationDueDateDataGridViewTextBoxColumn.Name = "registrationDueDateDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNGINENUMBERDataGridViewTextBoxColumn
            // 
            this.eNGINENUMBERDataGridViewTextBoxColumn.DataPropertyName = "ENGINENUMBER";
            this.eNGINENUMBERDataGridViewTextBoxColumn.HeaderText = "Engine Number";
            this.eNGINENUMBERDataGridViewTextBoxColumn.Name = "eNGINENUMBERDataGridViewTextBoxColumn";
            this.eNGINENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wOFDueAtDataGridViewTextBoxColumn
            // 
            this.wOFDueAtDataGridViewTextBoxColumn.DataPropertyName = "WOFDueAt";
            this.wOFDueAtDataGridViewTextBoxColumn.HeaderText = "WOF Due";
            this.wOFDueAtDataGridViewTextBoxColumn.Name = "wOFDueAtDataGridViewTextBoxColumn";
            // 
            // dateItRentsDataGridViewTextBoxColumn
            // 
            this.dateItRentsDataGridViewTextBoxColumn.DataPropertyName = "DateItRents";
            this.dateItRentsDataGridViewTextBoxColumn.HeaderText = "Date Rented";
            this.dateItRentsDataGridViewTextBoxColumn.Name = "dateItRentsDataGridViewTextBoxColumn";
            this.dateItRentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDueBackInDataGridViewTextBoxColumn
            // 
            this.dateDueBackInDataGridViewTextBoxColumn.DataPropertyName = "DateDueBackIn";
            this.dateDueBackInDataGridViewTextBoxColumn.HeaderText = "Date Due";
            this.dateDueBackInDataGridViewTextBoxColumn.Name = "dateDueBackInDataGridViewTextBoxColumn";
            this.dateDueBackInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewRentedCarsByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 261);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.SearchBetweenDates);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewRentedCarsByDate";
            this.Text = "ViewRentedCarsByDate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Button SearchBetweenDates;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCustomerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodystyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNGINENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wOFDueAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateItRentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDueBackInDataGridViewTextBoxColumn;
    }
}
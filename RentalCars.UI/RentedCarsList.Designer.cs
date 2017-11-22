namespace RentalCars.UI
{
   public partial class RentedCarsList
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENGINENUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WOFDueAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodystyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentCustomerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodystyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateItRentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDueBackInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNGINENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wOFDueAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Brand,
            this.CarModel,
            this.Status,
            this.Bodystyle,
            this.RegistrationDueDate,
            this.Colour,
            this.ENGINENUMBER,
            this.WOFDueAt,
            this.currentCustomerNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.bodystyleDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.carModelDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.registrationDueDateDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.dateItRentsDataGridViewTextBoxColumn,
            this.dateDueBackInDataGridViewTextBoxColumn,
            this.eNGINENUMBERDataGridViewTextBoxColumn,
            this.wOFDueAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(771, 194);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.CarModel.HeaderText = "Car Model";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // RegistrationDueDate
            // 
            this.RegistrationDueDate.DataPropertyName = "RegistrationDueDate";
            this.RegistrationDueDate.HeaderText = "Reg Due Date";
            this.RegistrationDueDate.Name = "RegistrationDueDate";
            // 
            // Colour
            // 
            this.Colour.DataPropertyName = "Colour";
            this.Colour.HeaderText = "Colour";
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            // 
            // ENGINENUMBER
            // 
            this.ENGINENUMBER.DataPropertyName = "ENGINENUMBER";
            this.ENGINENUMBER.HeaderText = "Engine Number";
            this.ENGINENUMBER.Name = "ENGINENUMBER";
            this.ENGINENUMBER.ReadOnly = true;
            // 
            // WOFDueAt
            // 
            this.WOFDueAt.DataPropertyName = "WOFDueAt";
            this.WOFDueAt.HeaderText = "WOF Due Date";
            this.WOFDueAt.Name = "WOFDueAt";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Bodystyle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Body Style";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Bodystyle
            // 
            this.Bodystyle.DataPropertyName = "Bodystyle";
            this.Bodystyle.HeaderText = "Body Style";
            this.Bodystyle.Name = "Bodystyle";
            this.Bodystyle.ReadOnly = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(RentalCars.Car);
            // 
            // currentCustomerNameDataGridViewTextBoxColumn
            // 
            this.currentCustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CurrentCustomerName";
            this.currentCustomerNameDataGridViewTextBoxColumn.HeaderText = "CurrentCustomerName";
            this.currentCustomerNameDataGridViewTextBoxColumn.Name = "currentCustomerNameDataGridViewTextBoxColumn";
            this.currentCustomerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bodystyleDataGridViewTextBoxColumn
            // 
            this.bodystyleDataGridViewTextBoxColumn.DataPropertyName = "Bodystyle";
            this.bodystyleDataGridViewTextBoxColumn.HeaderText = "Bodystyle";
            this.bodystyleDataGridViewTextBoxColumn.Name = "bodystyleDataGridViewTextBoxColumn";
            this.bodystyleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "CarModel";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            this.carModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationDueDateDataGridViewTextBoxColumn
            // 
            this.registrationDueDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDueDate";
            this.registrationDueDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDueDate";
            this.registrationDueDateDataGridViewTextBoxColumn.Name = "registrationDueDateDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateItRentsDataGridViewTextBoxColumn
            // 
            this.dateItRentsDataGridViewTextBoxColumn.DataPropertyName = "DateItRents";
            this.dateItRentsDataGridViewTextBoxColumn.HeaderText = "DateItRents";
            this.dateItRentsDataGridViewTextBoxColumn.Name = "dateItRentsDataGridViewTextBoxColumn";
            this.dateItRentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDueBackInDataGridViewTextBoxColumn
            // 
            this.dateDueBackInDataGridViewTextBoxColumn.DataPropertyName = "DateDueBackIn";
            this.dateDueBackInDataGridViewTextBoxColumn.HeaderText = "DateDueBackIn";
            this.dateDueBackInDataGridViewTextBoxColumn.Name = "dateDueBackInDataGridViewTextBoxColumn";
            this.dateDueBackInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNGINENUMBERDataGridViewTextBoxColumn
            // 
            this.eNGINENUMBERDataGridViewTextBoxColumn.DataPropertyName = "ENGINENUMBER";
            this.eNGINENUMBERDataGridViewTextBoxColumn.HeaderText = "ENGINENUMBER";
            this.eNGINENUMBERDataGridViewTextBoxColumn.Name = "eNGINENUMBERDataGridViewTextBoxColumn";
            this.eNGINENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wOFDueAtDataGridViewTextBoxColumn
            // 
            this.wOFDueAtDataGridViewTextBoxColumn.DataPropertyName = "WOFDueAt";
            this.wOFDueAtDataGridViewTextBoxColumn.HeaderText = "WOFDueAt";
            this.wOFDueAtDataGridViewTextBoxColumn.Name = "wOFDueAtDataGridViewTextBoxColumn";
            // 
            // RentedCarsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 261);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RentedCarsList";
            this.Text = "List of Rented Cars";
            this.Load += new System.EventHandler(this.RentedCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodystyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENGINENUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn WOFDueAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCustomerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodystyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateItRentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDueBackInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNGINENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wOFDueAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
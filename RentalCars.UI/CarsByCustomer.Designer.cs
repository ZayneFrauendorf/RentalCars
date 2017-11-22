namespace RentalCars.UI
{
    partial class CarsByCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.DataGridViewCarsByCustomer = new System.Windows.Forms.DataGridView();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCarsByCustomer = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CurrentCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodystyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENGINENUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WOFDueAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarsByCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname/Family Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(125, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // DataGridViewCarsByCustomer
            // 
            this.DataGridViewCarsByCustomer.AllowUserToAddRows = false;
            this.DataGridViewCarsByCustomer.AllowUserToDeleteRows = false;
            this.DataGridViewCarsByCustomer.AutoGenerateColumns = false;
            this.DataGridViewCarsByCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCarsByCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrentCustomerName,
            this.Brand,
            this.CarModel,
            this.Status,
            this.Bodystyle,
            this.RegistrationDueDate,
            this.Colour,
            this.ENGINENUMBER,
            this.WOFDueAt});
            this.DataGridViewCarsByCustomer.DataSource = this.carBindingSource;
            this.DataGridViewCarsByCustomer.Location = new System.Drawing.Point(2, 31);
            this.DataGridViewCarsByCustomer.Name = "DataGridViewCarsByCustomer";
            this.DataGridViewCarsByCustomer.Size = new System.Drawing.Size(938, 172);
            this.DataGridViewCarsByCustomer.TabIndex = 2;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(RentalCars.Car);
            // 
            // BtnCarsByCustomer
            // 
            this.BtnCarsByCustomer.Location = new System.Drawing.Point(242, 3);
            this.BtnCarsByCustomer.Name = "BtnCarsByCustomer";
            this.BtnCarsByCustomer.Size = new System.Drawing.Size(100, 20);
            this.BtnCarsByCustomer.TabIndex = 3;
            this.BtnCarsByCustomer.Text = "Search";
            this.BtnCarsByCustomer.UseVisualStyleBackColor = true;
            this.BtnCarsByCustomer.Click += new System.EventHandler(this.BtnCarsByCustomer_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(865, 209);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CurrentCustomerName
            // 
            this.CurrentCustomerName.DataPropertyName = "CurrentCustomerName";
            this.CurrentCustomerName.HeaderText = "Customer Name";
            this.CurrentCustomerName.Name = "CurrentCustomerName";
            this.CurrentCustomerName.ReadOnly = true;
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
            // CarsByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 261);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCarsByCustomer);
            this.Controls.Add(this.DataGridViewCarsByCustomer);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Name = "CarsByCustomer";
            this.Text = "Search Cars By Customer";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarsByCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DataGridView DataGridViewCarsByCustomer;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Button BtnCarsByCustomer;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodystyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENGINENUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn WOFDueAt;
    }
}
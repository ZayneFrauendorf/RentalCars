namespace RentalCars.UI
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListAvailableCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListRentedCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListAllCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsByCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsByBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsByCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RentedCarsByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OverdueCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeCustomerInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAndUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAndUpdateEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByDOBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.rentalToolStripMenuItem,
            this.employeeCustomerInterfaceToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewCarToolStripMenuItem,
            this.ListAvailableCarsToolStripMenuItem,
            this.ListRentedCarsToolStripMenuItem,
            this.ListAllCarsToolStripMenuItem,
            this.CarsByCategoryToolStripMenuItem,
            this.CarsByBrandToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // AddNewCarToolStripMenuItem
            // 
            this.AddNewCarToolStripMenuItem.Name = "AddNewCarToolStripMenuItem";
            this.AddNewCarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.AddNewCarToolStripMenuItem.Text = "Add new car...";
            this.AddNewCarToolStripMenuItem.Click += new System.EventHandler(this.AddNewCarToolStripMenuItem_Click);
            // 
            // ListAvailableCarsToolStripMenuItem
            // 
            this.ListAvailableCarsToolStripMenuItem.Name = "ListAvailableCarsToolStripMenuItem";
            this.ListAvailableCarsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ListAvailableCarsToolStripMenuItem.Text = "List Available Cars";
            this.ListAvailableCarsToolStripMenuItem.Click += new System.EventHandler(this.ListAvailableCarsToolStripMenuItem_Click);
            // 
            // ListRentedCarsToolStripMenuItem
            // 
            this.ListRentedCarsToolStripMenuItem.Name = "ListRentedCarsToolStripMenuItem";
            this.ListRentedCarsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ListRentedCarsToolStripMenuItem.Text = "List Rented Cars";
            this.ListRentedCarsToolStripMenuItem.Click += new System.EventHandler(this.ListRentedCarsToolStripMenuItem_Click);
            // 
            // ListAllCarsToolStripMenuItem
            // 
            this.ListAllCarsToolStripMenuItem.Name = "ListAllCarsToolStripMenuItem";
            this.ListAllCarsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ListAllCarsToolStripMenuItem.Text = "List All Cars";
            this.ListAllCarsToolStripMenuItem.Click += new System.EventHandler(this.ListAllCarsToolStripMenuItem_Click);
            // 
            // CarsByCategoryToolStripMenuItem
            // 
            this.CarsByCategoryToolStripMenuItem.Name = "CarsByCategoryToolStripMenuItem";
            this.CarsByCategoryToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.CarsByCategoryToolStripMenuItem.Text = "Cars By Category";
            this.CarsByCategoryToolStripMenuItem.Click += new System.EventHandler(this.CarsByCategoryToolStripMenuItem_Click);
            // 
            // CarsByBrandToolStripMenuItem
            // 
            this.CarsByBrandToolStripMenuItem.Name = "CarsByBrandToolStripMenuItem";
            this.CarsByBrandToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.CarsByBrandToolStripMenuItem.Text = "Cars By Brand";
            this.CarsByBrandToolStripMenuItem.Click += new System.EventHandler(this.CarsByBrandToolStripMenuItem_Click);
            // 
            // rentalToolStripMenuItem
            // 
            this.rentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarsByCustomerToolStripMenuItem,
            this.IssueCarsToolStripMenuItem,
            this.ReturnCarsToolStripMenuItem,
            this.RentedCarsByDateToolStripMenuItem,
            this.OverdueCarsToolStripMenuItem});
            this.rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            this.rentalToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.rentalToolStripMenuItem.Text = "Rental";
            // 
            // CarsByCustomerToolStripMenuItem
            // 
            this.CarsByCustomerToolStripMenuItem.Name = "CarsByCustomerToolStripMenuItem";
            this.CarsByCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CarsByCustomerToolStripMenuItem.Text = "Cars by Customer";
            this.CarsByCustomerToolStripMenuItem.Click += new System.EventHandler(this.CarsByCustomerToolStripMenuItem_Click);
            // 
            // IssueCarsToolStripMenuItem
            // 
            this.IssueCarsToolStripMenuItem.Name = "IssueCarsToolStripMenuItem";
            this.IssueCarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IssueCarsToolStripMenuItem.Text = "Issue Car(s)";
            this.IssueCarsToolStripMenuItem.Click += new System.EventHandler(this.IssueCarsToolStripMenuItem_Click);
            // 
            // ReturnCarsToolStripMenuItem
            // 
            this.ReturnCarsToolStripMenuItem.Name = "ReturnCarsToolStripMenuItem";
            this.ReturnCarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReturnCarsToolStripMenuItem.Text = "Return Car(s)";
            this.ReturnCarsToolStripMenuItem.Click += new System.EventHandler(this.ReturnCarsToolStripMenuItem_Click);
            // 
            // RentedCarsByDateToolStripMenuItem
            // 
            this.RentedCarsByDateToolStripMenuItem.Name = "RentedCarsByDateToolStripMenuItem";
            this.RentedCarsByDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RentedCarsByDateToolStripMenuItem.Text = "Rented Cars By Date";
            this.RentedCarsByDateToolStripMenuItem.Click += new System.EventHandler(this.RentedCarsByDateToolStripMenuItem_Click);
            // 
            // OverdueCarsToolStripMenuItem
            // 
            this.OverdueCarsToolStripMenuItem.Name = "OverdueCarsToolStripMenuItem";
            this.OverdueCarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OverdueCarsToolStripMenuItem.Text = "Overdue Cars";
            this.OverdueCarsToolStripMenuItem.Click += new System.EventHandler(this.OverdueCarsToolStripMenuItem_Click);
            // 
            // employeeCustomerInterfaceToolStripMenuItem
            // 
            this.employeeCustomerInterfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewAndUpdateToolStripMenuItem,
            this.ViewAndUpdateEmployeesToolStripMenuItem,
            this.AddEmployeeDetailsToolStripMenuItem,
            this.SearchByIDToolStripMenuItem,
            this.SearchByDOBToolStripMenuItem});
            this.employeeCustomerInterfaceToolStripMenuItem.Name = "employeeCustomerInterfaceToolStripMenuItem";
            this.employeeCustomerInterfaceToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.employeeCustomerInterfaceToolStripMenuItem.Text = "Human Hub";
            // 
            // ViewAndUpdateToolStripMenuItem
            // 
            this.ViewAndUpdateToolStripMenuItem.Name = "ViewAndUpdateToolStripMenuItem";
            this.ViewAndUpdateToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ViewAndUpdateToolStripMenuItem.Text = "View and Update Customer(s)";
            this.ViewAndUpdateToolStripMenuItem.Click += new System.EventHandler(this.ViewAndUpdateToolStripMenuItem_Click);
            // 
            // ViewAndUpdateEmployeesToolStripMenuItem
            // 
            this.ViewAndUpdateEmployeesToolStripMenuItem.Name = "ViewAndUpdateEmployeesToolStripMenuItem";
            this.ViewAndUpdateEmployeesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ViewAndUpdateEmployeesToolStripMenuItem.Text = "View and Update Employee(s)";
            this.ViewAndUpdateEmployeesToolStripMenuItem.Click += new System.EventHandler(this.ViewAndUpdateEmployeesToolStripMenuItem_Click);
            // 
            // AddEmployeeDetailsToolStripMenuItem
            // 
            this.AddEmployeeDetailsToolStripMenuItem.Name = "AddEmployeeDetailsToolStripMenuItem";
            this.AddEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.AddEmployeeDetailsToolStripMenuItem.Text = "Add Employee Details";
            this.AddEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeDetailsToolStripMenuItem_Click);
            // 
            // SearchByIDToolStripMenuItem
            // 
            this.SearchByIDToolStripMenuItem.Name = "SearchByIDToolStripMenuItem";
            this.SearchByIDToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.SearchByIDToolStripMenuItem.Text = "Search by ID";
            this.SearchByIDToolStripMenuItem.Click += new System.EventHandler(this.SearchByIDToolStripMenuItem_Click);
            // 
            // SearchByDOBToolStripMenuItem
            // 
            this.SearchByDOBToolStripMenuItem.Name = "SearchByDOBToolStripMenuItem";
            this.SearchByDOBToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.SearchByDOBToolStripMenuItem.Text = "Search by DOB";
            this.SearchByDOBToolStripMenuItem.Click += new System.EventHandler(this.SearchByDOBToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Rental Cars Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeCustomerInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListAvailableCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListRentedCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListAllCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarsByCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RentedCarsByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OverdueCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewAndUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewAndUpdateEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchByDOBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarsByCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarsByBrandToolStripMenuItem;
    }
}




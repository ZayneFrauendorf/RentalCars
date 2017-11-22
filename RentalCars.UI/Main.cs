namespace RentalCars.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        public Main()
        {
            this.InitializeComponent();
        }

        private void LaunchForm(Form form)
        {
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
        }

        private void ListAvailableCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new AvailableCarsList());
        }

        private void AddNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new CarEditor());
        }

        private void ListRentedCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new RentedCarsList());
        }

        private void ListAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new AllCarsList());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void CarsByCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new CarsByCustomer());
        }

        private void IssueCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new IssueCar());
        }

        private void RentedCarsByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new ViewRentedCarsByDate());
        }

        private void OverdueCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new OverdueCarsList());
        }

        private void ViewAndUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new ViewAndUpdateCustomers());
        }

        private void ViewAndUpdateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new ViewAndUpdateEmployee());
        }

        private void AddEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new EmployeeEditor());
        }

        private void SearchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new SearchPersonByID());
        }

        private void SearchByDOBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new SearchPersonByDateOfBirth());
        }

        private void ReturnCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new ReturnCar());
        }

        private void CarsByBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new CarsByBrand());
        }

        private void CarsByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LaunchForm(new CarsByCategory());
        }      
    }
}
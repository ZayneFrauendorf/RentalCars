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

    public partial class ReturnCar : Form
    {
        // Constructor
        public ReturnCar()
        {
            this.InitializeComponent();
            this.LoadEmployees();
            this.LoadCustomers();
            this.LoadRentedCars();
        }

        // Events
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            this.EmployeeReturnCar();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Methods
        private void LoadEmployees()
        {
            employeeCombo.Items.Clear();
            var employees = Employee.All();
            foreach (var employee in employees)
            {
                this.employeeCombo.Items.Add(employee);
            }
        }

        private void LoadCustomers()
        {
            customerCombo.Items.Clear();
            var customers = Customer.All();
            foreach (var customer in customers)
            {
                customerCombo.Items.Add(customer);
            }
        }

        private void LoadRentedCars()
        {
            this.rentedCarsCheck.Items.Clear();
            var cars = CarYard.Instance.GetRentedCars();
            foreach (var car in cars)
            {
                this.rentedCarsCheck.Items.Add(car);
            }
        }

        private void EmployeeReturnCar()
        {
            var employee = (Employee)employeeCombo.SelectedItem;
            if (employee == null)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            var customer = (Customer)customerCombo.SelectedItem;
            if (customer == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            var checkedCars = this.GetCheckedCars();
            if (checkedCars.Count() == 0)
            {
                MessageBox.Show("Please select an available car");
                return;
            }

            employee.ReturnCar(customer, checkedCars.ToArray());
            MessageBox.Show("Car(s) are now returned");
            this.Close();
        }

        private IEnumerable<Car> GetCheckedCars()
        {
            foreach (var item in this.rentedCarsCheck.SelectedItems)
            {
                yield return (Car)item;
            }
        }
    }
}

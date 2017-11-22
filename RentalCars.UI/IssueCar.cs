namespace RentalCars.UI
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class IssueCar : Form
    {
        // Constructor
        public IssueCar()
        {
            this.InitializeComponent();
            this.LoadEmployees();
            this.LoadCustomers();
            this.LoadAvailableCars();
        }

        // Events
        private void IssueCarbtn_Click(object sender, EventArgs e)
        {
            this.EmployeeIssueCar();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Methods
        private void LoadEmployees()
        {
            employeeDropDown.Items.Clear();
            var employees = Employee.All();
            foreach (var employee in employees)
            {
                employeeDropDown.Items.Add(employee);
            }
        }

        private void LoadCustomers()
        {
            customerDropDown.Items.Clear();
            var customers = Customer.All();
            foreach (var customer in customers)
            {
                customerDropDown.Items.Add(customer);
            }
        }

        private void LoadAvailableCars()
        {
            availableCarsCheckList.Items.Clear();
            var cars = CarYard.Instance.GetAvailableCars();
            foreach (var car in cars)
            {
                availableCarsCheckList.Items.Add(car);
            }
        }

        private void LoadList(ListControl control, IEnumerable list)
        {
           // Going to create a short way of doing things 
           // Too much repetition in my code
        }

        private void EmployeeIssueCar()
        {
            var employee = (Employee)employeeDropDown.SelectedItem;
            if (employee == null)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }     
                 
            var customer = (Customer)customerDropDown.SelectedItem;
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

            var duration = TimeSpan.FromDays(Convert.ToInt32(durationUpDown.Value));                     
            employee.IssueCar(customer, duration, checkedCars.ToArray());
            MessageBox.Show("Car(s) now issued.");
            this.Close();
        }

        private IEnumerable<Car> GetCheckedCars()
        {
            foreach (var item in availableCarsCheckList.SelectedItems)
            {
                yield return (Car)item;
            }
        }      
    }
}

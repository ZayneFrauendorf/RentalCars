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

    public partial class SearchPersonByDateOfBirth : Form
    {
        // Constructor
        public SearchPersonByDateOfBirth()
        {
            this.InitializeComponent();
        }

        // Events
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            personBindingSource.DataSource = null;
            var people = new List<Person>();
            List<Employee> employees = Employee.GetByDOB(datePickerDOB.Value);
            foreach (var employee in employees)
            {
                people.Add(employee);
            }

            List<Customer> customers = Customer.GetByDOB(datePickerDOB.Value);
            foreach (var customer in customers)
            {
                people.Add(customer);
            }

            personBindingSource.DataSource = people;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

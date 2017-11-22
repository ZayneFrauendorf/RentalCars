namespace RentalCars.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Net.Mime;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SearchPersonByID : Form
    {
        // Constructor
        public SearchPersonByID()
        {
            this.InitializeComponent();
        }

        // Events
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int checkForNegatives = Convert.ToInt32(this.textBox1.Text);
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) || checkForNegatives < 0)
            {
                MessageBox.Show("Please enter an appropriate value.");
                return;
            }

            var people = new List<Person>();
            var employee = Employee.Get(Convert.ToInt32(textBox1.Text));
            if (employee != null)
            {
                people.Add(employee);
            }

            var customer = Customer.Get(Convert.ToInt32(textBox1.Text));
            if (customer != null)
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

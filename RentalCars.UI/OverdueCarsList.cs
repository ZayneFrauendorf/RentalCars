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

    public partial class OverdueCarsList : Form
    {
        // Constructor
        public OverdueCarsList()
        {
            this.InitializeComponent();
        }

        // Events
        private void BtnSearchByCustomer_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method
        private void Search()
        {
            carBindingSource.DataSource = null;
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter a valid value");
                return;
            }

            var overdueCarsByCustomer = Customer.GetOverduedCars(txtCustomerName.Text);
            carBindingSource.DataSource = overdueCarsByCustomer;

            if (overdueCarsByCustomer.Count == 0)
            {
                MessageBox.Show("There are no overdue cars pertaining to that customer");
            }
        }
    }
}

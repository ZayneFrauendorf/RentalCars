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

    public partial class CarsByCustomer : Form
    {
        // Constructor
        public CarsByCustomer()
        {
            this.InitializeComponent();
        }
        
        // Events    
        private void BtnCarsByCustomer_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Please enter a valid value into the text box");
                return;
            }

            var carsByCustomer = Customer.GetRentedCarsByName(txtSurname.Text);
            carBindingSource.DataSource = carsByCustomer;

            if (carsByCustomer.Count == 0)
            {
                MessageBox.Show("Unfortunately there are no cars relating to that customer. This function sadly does not yet save between sessions, however if you go back and issue a car to your customer right now, it will show up :)");
            }
        }
    }
}

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

    public partial class CustomerEditor : Form
    {
        // Constructor
        public CustomerEditor()
        {
            this.InitializeComponent();
        }

        // Property
        public Customer CurrentCustomer { get; set; }

        // Events
        private void CustomerEditor_Load(object sender, EventArgs e)
        {
            if (this.CurrentCustomer == null)
            {
                return;
            }

            txtName.Text = this.CurrentCustomer.Name;
            txtName.Enabled = false;
            txtAddress.Text = this.CurrentCustomer.Address;
            txtTelNumber.Text = this.CurrentCustomer.TelephoneNumber;
            dateLicenseExpiryDate.Value = this.CurrentCustomer.LicenseExpiryDate;
            numAge.Enabled = false;
            txtLicenseNumber.Text = this.CurrentCustomer.LicenseNumber;
            txtLicenseNumber.Enabled = false;
            dateDateOfBirth.Value = this.CurrentCustomer.DateOfBirth;
            dateDateOfBirth.Enabled = false;                   
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            if (this.CurrentCustomer == null)
            {          
                    var id = Customer.All().Count() + 1;
                    var customer = new Customer(
                        id,
                        txtName.Text,
                        dateDateOfBirth.Value,
                        txtAddress.Text,
                        txtTelNumber.Text,
                        txtLicenseNumber.Text,
                        dateLicenseExpiryDate.Value);
                    Customer.Save(customer);                           
            }
            else
            {
                if (this.txtAddress.Text.Length <= 5)
                {
                    MessageBox.Show("Please enter valid address");
                    return;
                }

                    this.CurrentCustomer.Address = txtAddress.Text;

                if (this.txtTelNumber.Text.Length <= 5)
                {
                    MessageBox.Show("Please enter valid tel number");
                    return;
                }

                this.CurrentCustomer.TelephoneNumber = txtTelNumber.Text;
                    this.CurrentCustomer.LicenseExpiryDate = dateLicenseExpiryDate.Value;
            }

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

    public partial class ViewAndUpdateCustomers : Form
    {
        // Constructor
        public ViewAndUpdateCustomers()
        {
            this.InitializeComponent();
        }

        // Events
        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = Customer.All();
        }

        private void BtnCustbyID_Click(object sender, EventArgs e)
        {
            this.EditSelectedCustomer();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method
        private void EditSelectedCustomer()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var firstSelectedRow = dataGridView1.SelectedRows[0];
            var customer = (Customer)firstSelectedRow.DataBoundItem;
            using (var editor = new CustomerEditor() { CurrentCustomer = customer })
            {
                editor.ShowDialog();
                dataGridView1.Refresh();
            }
        }
    }
}

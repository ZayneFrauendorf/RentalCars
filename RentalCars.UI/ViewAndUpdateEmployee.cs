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

    public partial class ViewAndUpdateEmployee : Form
    {
        // Constructor
        public ViewAndUpdateEmployee()
        {
            this.InitializeComponent();
        }

        // Events
        private void ViewAndUpdateEmployee_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = Employee.All();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.EditEmployee();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Methods
        private void EditEmployee()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var firstSelectedRow = dataGridView1.SelectedRows[0];
            var employee = (Employee)firstSelectedRow.DataBoundItem;
            using (var editor = new EmployeeEditor()
            {
                CurrentEmployee = employee
            })
            {
                editor.ShowDialog();
            }         
        }   
    }
}

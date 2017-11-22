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

    public partial class EmployeeEditor : Form
    {
        // Constructor
        public EmployeeEditor()
        {
            this.InitializeComponent();
            this.LoadRoles();
        }

        // Property
        public Employee CurrentEmployee { get; set; }

        // Events
        private void EmployeeEditor_Load(object sender, EventArgs e)
        {
            if (this.CurrentEmployee == null)
            {
                return;
            }

            txtName.Text = this.CurrentEmployee.Name;
            txtName.Enabled = false;
            txtAddress.Text = this.CurrentEmployee.Address;
            txtTelNumber.Text = this.CurrentEmployee.TelephoneNumber;
            dateTimePicker1DOB.Value = this.CurrentEmployee.DateOfBirth;
            dateTimePicker1DOB.Enabled = false;
            txtUserName.Text = this.CurrentEmployee.UserName;
            txtUserName.Enabled = false;
            txtPassword.Text = this.CurrentEmployee.Password;
            txtOfficeAddress.Text = this.CurrentEmployee.OfficeAddress;
            txtExtensionNumber.Text = this.CurrentEmployee.ExtensionNumber.ToString();

            roleComboBox.SelectedIndex = -1;
            for (int i = 0; i < roleComboBox.Items.Count; i++)
            {
                if ((Role)roleComboBox.Items[i] == this.CurrentEmployee.Role)
                {
                    roleComboBox.SelectedIndex = i;
                    break;
                }
            }           
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtExtensionNumber.Text))
            {
                MessageBox.Show("Please enter a valid extension number.");
                return;
            }  
                   
            if (this.roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            if (this.CurrentEmployee == null)
            {
                try
                {
                    var id = Employee.All().Count() + 1;
                    var employee = new Employee(
                        id,
                        txtName.Text,
                        dateTimePicker1DOB.Value,
                        txtAddress.Text,
                        txtTelNumber.Text,
                        CarYard.Instance,
                        txtOfficeAddress.Text,
                        Convert.ToInt32(txtExtensionNumber.Text),
                        txtUserName.Text,
                        txtPassword.Text,                        
                        (Role)roleComboBox.SelectedItem);
                    Employee.Save(employee);
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show(ae.Message);
                    return;
                }
            }
            else
            {
                if (this.txtAddress.Text.Length <= 5)
                {
                    MessageBox.Show("Please enter a valid address");
                    return;
                }

                this.CurrentEmployee.Address = txtAddress.Text;

                if (this.txtTelNumber.Text.Length <= 5)
                {
                    MessageBox.Show("Please enter a telephone number.");
                    return;
                }

                this.CurrentEmployee.TelephoneNumber = txtTelNumber.Text;
                if (this.txtOfficeAddress.Text.Length <= 5)
                {
                    MessageBox.Show("Please enter a valid office address");
                    return;
                }

                this.CurrentEmployee.OfficeAddress = txtOfficeAddress.Text;
                this.CurrentEmployee.Role = (Role)roleComboBox.SelectedItem;

                if (string.IsNullOrEmpty(this.txtExtensionNumber.Text))
                {
                    MessageBox.Show("Please enter a valid extension number.");
                    return;
                }

                this.CurrentEmployee.ExtensionNumber = Convert.ToInt32(txtExtensionNumber.Text);
                if (this.txtPassword.Text.Length < 5)
                {
                    MessageBox.Show("Please enter a valid password, It's length must be at least 5 characters long.");
                    return;
                }

                this.CurrentEmployee.Password = txtPassword.Text;
            }

            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method
        private void LoadRoles()
        {
            roleComboBox.Items.Clear();

            foreach (var field in Enum.GetValues(typeof(Role)))
            {
                roleComboBox.Items.Add(field);
            }
        }
    }
    }
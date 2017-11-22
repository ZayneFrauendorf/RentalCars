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

    public partial class ViewRentedCarsByDate : Form
    {
        // Constructor
        public ViewRentedCarsByDate()
        {
            this.InitializeComponent();
        }

        // Events
        private void SearchBetweenDates_Click(object sender, EventArgs e)
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
            var rentedCarsByDate = Employee.GetRentedCarsBetweenTwoDates(dateFromPicker.Value, dateToPicker.Value);
            carBindingSource.DataSource = rentedCarsByDate;
        }
    }
}

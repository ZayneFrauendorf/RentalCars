namespace RentalCars.UI
{
    using System;
    using System.Windows.Forms;

    public partial class RentedCarsList : Form
    {
        // Constructor
        public RentedCarsList()
        {
            this.InitializeComponent();
        }

        // Events
        private void RentedCars_Load(object sender, EventArgs e)
        {
            var carYard = CarYard.Instance;
            var rentedCars = carYard.GetRentedCars();
            carBindingSource.DataSource = rentedCars;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
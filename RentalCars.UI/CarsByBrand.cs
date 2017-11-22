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

    public partial class CarsByBrand : Form
    {
        // Constructor
        public CarsByBrand()
        {
            this.InitializeComponent();
            this.LoadComboBox();
        }

        // Events
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        // Methods
        private void LoadComboBox()
        {
            this.brandComboBox.Items.Clear();
            foreach (var car in Car.All())
            {
                this.brandComboBox.Items.Add(car);
            }

            this.brandComboBox.SelectedIndex = 0;
        }

        private void Search()
        {
            List<Car> cars = new List<Car>();
           
            foreach (var car in Car.GetCarsByBrand(this.brandComboBox.Text))
            {
                cars.Add(car);
            }

            this.carBindingSource.DataSource = cars;
        }
    }
}

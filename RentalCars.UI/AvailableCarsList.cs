namespace RentalCars.UI
{
    using System;
    using System.Windows.Forms;

    public partial class AvailableCarsList : Form
    {
        // Constructor
        public AvailableCarsList()
        {
            this.InitializeComponent();
        }

        // Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var carYard = CarYard.Instance;
            var availableCars = carYard.GetAvailableCars();
            carBindingSource.DataSource = availableCars;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

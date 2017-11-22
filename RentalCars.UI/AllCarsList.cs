namespace RentalCars.UI
{
    using System;
    using System.Windows.Forms;

    public partial class AllCarsList : Form
    {
        // Constructor
        public AllCarsList()
        {
            this.InitializeComponent();
        }

        // Events
        private void AllCars_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var carYard = CarYard.Instance;
            var allCars = carYard.AllCars();
            carBindingSource.DataSource = allCars;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

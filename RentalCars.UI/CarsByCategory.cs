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

    public partial class CarsByCategory : Form
    {
        // Constructor
        public CarsByCategory()
        {
            this.InitializeComponent();
            this.LoadBodyStyles();
        }

        // Events
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        // Methods
        private void LoadBodyStyles()
        {
            this.comboCategory.Items.Clear();
            foreach (var category in Enum.GetValues(typeof(BodyStyle)))
            {
                this.comboCategory.Items.Add(category);
            }

            this.comboCategory.SelectedIndex = 0;
        }

        private void Search()
        {
            var theSelectedCategory = (BodyStyle)this.comboCategory.SelectedItem;
            var display = Car.GetCarsByCategory(theSelectedCategory);
            this.carBindingSource.DataSource = display;
        }
    }
}

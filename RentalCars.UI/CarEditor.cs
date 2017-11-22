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

    public partial class CarEditor : Form
    {
        // Constructor
        public CarEditor()
        {
            this.InitializeComponent();
            this.ApplyRelativeRange();
            this.LoadBodyStyles();
        }

        // Property
        public Car CurrentCar { get; set; }
        
        // Events
        private void CarEditor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (this.CurrentCar == null)
            {
                return;
            }

            engineNumberTxt.Text = this.CurrentCar.ENGINENUMBER;
            wofDuePicker.Value = this.CurrentCar.WOFDueAt;
            registrationDatePicker.Value = this.CurrentCar.RegistrationDueDate;
            carColourTxt.Text = this.CurrentCar.Colour;
            brandTxt.Text = this.CurrentCar.Model.Brand;
            modelTxtBox.Text = this.CurrentCar.Model.Model;
            yearOfManufactureDropDown.Value = this.CurrentCar.Model.YearOfManufacture;
            engineSizePicker.Value = Convert.ToDecimal(this.CurrentCar.Model.EngineSize);
            passengerCapacityDropDown.Value = this.CurrentCar.Model.PassengerCapacity;
            totalSeatsDropDown.Value = this.CurrentCar.Model.TotalSeats;
            maxFuelCapacityDropDown.Value = Convert.ToDecimal(this.CurrentCar.Model.MaxFuelCapacity);
            rentChargePerDayDropDown.Value = this.CurrentCar.Model.RentChargePerDay;          
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (this.CurrentCar == null)
            {
                try
                {
                    var car = new Car(
                        engineNumberTxt.Text,
                        wofDuePicker.Value,
                        registrationDatePicker.Value,
                        carColourTxt.Text,
                        (BodyStyle)bodyStyleCombo.SelectedItem,
                        new CarModel(
                            brandTxt.Text,
                            modelTxtBox.Text,
                            Convert.ToInt32(yearOfManufactureDropDown.Value),
                            Convert.ToInt32(engineSizePicker.Value),
                            Convert.ToInt32(passengerCapacityDropDown.Value),
                            Convert.ToInt32(totalSeatsDropDown.Value),
                            Convert.ToSingle(maxFuelCapacityDropDown.Value),
                            rentChargePerDayDropDown.Value),
                            priceDropDown.Value);
                    CarYard.Instance.AddCar(car);
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show(ae.Message);
                    return;
                }                            
            }
            else
            {
                this.CurrentCar.Price = priceDropDown.Value;
                this.CurrentCar.RegistrationDueDate = registrationDatePicker.Value;
                this.CurrentCar.Model.RentChargePerDay = rentChargePerDayDropDown.Value;
            }

            this.Close();
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.Color = Color.FromName(carColourTxt.Text);
            }
            catch
            {
            }

            colorDialog1.ShowDialog();

            if (colorDialog1.Color != Color.Empty)
            {
                carColourTxt.Text = colorDialog1.Color.Name;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Methods
        private void ApplyRelativeRange()
        {
            var today = DateTime.Today;

            yearOfManufactureDropDown.Minimum = today.Year - 25;
            yearOfManufactureDropDown.Maximum = today.Year + 2;

            registrationDatePicker.Value = today;
            registrationDatePicker.MinDate = today;
            registrationDatePicker.MaxDate = today.AddYears(1);

            wofDuePicker.Value = today;
        }

        private void LoadBodyStyles()
        {
            bodyStyleCombo.Items.Clear();
            
            foreach (var field in Enum.GetValues(typeof(BodyStyle)))
            {
                bodyStyleCombo.Items.Add(field);
            }

            this.bodyStyleCombo.SelectedIndex = 0;
        }
    }
}

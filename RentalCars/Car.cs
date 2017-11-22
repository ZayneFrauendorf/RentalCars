namespace RentalCars
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public class Car
    {
        // Private Backing Fields
        private Rent currentRent;
        private string engineNumber;
        private DateTime registrationDueDate;
        private decimal price;
        private string brand;
        private string carModel;

        // Constructor
        public Car(string engineNumber, DateTime wofDueAt, DateTime registrationDueDate, string colour, BodyStyle bodystyle, CarModel model, decimal price)
        {
            if (string.IsNullOrWhiteSpace(engineNumber))
            {
                throw new ArgumentException("Engine Number can't be blank.");
            }

            this.engineNumber = engineNumber;
            this.WOFDueAt = wofDueAt;
            this.RegistrationDueDate = registrationDueDate;
            if (string.IsNullOrWhiteSpace(colour))
            {
                throw new ArgumentException("Car colour can't be blank.");
            }

            this.Colour = colour;
            this.Bodystyle = bodystyle;
            this.Model = model;
            this.Price = price;         
        }

        // Properties
        public string CurrentCustomerName
        {
            get
            {
                if (this.currentRent == null)
                {
                    return null;
                }

                return this.currentRent.RentedBy.Name;
            }
        }

        public CarStatus Status
        {
            get
            {
                // return this.currentRent == null ? CarStatus.Available : CarStatus.Rented;
                if (this.currentRent == null)
                {
                    return CarStatus.Available;
                }
                else
                {
                    return CarStatus.Rented;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price < 0)
                {
                    throw new ArgumentException("Price can't be a negative number");
                }

                this.price = value;
            }
        }

        public BodyStyle Bodystyle { get; private set; }

        public CarModel Model { get; private set; }

        public string CarModel
        {
            get
            {
                return this.Model.Model;
            }
        }

        public string Brand
        {
            get
            {
                return this.Model.Brand;
            }
        }

        public DateTime RegistrationDueDate
        {
            get
            {
                return this.registrationDueDate;
            }

            set
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentException("Date time must be a future time");
                }

                this.registrationDueDate = value;
            }
        }

        public string Colour { get; private set; }

        public DateTime? DateItRents
        {
            get
            {
                if (this.currentRent == null)
                {
                    return null;
                }

                return this.currentRent.RentedAt;
            }
        }

        public DateTime? DateDueBackIn
        {
            get
            {
                if (this.currentRent == null)
                {
                    return null;
                }

                return this.currentRent.OverduedAt;
            }
        }       

        public string ENGINENUMBER
        {
            get
            {
                return this.engineNumber;
            }
        }

        public DateTime WOFDueAt { get; set; }

        // Static Methods             
        public static IEnumerable<Car> All()
        {
            return CarYard.Instance.AllCars().AsReadOnly();
        }

        public static void SaveToStorage()
        {
            if (CarYard.Instance.AllCars().Count == 0)
            {
                return;
            }

            var location = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            var fileLocation = Path.Combine(location, "cars.bin");

            var serializer = new BinaryFormatter();

            using (var stream = File.OpenWrite(fileLocation))
            {
                serializer.Serialize(stream, CarYard.Instance.AllCars());
            }
        }

        public static List<Car> LoadFromStorage()
        {           
            var location = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "cars.bin");

            if (!File.Exists(location))
            {
                return new List<Car>();
            }

            var serializer = new BinaryFormatter();

            using (var stream = File.OpenRead(location))
            {
                return (List<Car>)serializer.Deserialize(stream);
            }
        }

        public static List<Car> GetCarsByBrand(string brand)
        {
            List<Car> carsbyBrand = new List<Car>();      
            foreach (var car in CarYard.Instance.AllCars())
            {
                if (car.Model.Brand == brand)
                {
                    carsbyBrand.Add(car);
                }
            }

            return carsbyBrand;
        }

        public static List<Car> GetCarsByCategory(BodyStyle category)
        {
            List<Car> carsByCategory = new List<Car>();
            foreach (var car in CarYard.Instance.AllCars())
            {
                if (car.Bodystyle == category)
                {
                    carsByCategory.Add(car);
                }
            }

            return carsByCategory;
        }

        // Non-Static Methods
        public void MakeAvailable()
        {
            this.currentRent = null;
        }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(this.Model.Brand))
            {
                return base.ToString();
            }

            return this.Model.Brand;
        }

        public void SetCurrentRent(Rent rent)
        {
            this.currentRent = rent;
        }

        public bool IsWoffDue()
        {
            var today = DateTime.Today;

            return this.WOFDueAt.Year == today.Year && this.WOFDueAt.Month == today.Month;
        }
    }
}
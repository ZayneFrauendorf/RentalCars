namespace RentalCars
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public sealed class Customer : Person
    {
        // Private Variables
        private static readonly List<Rent> Rents = new List<Rent>();
        private static List<Customer> storageOfCustomers = LoadFromStorage();
        private DateTime licenseExpiryDate;
            
        // Constructor
        public Customer(int id, string name, DateTime dateOFBirth, string address, string telephoneNumber, string licenseNumber, DateTime licenseExpiryDate) : base(id, name, dateOFBirth, address, telephoneNumber)
        {
            this.LicenseNumber = licenseNumber;
            this.licenseExpiryDate = licenseExpiryDate;
        }

        // Properties
        public string LicenseNumber { get; private set; }

        public TimeSpan Age
        {
            get
            {
                return DateTime.Now - this.DateOfBirth;
            }
        }

        public string AgeInYears
        {
            get
            {
                var result = Convert.ToInt32(this.Age.TotalDays / 365);
                return result.ToString() + " years";
            }
        }

        public DateTime LicenseExpiryDate
        {
            get
            {
                return this.licenseExpiryDate;
            }

            set
            {
                if (value <= DateTime.Now)
                {
                    throw new ArgumentException();
                }

                this.licenseExpiryDate = value;
            }
        }

        // Static Methods
        public static void SaveToStorage()
        {
            if (storageOfCustomers.Count == 0)
            {
                return;
            }

            var location = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            var fileLocation = Path.Combine(location, "customers.bin");

            var serializer = new BinaryFormatter();

            using (var stream = File.OpenWrite(fileLocation))
            {
                serializer.Serialize(stream, storageOfCustomers);
            }
        }

        public static IEnumerable<Customer> All()
        {
            return storageOfCustomers.AsReadOnly();
        }

        public static List<Car> GetRentedCarsByName(string name)
        {
            List<Car> filteredCars = new List<Car>();
            foreach (var customer in storageOfCustomers)
            {
                if (customer.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    continue;
                }

                foreach (var car in customer.GetRentedCars())
                {
                    filteredCars.Add(car);
                }
            }

            return filteredCars;
        }

        public static void Save(Customer customer)
        {
            storageOfCustomers.Add(customer);
        }

        public static Customer Get(int id)
        {
            Customer matched = null;

            foreach (var customer in storageOfCustomers)
            {
                if (customer.ID == id)
                {
                    matched = customer;
                    break;
                }
            }

            return matched;
        }

        public static List<Customer> GetByDOB(DateTime dateOfBirth)
        {
            List<Customer> customersByBirthDateList = new List<Customer>();

            foreach (var customer in storageOfCustomers)
            {
                if (customer.DateOfBirth.Date == dateOfBirth.Date)
                {
                    customersByBirthDateList.Add(customer);
                }
            }

            return customersByBirthDateList;
        }

        public static List<Car> GetOverduedCars(string name)
        {
            List<Car> overdueCarList = new List<Car>();
            foreach (var customer in storageOfCustomers)
            {
                if (customer.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    continue;
                }

                foreach (Rent rent in Rents)
                {
                    if (rent.OverduedAt < DateTime.Now)
                    {
                        overdueCarList.Add(rent.TheCar);
                    }
                }
            }

            return overdueCarList;
        }

        // Non-Static Methods
        public void RentCar(Employee employee, TimeSpan duration, params Car[] car)
        {
            employee.IssueCar(this, duration, car);
        }

        public void ReturnCar(Employee employee, params Car[] car)
        {
            employee.ReturnCar(this, car);
        }

        public void AddRent(Rent rent)
        {
            Rents.Add(rent);
        }

        public void RemoveRent(Rent rent)
        {
            Rents.Remove(rent);
        }

        public List<Rent> GetCurrentRents()
        {
            return Rents;
        }
       
        public List<Car> GetRentedCars()
        {
            List<Car> rentedCarList = new List<Car>();

            foreach (Rent rent in Rents)
            {
                rentedCarList.Add(rent.TheCar);
            }

            return rentedCarList;
        }

        private static List<Customer> LoadFromStorage()
        {
            // AppDomain.CurrentDomain.BaseDirectory = C:\carapp
            // Data = c:\carpp\data
            // file = c:\carapp\data\customers.bin
            var location = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "customers.bin");

            if (!File.Exists(location))
            {
                return new List<Customer>();
            }

            var serializer = new BinaryFormatter();

            using (var stream = File.OpenRead(location))
            {
                return (List<Customer>)serializer.Deserialize(stream);
            }
        }
    }
}
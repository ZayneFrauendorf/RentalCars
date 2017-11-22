namespace RentalCars
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public sealed class Employee : Person
    {
        // Private Variables
        private static readonly List<Rent> Rents = new List<Rent>();
        private static readonly List<Employee> StorageOfEmployees = LoadFromStorage();
        private string officeAddress;
        private int extensionNumber;
        private string password;

        // Constructor
        public Employee(int id, string name, DateTime dateOFBirth, string address, string telephoneNumber, CarYard carYard, string officeAddress, int extensionNumber, string username, string password, Role role) : base(id, name, dateOFBirth, address, telephoneNumber)
        {
            this.CarYard = carYard;
            if (string.IsNullOrWhiteSpace(officeAddress))
            {
                throw new ArgumentException("Please enter a valid office address");
            }

            this.officeAddress = officeAddress;

            this.ExtensionNumber = extensionNumber;
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Please enter a valid username");
            }

            this.UserName = username;
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Please enter a valid password");
            }

            this.Password = password;          
            this.Role = role;
        }

        // Properties
        public string OfficeAddress
        {
            get
            {
                return this.officeAddress;
            }

            set
            {              
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Must be some characters");
                }

                this.officeAddress = value;
            }
        }

        public CarYard CarYard { get; private set; }

        public Role Role { get; set; }

        public string UserName { get; private set; }   
           
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.password = value;
            }
        }       

        public int ExtensionNumber
        {
            get
            {
                return this.extensionNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value can't be negative for extension number.");
                }

                this.extensionNumber = value;
            }
        }
        
        // Static Methods    
        public static void SaveToStorage()
        {
            if (StorageOfEmployees.Count == 0)
            {
                return;
            }

            var location = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            var fileLocation = Path.Combine(location, "employees.bin");

            var serializer = new BinaryFormatter();

            using (var stream = File.OpenWrite(fileLocation))
            {
                serializer.Serialize(stream, StorageOfEmployees);
            }
        }

        public static Employee Get(int id)
        {
            Employee matched = null;

            foreach (var employee in StorageOfEmployees)
            {
                if (employee.ID == id)
                {
                    matched = employee;
                    break;
                }
            }

            return matched;
        }

        public static List<Employee> GetByDOB(DateTime dateOfBirth)
        {
            List<Employee> employeesByBirthDateList = new List<Employee>();

            foreach (var employee in StorageOfEmployees)
            {
                if (employee.DateOfBirth.Date == dateOfBirth.Date)
                {
                    employeesByBirthDateList.Add(employee);
                }
            }

            return employeesByBirthDateList;
        }

        public static IEnumerable<Employee> All()
        {
            return StorageOfEmployees.AsReadOnly();
        }

        public static List<Car> GetRentedCarsBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            List<Car> filteredRentedCars = new List<Car>();
            foreach (var rent in Rents)
            {
                if (dateFrom <= rent.RentedAt)
                {
                    if (dateTo >= rent.RentedAt)
                    {
                        filteredRentedCars.Add(rent.TheCar);
                    }
                }
            }

            return filteredRentedCars;
        }

        public static void Save(Employee employee)
        {
            StorageOfEmployees.Add(employee);
        }

        // Non-Static Methods
        public void AddNewCar(Car car)
        {
            this.CarYard.AddCar(car);
        }
      
        public List<Car> SearchCars(string model)
        {           
            var searchCarsByModel = new List<Car>();

            foreach (var car in this.CarYard.AllCars())
            {
                if (car.Model.Model == model)
                {
                    searchCarsByModel.Add(car);
                }
            }

            return searchCarsByModel;
        }

        public List<Car> SearchCars(decimal price)
        {
            var searchCarsByPrice = new List<Car>();

            foreach (var car in this.CarYard.AllCars())
            {
                if (car.Model.RentChargePerDay == price)
                {
                    searchCarsByPrice.Add(car);
                }
            }

            return searchCarsByPrice;
        }

        public void ReturnCar(Customer customer, params Car[] cars)
        {
            foreach (var car in cars)
            {
                if (car.Status != CarStatus.Rented)
                {
                    throw new InvalidOperationException("The car must be rented.");
                }

                foreach (var rent in customer.GetCurrentRents())
                {
                    if (rent.TheCar == car)
                    {
                        customer.RemoveRent(rent);
                        break;
                    }
                }

                car.MakeAvailable();
            }
        }

        public void IssueCar(Customer customer, TimeSpan duration, params Car[] cars)
        {
            foreach (var car in cars)
            {
                if (car.Status != CarStatus.Available)
                {
                    throw new ArgumentException("The Car is already rented.");
                }

                var rent = new Rent(car, customer, this, duration);             
                car.SetCurrentRent(rent);
                customer.AddRent(rent);
                Rents.Add(rent);
            }
        }

        public List<Car> GetIssuedCar()
        {
            List<Car> issuedCars = new List<Car>();
            foreach (var rent in Rents)
            {
                issuedCars.Add(rent.TheCar);
            }

            return issuedCars;
        }

        private static List<Employee> LoadFromStorage()
        {
            var location = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "employees.bin");
            if (!File.Exists(location))
            {
                return new List<Employee>();
            }

            var serializer = new BinaryFormatter();
            using (var stream = File.OpenRead(location))
            {
                return (List<Employee>)serializer.Deserialize(stream);
            }
        }
    }
}

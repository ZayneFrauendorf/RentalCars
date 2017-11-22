namespace RentalCars
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class CarYard
    {
        // Private Variables
        private static CarYard instance;

        private static object syncLock = new object();

        private readonly List<Car> allCars = Car.LoadFromStorage();

        // Static Methods
        public static CarYard Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new CarYard();
                        }
                    }
                }

                return instance;
            }
        }        

        // Non-Static Methods
        public void Seed()
        {
            CarModel carmodel = new CarModel("Nissan", "Lucino", 1996, 72, 6, 6, 6.1f, 72.00m);
            Car car = new Car("RB34", DateTime.Now, DateTime.Now.AddDays(1), "blue", BodyStyle.StationWagon, carmodel, 5000.00m);
            car.Price = 5000;
            Employee employee = new Employee(71, "John Smith", new DateTime(1999, 8, 14), "19 car road", "081 25000", this, "21 car road", 765, "smithJ", "password", Role.Staff);
            Car car1 = new Car("RB34", DateTime.Now, DateTime.Now.AddDays(1), "blue", BodyStyle.StationWagon, carmodel, 5000.00m);
            employee.AddNewCar(car);
            employee.AddNewCar(car1);
            Employee employee1 = new Employee(82, "john smith", new DateTime(1999, 8, 14), "19 car road", "081 25000", this, "21 car road", 765, "smithJ", "password", Role.Staff);
            Customer customer = new Customer(82, "jerry smith", new DateTime(1990, 7, 15), "12 customer lane", "205696 7575", "EUH75", new DateTime(2017, 6, 15));
            employee.IssueCar(customer, TimeSpan.FromDays(-1), car);
            Customer.Save(customer);
            Employee.Save(employee);
            Employee.Save(employee1);         
        }

        public void AddCar(Car car)
        {
            this.allCars.Add(car);
        }

        public List<Car> AllCars()
        {
            return this.allCars;
        }

        public List<Car> GetAvailableCars()
        {       
            var availableCars = new List<Car>();

            foreach (var car in this.allCars)
            {
                if (car.Status == CarStatus.Available)
                {
                   availableCars.Add(car);
               }
            }

            return availableCars;
        }

        public List<Car> GetRentedCars()
        {
            List<Car> rentedCars = new List<Car>();

            foreach (var car in this.allCars)
            {
                if (car.Status == CarStatus.Rented)
                {
                    rentedCars.Add(car);
                }               
            }

            return rentedCars;           
        }    
    }
}

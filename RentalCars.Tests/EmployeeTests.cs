namespace RentalCars.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
   public class EmployeeTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Cannot_issue_currently_rented_car_twice_at_the_same_time()
        {
            CarYard carYard = new CarYard();
            CarModel carmodel = new CarModel("Nissan", "Lucino", 1996, 72, 6, 6, 6.1f, 72.00m);
            Car car = new Car("RB34", DateTime.Now, DateTime.Now, "blue", BodyStyle.StationWagon, carmodel, 5000.00m);
            Employee employee = new Employee(71, "John Smith", new DateTime(1999, 8, 14), "19 car road", "081 25000", carYard, "21 car road", 765, "smithJ", "password", Role.Staff);
            Customer customer = new Customer(82, "Jerry Smith", new DateTime(1990, 7, 15), "12 customer lane", "205696 7575", "EUH75", new DateTime(2017, 6, 15));
            employee.IssueCar(customer, TimeSpan.FromDays(7), car);
            employee.IssueCar(customer, TimeSpan.FromDays(3), car);
        }

        [TestMethod]
        public void Issued_cars_are_stored_in_list_of_rents()
        {
            Car car = TestHelper.CreateCar();
            Employee employee = TestHelper.CreateEmployee();
            Customer customer = TestHelper.CreateCustomer();
            employee.IssueCar(customer, TimeSpan.FromSeconds(1), car);
            List<Car> issuedCars = employee.GetIssuedCar();
            Assert.IsTrue(issuedCars.Contains(car));
        }

        [TestMethod]
        public void AddCars_adds_new_car_in_car_yard()
        {
            Car car = TestHelper.CreateCar();
            Employee employee = TestHelper.CreateEmployee();
            employee.AddNewCar(car);
            List<Car> listofAllCars = employee.CarYard.AllCars();
            Assert.IsTrue(listofAllCars.Contains(car));
        }

        [TestMethod]
        public void Search_cars_by_model_name_returns_all_cars_with_matched_model()
        {
            CarModel carmodel1 = new CarModel("Nissan", "Sunny", 1998, 72, 6, 6, 6.1f, 72.00m);
            CarModel carmodel2 = new CarModel("Nissan", "Lucino", 1996, 72, 6, 6, 6.1f, 72.00m);
            Car car = new Car("RB34", DateTime.Now, DateTime.Now, "blue", BodyStyle.StationWagon, carmodel1, 5000.00m);
            Car car1 = new Car("RB34", DateTime.Now, DateTime.Now, "blue", BodyStyle.StationWagon, carmodel2, 5000.00m);
            Car car2 = new Car("RB34", DateTime.Now, DateTime.Now, "blue", BodyStyle.StationWagon, carmodel2, 5000.00m);
            Employee employee = TestHelper.CreateEmployee();
            employee.AddNewCar(car);
            employee.AddNewCar(car1);
            employee.AddNewCar(car2);
            List<Car> carsByModel = employee.SearchCars("Sunny");
            Assert.IsTrue(carsByModel.Contains(car));
            Assert.IsFalse(carsByModel.Contains(car1));
            Assert.IsFalse(carsByModel.Contains(car2));
        }

        [TestMethod]
        public void Search_cars_by_price_returns_all_cars_with_matched_model()
        {
            CarModel carmodel1 = new CarModel("Nissan", "Sunny", 1998, 72, 6, 6, 6.1f, 72.00m);
            CarModel carmodel2 = new CarModel("Nissan", "Lucino", 1996, 72, 6, 6, 6.1f, 71.00m);
            Car car = new Car("RB34", DateTime.Now, DateTime.Now, "blue", BodyStyle.StationWagon, carmodel1, 5000.00m);
            Car car1 = new Car("RB34", DateTime.Now, DateTime.Now, "blue", BodyStyle.StationWagon, carmodel2, 5000.00m);
            Car car2 = new Car("RB34", DateTime.Now, DateTime.Now, "blue", BodyStyle.StationWagon, carmodel2, 5000.00m);
            Employee employee = TestHelper.CreateEmployee();
            employee.AddNewCar(car);
            employee.AddNewCar(car1);
            employee.AddNewCar(car2);
            List<Car> carsByModel = employee.SearchCars(72.00m);
            Assert.IsTrue(carsByModel.Contains(car));
            Assert.IsFalse(carsByModel.Contains(car1));
            Assert.IsFalse(carsByModel.Contains(car2));
        }
    }
}

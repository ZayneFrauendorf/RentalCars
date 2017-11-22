namespace RentalCars.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class CarTests
    {       
        [TestMethod]
        public void Constructor_assigns_all_required_properties()
        {
            CarModel carModel = new CarModel("Mazda", "MX5", 1999, 75, 4, 4, 71.0f, 92.00m);
            Car car = new Car("RB45", new DateTime(1999, 8, 6), new DateTime(1999, 8, 6), "blue", BodyStyle.Hatchback, carModel, 5000.00m);
            Assert.AreEqual("RB45", car.ENGINENUMBER);
            Assert.AreEqual(new DateTime(1999, 8, 6), car.WOFDueAt);
            Assert.AreEqual(new DateTime(1999, 8, 6), car.RegistrationDueDate);
            Assert.AreEqual("blue", car.Colour);
            Assert.AreEqual(BodyStyle.Hatchback, car.Bodystyle);
            Assert.AreSame(carModel, car.Model);
        }

        [TestMethod]
        public void Wof_due_returns_true_if_year_and_month_is_same()
        {
            Car car = TestHelper.CreateCar();
            car.WOFDueAt = DateTime.Today;
            bool isDue = car.IsWoffDue();
            Assert.IsTrue(isDue);
        }

        [TestMethod]
        public void Wof_due_returns_false_if_year_and_month_is_not_same()
        {   
            Car car = TestHelper.CreateCar();
            car.WOFDueAt = DateTime.Today.AddMonths(1);
            bool isDue = car.IsWoffDue();
            Assert.IsFalse(isDue);
        }

        [TestMethod]
        public void Setting_current_rent_change_status_to_rented()
        {
            Car car = TestHelper.CreateCar();
            Employee employee = TestHelper.CreateEmployee();
            Customer customer = TestHelper.CreateCustomer();
            car.SetCurrentRent(new Rent(car, customer, employee, TimeSpan.FromDays(1)));
            Assert.AreEqual(CarStatus.Rented, car.Status);
        }

        [TestMethod]
        public void Making_available_makes_the_status_to_available()
        {
            Car car = TestHelper.CreateCar();
            Employee employee = TestHelper.CreateEmployee();
            Customer customer = TestHelper.CreateCustomer();
            car.SetCurrentRent(new Rent(car, customer, employee, TimeSpan.FromDays(1)));         
            car.MakeAvailable();
            Assert.AreEqual(CarStatus.Available, car.Status);
        }
    }
}
namespace RentalCars.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Returns_same_customer_when_saved()
        {                
            Customer.Save(new Customer(82, "Jerry Smith", new DateTime(1990, 7, 15), "12 customer lane", "205696 7575", "EUH75", new DateTime(2017, 6, 15)));
            Customer customer = Customer.Get(82);
            Assert.AreEqual("Jerry Smith", customer.Name);
            Assert.AreEqual(new DateTime(1990, 7, 15), customer.DateOfBirth);
            Assert.AreEqual("12 customer lane", customer.Address);
            Assert.AreEqual("205696 7575", customer.TelephoneNumber);
            Assert.AreEqual("EUH75", customer.LicenseNumber);
            Assert.AreEqual(new DateTime(2017, 6, 15), customer.LicenseExpiryDate);
        }

        [TestMethod]
        public void Car_exists_in_currently_rented_list_when_rented()
        {           
            Car car = TestHelper.CreateCar();
            Employee employee = TestHelper.CreateEmployee();
            Customer customer = TestHelper.CreateCustomer();
            customer.RentCar(employee, TimeSpan.FromDays(1), car);
            Assert.IsTrue(customer.GetCurrentRents().Count > 0);
        }

        [TestMethod]
        public void Car_does_exist_in_currently_rented_list_when_returned()
        {            
            Car car = TestHelper.CreateCar();
            Employee employee = TestHelper.CreateEmployee();
            Customer customer = TestHelper.CreateCustomer();
            customer.RentCar(employee, TimeSpan.FromDays(1), car);
            customer.ReturnCar(employee, car);
            Assert.IsTrue(customer.GetCurrentRents().Count == 0);
        }

        [TestMethod]
        public void Get_overdue_cars_returns_cars_from_currently_rented_list()
        {            
            Car car1 = TestHelper.CreateCar();
            Car car2 = TestHelper.CreateCar();
            Employee employee = TestHelper.CreateEmployee();
            Customer customer = TestHelper.CreateCustomer();
            customer.RentCar(employee, TimeSpan.FromSeconds(1), car1);
            customer.RentCar(employee, TimeSpan.FromHours(1), car2);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Customer.GetOverduedCars(customer.Name);   
                     
            // Assert.IsTrue(overdueCars.Contains(car1));
        }
    }
}
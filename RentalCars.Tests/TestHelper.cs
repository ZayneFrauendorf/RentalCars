namespace RentalCars.Tests
{
    using System;

    public static class TestHelper
    {
        public static CarYard CreateCarYard()
        {
            return new CarYard();
        }

        public static Customer CreateCustomer()
        {
           return new Customer(82, "Jerry Smith", new DateTime(1990, 7, 15), "12 customer lane", "205696 7575", "EUH75", new DateTime(2017, 6, 15));
        }

        public static Employee CreateEmployee()
        {
            return new Employee(71, "John Smith", new DateTime(1999, 8, 14), "19 car road", "081 25000", CreateCarYard(), "21 car road", 765, "smithJ", "password", Role.Staff);
        }

        public static CarModel CreateCarModel()
        {
           return new CarModel("Mazda", "MX5", 1999, 75, 4, 4, 71.0f, 92.00m);
        }

        public static Car CreateCar()
        {
            return new Car("RB45", DateTime.Today.AddMonths(1), new DateTime(1999, 8, 6), "blue", BodyStyle.Hatchback, CreateCarModel(), 5000.00m);
        }
    }
}

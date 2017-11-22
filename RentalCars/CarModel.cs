namespace RentalCars
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class CarModel
    {
        // Private Backing Field
        private decimal rentChargePerDay;

        // Constructor
        public CarModel(string brand, string model, int yearOfManufacture, double engineSize, int passengerCapacity, int totalSeats, float maxFuelCapacity, decimal rentChargePerDay)
        {
            if (string.IsNullOrWhiteSpace(brand))
            {
                throw new ArgumentException("Brand can't be blank.");
            }

            this.Brand = brand;
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model can't be blank.");
            }

            this.Model = model;
            if (yearOfManufacture <= 0)
            {
                throw new ArgumentException("Year of Manufacture can't be blank.");
            }

            this.YearOfManufacture = yearOfManufacture;
            if (engineSize <= 0)
            {
                throw new ArgumentException("Engine size cannot be blank.");
            }

            this.EngineSize = engineSize;
            if (passengerCapacity <= 0)
            {
                throw new ArgumentException("Passenger capacity can't be blank.");
            }

            this.PassengerCapacity = passengerCapacity;
            if (totalSeats <= 0)
            {
                throw new ArgumentException("Total seats can't be blank.");
            }

            this.TotalSeats = totalSeats;
            if (maxFuelCapacity <= 0)
            {
                throw new ArgumentException("Max fuel capacity can't be blank.");
            }

            this.MaxFuelCapacity = maxFuelCapacity;
            if (rentChargePerDay <= 0)
            {
                throw new ArgumentException("Rent charge per day can't be blank.");
            }

            this.RentChargePerDay = rentChargePerDay;
        }

        // Properties
        public string Brand { get; private set; }

        public string Model { get; private set; }

        public int YearOfManufacture { get; private set; }

        public double EngineSize { get; private set; }

        public int PassengerCapacity { get; private set; }

        public int TotalSeats { get; private set; }

        public float MaxFuelCapacity { get; private set; }

        // Methods
        public decimal RentChargePerDay
        {
            get
            {
                return this.rentChargePerDay;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be a positive value");
                }

                this.rentChargePerDay = value;
            }
        }

        public List<Car> GetAvailableCars(CarYard yard)
        {
            return yard.GetAvailableCars();
        }

        public List<Car> GetRentedCars(CarYard yard)
        {
            return yard.GetRentedCars();
        }

        public List<Car> AllCars(CarYard yard)
        {
            return yard.AllCars();
        }

        public decimal GetRentFor(int numberOfDays, int numberOfCars)
        {
            return this.RentChargePerDay * numberOfDays * numberOfCars;
        }

        public decimal GetWeeklyRentForTwoCars()
        {
            return this.GetRentFor(7, 2);
        }
    }
}

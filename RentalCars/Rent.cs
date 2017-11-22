namespace RentalCars
{
    using System;

    [Serializable]
    public class Rent
    {
        // Constructor
        public Rent(Car theCar, Customer rentedBy, Employee issuedBy, TimeSpan duration)
        {
            if (theCar == null)
            {
                throw new ArgumentNullException("theCar");
            }

            if (rentedBy == null)
            {
                throw new ArgumentNullException("rentedBy");
            }

            if (issuedBy == null)
            {
                throw new ArgumentNullException("issuedBy");
            }
                
            this.TheCar = theCar;                 
            this.RentedBy = rentedBy;                     
            this.IssuedBy = issuedBy;                     
            this.RentedAt = DateTime.Now;         
            this.OverduedAt = this.RentedAt.Add(duration);  
        }

        // Properties
        public DateTime RentedAt { get; private set; } 

        public DateTime OverduedAt { get; private set; }

        public Car TheCar { get; private set; }

        public Customer RentedBy { get; private set; }

        public Employee IssuedBy { get; private set; }
    }
}

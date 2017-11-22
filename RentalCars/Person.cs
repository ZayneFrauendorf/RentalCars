namespace RentalCars
{
    using System;

    [Serializable]
    public abstract class Person
    {      
        // Constructor
        public Person(int id, string name, DateTime dateOFBirth, string address, string telephoneNumber)
        {
            this.ID = id;
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Please enter a valid name.");
            }

            this.Name = name;
            this.DateOfBirth = dateOFBirth;

            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentException("Please enter a valid name.");
            }

            this.Address = address;
            if (string.IsNullOrEmpty(telephoneNumber))
            {
                throw new ArgumentException("Please enter a valid name.");
            }

            this.TelephoneNumber = telephoneNumber;
        }

        // Properties
        public int ID { get; private set; }

        public string Name { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public string Address { get; set; }

        public string TelephoneNumber { get; set; }

        // Method
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(this.Name))
            {
                return base.ToString();
            }

            return this.Name;
        }
    }
}

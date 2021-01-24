using System;

namespace Vraag3.LINQ.Domain
{
    class Person : IHasId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public decimal Wage { get; set; }
        public long ID { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"{ID}, {FirstName} {LastName}";
        }
    }
}

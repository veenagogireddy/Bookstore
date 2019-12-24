using System;
using System.Collections.Generic;

namespace ANVBookstore.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public decimal Cell { get; set; }
        public int RoleId { get; set; }

        public virtual Roles Role { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}

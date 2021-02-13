using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int UserId { get; set; }
        public virtual User User {get;set;}
        public string CompanyName { get; set; }
    }
}

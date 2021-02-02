using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}

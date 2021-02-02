using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public string DailyPrice { get; set; }
        public string Description { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
    }
}

using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Entities.Concrete
{
    public class Rental : IEntity 
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime RentDate { get; set; } //Kiralama Tarihi
        public DateTime? ReturnDate { get; set; } //Teslim Tarihi
    }
}

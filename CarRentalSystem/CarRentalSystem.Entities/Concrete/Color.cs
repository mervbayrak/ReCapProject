using CarRentalSystem.Core.Entities;

namespace CarRentalSystem.Entities.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
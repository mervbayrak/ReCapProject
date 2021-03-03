using CarRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Entities.DTOs
{
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

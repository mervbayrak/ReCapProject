using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}

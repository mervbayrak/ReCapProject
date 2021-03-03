using CarRentalSystem.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

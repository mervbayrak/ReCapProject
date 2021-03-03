using CarRentalSystem.Core.DataAccess;
using CarRentalSystem.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}

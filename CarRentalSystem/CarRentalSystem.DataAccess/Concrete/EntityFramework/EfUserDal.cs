using CarRentalSystem.Core.DataAccess.EntityFramework;
using CarRentalSystem.Core.Entities.Concrete;
using CarRentalSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepository<CarRentalDbContext, User>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarRentalDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}

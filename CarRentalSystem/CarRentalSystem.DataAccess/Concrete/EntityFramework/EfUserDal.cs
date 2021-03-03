using CarRentalSystem.Core.DataAccess.EntityFramework;
using CarRentalSystem.Core.Entities.Concrete;
using CarRentalSystem.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalSystem.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepository<CarRentalDbContext, User>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarRentalDbContext())
            {
                return context.Set<UserOperationClaim>().Include(x => x.User).Include(x => x.OperationClaim).Where(m => m.UserId == user.Id).ToList()
                    .Select(m => new OperationClaim { Id = m.OperationClaimId, Name = m.OperationClaim.Name }).ToList();
            }
        }
    }
}

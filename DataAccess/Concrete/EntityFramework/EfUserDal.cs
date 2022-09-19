using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from opc in context.OperationClaims
                             join uopc in context.UserOperationClaims
                             on opc.Id equals uopc.OperationClaimId
                             where uopc.UserId == user.Id
                             select new OperationClaim { Id = opc.Id, Name = opc.Name };
                return result.ToList();
            }
        }
    }
}

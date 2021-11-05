using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserDal:EfEntityRepositoryBase<User,RentalCarContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new RentalCarContext())
            {
                var result = from operationclaim in context.OperationClaims
                             join useroperationclaim in context.UserOperationClaims
                             on operationclaim.Id equals useroperationclaim.OperationClaimId
                             where useroperationclaim.UserId == user.Id
                             select new OperationClaim { Id = operationclaim.Id, Name = operationclaim.Name };
                return result.ToList();
            }
        }
    }
}

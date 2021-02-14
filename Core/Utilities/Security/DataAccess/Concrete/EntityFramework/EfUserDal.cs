using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Security.DataAccess.Abstract;
using Core.Utilities.Security.DataAccess.Concrete.EntityFramework.Contexts;
using Core.Utilities.Security.Entities;
using System.Linq;

namespace Core.Utilities.Security.DataAccess.Concrete.EntityFramework
{
    /// <summary>
    /// Kullanıcı için veritabanı erişim class ı
    /// </summary>
    public class EfUserDal : EfEntityRepositoryBase<User,SecurityContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new SecurityContext())
            {
                var result = from operationClaim 
                                in context.OperationClaims
                                join userOperationClaim 
                                in context.UserOperationClaims
                                on operationClaim.Id 
                                equals userOperationClaim.OperationClaimId
                                where userOperationClaim.UserId == user.Id
                                select new OperationClaim {Id = operationClaim.Id, Name = operationClaim.Name};
                return result.ToList();

            }
        }
    }
}
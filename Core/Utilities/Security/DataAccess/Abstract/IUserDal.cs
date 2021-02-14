using System.Collections.Generic;
using Core.DataAccess;
using Core.Utilities.Security.Entities;

namespace Core.Utilities.Security.DataAccess.Abstract
{
    /// <summary>
    /// EfUserDal.cs tarafından inherit edilir.
    /// </summary>
    public interface IUserDal:IEntityRepository<User>
    {
        /// <summary>
        /// Verilen kullanıcının Claims bilgilerini çeker. Bunu joinler vs yaparak sağlar.
        /// </summary>
        /// <param name="user">Rolleri çekilecek kullanıcı</param>
        List<OperationClaim> GetClaims(User user);
    }
}
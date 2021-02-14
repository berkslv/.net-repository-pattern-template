using System.Collections.Generic;
using Core.Utilities.Security.Business.Abstract;
using Core.Utilities.Security.DataAccess.Abstract;
using Core.Utilities.Security.Entities;

namespace Core.Utilities.Security.Business.Concrete
{
    /// <summary>
    /// Kullanıcı ile ilgili işlemlerin yapıldığı Business katmanı. İş kuralları yazılabilir. DataAccess ile map yapar.
    /// </summary>
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
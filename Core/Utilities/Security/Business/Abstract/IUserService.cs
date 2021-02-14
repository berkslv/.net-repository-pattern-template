using System.Collections.Generic;
using Core.Utilities.Security.Entities;

namespace Core.Utilities.Security.Business.Abstract
{
    /// <summary>
    /// UserManager.cs tarafından inherit edilir.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Kullanıcın Claims bilgilerini getirir.
        /// </summary>
        /// <param name="user">Claims bilgisi çekilecek olan User</param>
        List<OperationClaim> GetClaims(User user);
        
        /// <summary>
        /// Yeni kullanıcıyı DataAccess katmanına gönderir ve veritabanında oluşturur. Generic olarak zaten yapılıyor, özel bir filtreleme eklemek istersen ekleyebilirsin.
        /// </summary>
        /// <param name="user">Yeni kullanıcı</param>
        void Add(User user);

        /// <summary>
        /// Verilen mail adresine kayıtlı kullanıcı bilgilerini getirir.
        /// </summary>
        /// <param name="email">Getirelecek kullanıcın mail adresi.</param>
        /// <returns></returns>
        User GetByMail(string email);
    }
}
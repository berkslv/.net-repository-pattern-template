using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Helpers.Encryption
{
    /// <summary>
    /// Simetrik güvenlik anahtarı oluşturma yapar.
    /// </summary>
    public class SecurityKeyHelper
    {
        /// <summary>
        /// Simetrik güvenlik anahtarı oluşturur.
        /// </summary>
        /// <param name="securityKey">İmzalama için kullanılır. appsetting.json içerisinden çekilen gizli anahtar ve startup.cs içerisinde verilir.</param>
        /// <returns>Simetrik güvenlik anahtarı</returns>
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}

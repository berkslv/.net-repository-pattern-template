using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Helpers.Encryption
{
    /// <summary>
    /// Verilecek güvenlik anahtarı ile HmacSha256 algoritması ile credential döner.
    /// </summary>
    public class SigningCredentialsHelper
    {
        /// <summary>
        /// Verilecek güvenlik anahtarı ile HmacSha256 algoritması ile credential döner.
        /// </summary>
        /// <param name="securityKey">İmzalama için kullanılır. appsetting.json içerisinden çekilir ve startup.cs içerisinde verilir.</param>
        /// <returns>new credentials</returns>
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return  new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}

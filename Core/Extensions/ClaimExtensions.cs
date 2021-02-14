using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Core.Extensions
{
    public static class ClaimExtensions
    {

        /// <summary>
        /// Claim içerisine kullanıcı mail adresini yazar.
        /// </summary>
        public static void AddEmail(this ICollection<Claim> claims, string email)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.Email,email));
        }

        /// <summary>
        /// Claim içerisine kullanıcın adı ve soyadını geçer.
        /// </summary>
        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(ClaimTypes.Name, name));
        }


        /// <summary>
        /// Claim içerisine tanımlama bilgisi oluşturur.
        /// </summary>
        public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier));
        }

        /// <summary>
        /// Claim için rol oluşturur.
        /// </summary>
        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            roles.ToList().ForEach(role=>claims.Add(new Claim(ClaimTypes.Role, role)));
        }
    }
}
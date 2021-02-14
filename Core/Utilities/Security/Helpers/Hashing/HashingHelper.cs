using System.Text;

namespace Core.Utilities.Security.Helpers.Hashing
{
    /// <summary>
    /// Şifre hash ler ve hash lenmiş şifreyi kontrol eder.
    /// </summary>
    public class HashingHelper
    {
        /// <summary>
        /// Verilen şifreyi HmacSHA512 algoritması ile hash ler.
        /// </summary>
        /// <param name="password">Şifre</param>
        /// <param name="passwordHash">Şifrenin hash lenmiş hali. Return olmadan direk verilen parametreye yazar.</param>
        /// <param name="passwordSalt">Hash güvenliği arttırmak için salt. Return olmadan direk verilen parametreye yazar.</param>
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) 
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        /// <summary>
        /// Verilecek olan şifreyi hash ler, Aynı algoritma ile hashlendiği için aynı hash çıkaracaktır. 
        /// Hash ler veritabanındaki ile aynı ise şifreler aynıdır. Veritabanı kontrolü data veya business katmanında yapılabilir.
        /// </summary>
        /// <param name="password">Şifre</param>
        /// <param name="passwordHash">Şifrenin hash lenmiş hali.</param>
        /// <param name="passwordSalt">Hash lenmiş şifrenin salt ı</param>
        /// <returns></returns>
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

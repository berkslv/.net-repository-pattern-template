namespace Core.Utilities.Security.Entities
{
    /// <summary>
    /// Auth işleminde kullanılacak token ayarları için entity class. API katmanında appsettings.json içerisinde konfigure edilir.
    /// </summary>
    public class TokenOptions
    {
        /// <summary>
        /// Alıcı, belirli bir URL olacaktır.
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// Verici, berliri bir URL olacaktır
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Dakika cinsinden geçerlilik süresi
        /// </summary>
        public int AccessTokenExpiration { get; set; }

        /// <summary>
        /// Gizli anahtar, bu anahtar ile JWT oluşturmakta kullanılan algoritma imzalanır. Kesinlikle gizli kalmalıdır.
        /// </summary>
        public string SecurityKey { get; set; }
    }
}

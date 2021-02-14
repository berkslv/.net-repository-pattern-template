using System;

namespace Core.Utilities.Security.Entities
{
    /// <summary>
    /// Auth işlemi için üretilecek token ve süresi için entity class
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// Üretilmiş olan Token, JWT.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Token geçerlilik süresi.
        /// </summary>
        public DateTime Expiration { get; set; }

    }
}

using System.Collections.Generic;
using Core.Utilities.Security.Entities;

namespace Core.Utilities.Security.Helpers.Jwt
{
    /// <summary>
    /// JwtHelper class ını inherit eder.
    /// </summary>
    public interface ITokenHelper
    {
        
        /// <summary>
        /// Token oluşturma işlemi yapar.
        /// </summary>
        /// <param name="user">User entity. Kullanıcımız</param>
        /// <param name="operationClaims">(?)</param>
        /// <returns>Token, Expiration</returns>
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Core.Extensions;
using Core.Utilities.Security.Entities;
using Core.Utilities.Security.Helpers.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Helpers.Jwt
{
    /// <summary>
    /// JSON Web Token altyapısı için temel class
    /// </summary>
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            // Configure edilmiş token ayarlarını çekiyoruz.
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            // Class çağırıldığında expiration time oluşturma işlemi burada yapılıyor.
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            // appsettings.json içerisinde belirtilen securityKey ile imzalama yapılarak Security Key oluşturulur.
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            // Verilecek güvenlik anahtarını kullanarak credential [kimlik bilgisi] dönüşü yapar.
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            // Verilen parametrelerle JWT oluşturur.
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            // JwtSecurityTokenHandler class ı oluşturur.
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            // JwtSecurityTokenHandler class ını kullanarak oluşturulmuş olan Jwt yi yazar.
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            // Yeni giriş anahtarı döner.
            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        /// <summary>
        /// JWT oluşturulur, CreateToken fonksiyou içerisinde çağırılır. 
        /// </summary>
        /// <param name="tokenOptions">Token options, configuration dosyalarında belirtilir.</param>
        /// <param name="user">User entity. Kullanıcımız</param>
        /// <param name="signingCredentials">Verilen algoritmaya göre security key üretir.</param>
        /// <param name="operationClaims">(?)</param>
        /// <returns>JWT</returns>
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, 
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer:tokenOptions.Issuer,
                audience:tokenOptions.Audience,
                expires:_accessTokenExpiration,
                notBefore:DateTime.Now,
                claims: SetClaims(user,operationClaims),
                signingCredentials:signingCredentials
            );

            return jwt;
        }

        /// <summary>
        /// Kullanıcıya rol ataması yapar.
        /// </summary>
        /// <param name="user">User entity. Kullanıcımız</param>
        /// <param name="operationClaims">(?)</param>
        /// <returns></returns>
        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c=>c.Name).ToArray());
            
            return claims;
        }
    }
}

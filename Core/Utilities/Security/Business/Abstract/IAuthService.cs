using Core.Entities.Dtos;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Security.Entities;

namespace Core.Utilities.Security.Business.Abstract
{
    /// <summary>
    /// AuthManager.cs tarafından implemente edilir.
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Kullanıcı kayıt işlemi yapar.
        /// </summary>
        /// <param name="userForRegisterDto">Dto class'ı ile oluşturulmuş kayıt bilgileri</param>
        /// <param name="password">Şifre</param>
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password);

        /// <summary>
        /// Kullanıcı giriş işlemi yapar
        /// </summary>
        /// <param name="userForLoginDto">Dto class'ı ile oluşturulmuş giriş bilgileri</param>
        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        /// <summary>
        /// Kullanıcının email ile varolup olmadığını kontrol eder.
        /// </summary>
        /// <param name="email">Kontrol parametresi için email.</param>
        IResult UserExists(string email);

        /// <summary>
        /// Register veya Login işleminden sonra giriş için token oluşturur.
        /// </summary>
        /// <param name="user">Token verilecek kullanıcı</param>
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
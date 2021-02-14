using Core.Entities.Dtos;
using Core.Utilities.Security.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    // Route belirlenir.
    [Route("api/[controller]")]
    // API controller olduğu belirtirilir.
    [ApiController]
    public class AuthController:Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // api/login route olarak alır.
        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            // Giriş işlemi yapar.
            var userToLogin = _authService.Login(userForLoginDto);
            // Giriş başarı durumu kontrol edilir.
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            // Giriş başarılı olduktan sonra erişim tokeni oluşturulur.
            var result = _authService.CreateAccessToken(userToLogin.Data);
            // Token oluşturma başarılı ise bunu geri döner.
            if (result.Success)
            {
                return Ok(result.Data);
            }
            
            // Bir sorun varsa hata mesajını döner.
            return BadRequest(result.Message);
        }
        
        // api/register route olarak alır.
        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            // Verilen email ile kullanıcının varlığını sorgular.
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            // Kullanıcı var ise hata mesajını geri döner.
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            // Kullanıcı yok ise register işlemi yapar.
            var registerResult = _authService.Register(userForRegisterDto,userForRegisterDto.Password);
            // Register işlemini yaptıktan sonra erişim token i oluşturur.
            var result = _authService.CreateAccessToken(registerResult.Data);
            // Token oluşturma işlemi başarılı ise token i döner.
            if (result.Success)
            {
                return Ok(result.Data);
            }

            // Bir sorun varsa hata mesajını döner.
            return BadRequest(result.Message);
        }
    }
}
using Core.Entities.Abstract;

namespace Core.Entities.Dtos
{
    /// <summary>
    /// Auth altyapısı için kullanıcı girişi almakta kullanılan Dto.
    /// </summary>
    public class UserForLoginDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
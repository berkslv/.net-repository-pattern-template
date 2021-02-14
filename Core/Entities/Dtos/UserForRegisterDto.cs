using Core.Entities.Abstract;

namespace Core.Entities.Dtos
{
    /// <summary>
    /// Auth altyapısı için kullanıcı kaydı için kullanılan Dto.
    /// </summary>
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
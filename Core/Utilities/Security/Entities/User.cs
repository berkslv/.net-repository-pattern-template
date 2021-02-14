using Core.Entities.Abstract;

namespace Core.Utilities.Security.Entities
{
    /// <summary>
    /// Auth altyapısı için kullanıcı entity class
    /// </summary>
    public class User : IEntity
    {
        /// <summary>
        /// Int cinsinden kullanıcı id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// String, cinsinden ad
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// String, cinsinden soyad
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// String, cinsinden mail adresi, her kullanıcı için özeldir, veritabanında aynı email için 2 adet kullanıcı bulunamaz.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Şifrenin Hashlenmiş kısmının Salt kısmı. Ekstra güvenlik önlemi sağlar, bu olmadan rainbow tablelar kullanılarak hashlenmiş şifre kırılabilir.
        /// </summary>
        public byte[] PasswordSalt { get; set; }

        /// <summary>
        /// Şifrenin Hashlenmiş kısmı. Bir kere hashleme yapıldıktan sonra geri çözülemez. Aynı girdi aynı imzalar ve algoritma ile aynı hashi üretir. 
        /// </summary>
        /// <value></value>
        public byte[] PasswordHash { get; set; }

        /// <summary>
        /// Bool, kullanıcı aktiflik durumunu belirtir.
        /// </summary>
        public bool Status { get; set; }
    }
}
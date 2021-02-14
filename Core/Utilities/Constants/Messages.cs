namespace Core.Utilities.Constants
{
    /// <summary>
    /// Bütün işlemlerde işlem başarı-hata durumunu kontrol etmek için gerekli mesajları veren const. Magic string yerine kullanılır.
    /// </summary>
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";
        public static string ProductCalled = "Ürün başarıyla çağırıldı";


        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError="Şifre hatalı.";
        public static string SuccessfulLogin="Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserNotExists = "Kullanıcı sorgusu yapıldı ve mevcut değildi.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated="Access token başarıyla oluşturuldu.";

        
        public static string LogAdded = "Log başarı ile işlendi.";
    }
}
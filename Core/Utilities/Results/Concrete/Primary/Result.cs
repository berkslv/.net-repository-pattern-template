using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete.Primary
{
    /// <summary>
    /// İşlem başarı-hata sonucunu dönmek için veri içermeyen class
    /// </summary>
    public class Result : IResult
    {
        /// <summary>
        /// Başarı durumu ve mesaj parametre olarak verilmelidir.
        /// </summary>
        /// <param name="success">Başarı durumu.</param>
        /// <param name="message">Sonuç mesajı</param>
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        /// <summary>
        /// Mesaj olmadan sadece başarı durumunu belirtiriz.
        /// </summary>
        /// <param name="success">Başarı durumu.</param>
        public Result(bool success)
        {
            Success = success;
        }

        /// <summary>
        /// Başarı durumunu belirtmek için bool değişken alır.
        /// </summary>
        /// <value>Başarı durumu</value>
        public bool Success { get; }

        /// <summary>
        /// Başarı durumuyla ilgili mesajı custom olarak belirtiriz.
        /// </summary>
        /// <value>Sonuç mesajı</value>
        public string Message { get; }
    }
}

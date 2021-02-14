namespace Core.Utilities.Results.Concrete.Primary
{
    /// <summary>
    /// Başarı durumu true olarak constructor içerisinde belirlidir. Sadece mesajı vererek kullanabilirsin.
    /// </summary>
    public class SuccessResult:Result
    {
        /// <summary>
        /// Sadece mesaj verilir, başarı durumu varsayılan olarak true yani başarılı sayılacaktır.
        /// </summary>
        /// <param name="message">Sonuç mesajı</param>
        public SuccessResult(string message) : base(true, message)
        {
        }

        /// <summary>
        /// Parametre vermeden kullanılır, başarı durumu varsayılan olarak true yani başarılı sayılacaktır.
        /// </summary>
        public SuccessResult() : base(true)
        {
        }
    }
}

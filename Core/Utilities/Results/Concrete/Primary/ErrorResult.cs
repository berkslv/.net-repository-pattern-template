namespace Core.Utilities.Results.Concrete.Primary
{
    /// <summary>
    /// Başarı durumu false olarak constructor içerisinde belirlidir. Sadece mesajı vererek kullanabilirsin.
    /// </summary>
    public class ErrorResult:Result
    {
        /// <summary>
        /// Sadece mesaj verilir, başarı durumu varsayılan olarak false yani başarısız sayılacaktır.
        /// </summary>
        /// <param name="message">Sonuç mesajı.</param>
        public ErrorResult(string message) : base(false, message)
        {
        }

        /// <summary>
        /// Başarı durumu false olarak belirlidir, mesaj geçilmez.
        /// </summary>
        public ErrorResult() : base(false)
        {
        }
    }
}

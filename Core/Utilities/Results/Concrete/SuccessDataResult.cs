using Core.Utilities.Results.Concrete.Primary;

namespace Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Başarı durumu true olarak belirlidir. Veri ve mesaj verilebilir.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SuccessDataResult<T> : DataResult<T>
    {
        /// <summary>
        /// Veri ve mesaj verilir, başarı durumu varsayılan olarak true yani başarılıdır.
        /// </summary>
        /// <param name="data">Veri</param>
        /// <param name="message">Sonuç mesajı</param>
        /// <returns></returns>
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        /// <summary>
        /// Sadece veri verilir, başarı durumu varsayılan olarak true yani başarılıdır.
        /// </summary>
        /// <param name="data">Veri</param>
        public SuccessDataResult(T data) : base(data, true)
        {
        }

        
        /// <summary>
        /// Sadece mesaj verilir, başarı durumu varsayılan olarak true yani başarılıdır.
        /// </summary>
        /// <param name="message">Sonuç mesajı.</param>
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        
        /// <summary>
        /// Parametre verilmez, başarı durumu varsayılan olarak true yani başarılıdır.
        /// </summary>
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}

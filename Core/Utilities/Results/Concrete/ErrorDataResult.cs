using Core.Utilities.Results.Concrete.Primary;

namespace Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Başarı durumu false olarak belirlidir. Veri ve mesaj verilebilir.
    /// </summary>
    /// <typeparam name="T">Entity class</typeparam>
    public class ErrorDataResult<T> : DataResult<T>
    {
        /// <summary>
        /// Veri ve mesaj verilir, başarı durumu varsayılan olarak false yani başarısızdır.
        /// </summary>
        /// <param name="data">Veri.</param>
        /// <param name="message">Sonuç mesajı.</param>
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
            
        }

        /// <summary>
        /// Sadece veri verilir, başarı durumu varsayılan olarak false yani başarısızdır.
        /// </summary>
        /// <param name="data">Veri</param>
        public ErrorDataResult(T data) : base(data, false)
        {

        }

        /// <summary>
        /// Sadece mesaj verilir, başarı durumu varsayılan olarak false yani başarısızdır.
        /// </summary>
        /// <param name="message">Sonuç mesajı.</param>
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        /// <summary>
        /// Parametre verilmez, başarı durumu varsayılan olarak false yani başarısızdır.
        /// </summary>
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}

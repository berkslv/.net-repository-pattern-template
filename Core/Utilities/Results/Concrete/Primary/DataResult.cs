using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete.Primary
{
    /// <summary>
    /// Başarı durumu, mesaj ve veri parametre olarak verilebilir.
    /// </summary>
    /// <typeparam name="T">Entity class ını temsil eder.</typeparam>
    public class DataResult<T> : Result, IDataResult<T>
    {
        /// <summary>
        /// Veri, başarı durumu ve mesaj verilir. 
        /// </summary>
        /// <param name="data">Veri.</param>
        /// <param name="success">Başarı durumu.</param>
        /// <param name="message">Sonuç mesajı.</param>
        /// <returns></returns>
        public DataResult(T data,bool success, string message) : base(success, message)
        {
            Data = data;
        }

        /// <summary>
        /// Veri ve başarı durumu verilir, mesaj verilmez.
        /// </summary>
        /// <param name="data">Veri.</param>
        /// <param name="success">Başarı durumu</param>
        /// <returns></returns>
        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}

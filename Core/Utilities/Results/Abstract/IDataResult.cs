namespace Core.Utilities.Results.Abstract
{
    /// <summary>
    /// İşlem başarı-hata durumunu veri ile beraber dönmek için kullanılır.
    /// </summary>
    /// <typeparam name="T">Geri dönülecek veri.</typeparam>
    public interface IDataResult<out T>:IResult
    {
        T Data { get; }
    }
}

namespace Core.Utilities.Results.Abstract
{
    /// <summary>
    /// İşlem başarı-hata sonucunu veri olmadan dönmek için kullanılır.
    /// </summary>
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

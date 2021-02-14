using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Örnek entity için interface
    /// </summary>
    public interface IProductDal : IEntityRepository<Product>
    {
         
    }
}
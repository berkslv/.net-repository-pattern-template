using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    /// <summary>
    /// Örnek entity için EF kullanan class. Generic yapıyı kullanır.
    /// </summary>
    public class EfProuctDal: EfEntityRepositoryBase<Product, UltraContext>, IProductDal
    {
       
    }
}
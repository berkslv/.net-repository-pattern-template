using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities;

namespace Business.Abstract
{
    public interface IProductService
    {
        /// <summary>
        /// Verilen id ile ürünü getirir.
        /// </summary>
        /// <param name="productId">Ürün id</param>
        IDataResult<Product> GetById(int productId);

        /// <summary>
        /// Bütün ürünleri liste olarak getirir.
        /// </summary>
        IDataResult<List<Product>> GetList();

        /// <summary>
        /// Verilen category id ile eşleşen ürünleri getirir.
        /// </summary>
        IDataResult<List<Product>> GetListByCategory(int categoryId);

        /// <summary>
        /// Oluşturulan ürünü DB ye ekler
        /// </summary>
        /// <param name="product">Eklenecek ürün</param>
        IResult Add(Product product);

        /// <summary>
        /// Verilen ürünü DB den siler.
        /// </summary>
        /// <param name="product">Silinecek ürün</param>
        IResult Delete(Product product);

        /// <summary>
        /// Verilen ürünü DB de günceller.
        /// </summary>
        /// <param name="product">Güncellenecek ürün</param>
        IResult Update(Product product);
    }
}
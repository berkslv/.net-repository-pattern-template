using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities.Abstract;

namespace Core.DataAccess
{
    /// <summary>
    /// Generic olarak ORM bağımsız entity interface leri için inherit sağlar. OrmEntityRepositoryBase class ı ile birlikte kullanılır.
    /// </summary>
    /// <typeparam name="T">Kullanılacak entity</typeparam>
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        /// <summary>
        /// Parametre olarak fonksiyon geçilebilir, filtrelere uygun entity i getirir.
        /// </summary>
        /// <param name="filter">LINQ sorgusu yazılabilir</param>
        T Get(Expression<Func<T, bool>> filter);

        /// <summary>
        /// Parametre olarak fonksiyon geçilebilir, filtrelere uygun entity leri liste olarak getirir.
        /// </summary>
        /// <param name="filter">LINQ sorgusu yazılabilir</param>
        List<T> GetList(Expression<Func<T, bool>> filter=null);

        /// <summary>
        /// Oluşturulup verilen entity i DB ye kaydeder.
        /// </summary>
        /// <param name="entity">Entity</param>
        void Add(T entity);

        /// <summary>
        /// Oluşturulup verilen entity i DB de günceller.
        /// </summary>
        /// <param name="entity">Entity</param>
        void Update(T entity);

        /// <summary>
        /// Oluşturulup verilen entity i DB den siler.
        /// </summary>
        /// <param name="entity">Entity</param>
        void Delete(T entity);
    }
}
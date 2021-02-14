using Core.Entities.Abstract;

namespace Core.Utilities.Security.Entities
{
    /// <summary>
    /// Kullanıcı ile rolleri eşleştirmek için Entity class, Tablo içerisinde eşleşme vardır.
    /// </summary>
    public class UserOperationClaim:IEntity
    {
        /// <summary>
        /// Int, tablo için id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Int, kullanıcı ıd.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Int, rol id.
        /// </summary>
        public int OperationClaimId { get; set; }

    }
}
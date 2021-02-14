namespace Core.Utilities.Security.Entities
{
    /// <summary>
    /// Kullanıcı rolleri belirlemek için Rol tablosu oluşturur. Admin, user vs. olabilir
    /// </summary>
    public class OperationClaim
    {
        /// <summary>
        /// Int, rol id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// String, rol ismi
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
    }
}
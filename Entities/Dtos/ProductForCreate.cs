using Core.Entities.Abstract;

namespace Entities.Dtos
{
    /// <summary>
    /// Product içerisinde bulunan category ile beraber oluşturulması için Dto
    /// </summary>
    public class ProductForCreate : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
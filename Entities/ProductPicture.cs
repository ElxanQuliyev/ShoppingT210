using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductPicture : BaseEntity
    {
        [MaxLength(600)]
        public string PhotoUrl { get; set; }
        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}

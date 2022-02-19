using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }
    }
}

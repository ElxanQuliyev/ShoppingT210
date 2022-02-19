using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Slider:BaseEntity
    {
        [MaxLength(200)]
        public string Header { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Price { get; set; }
        [MaxLength(700)]
        public string PhotoUrl { get; set; }
    }
}

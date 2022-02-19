using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MyConfiguration : BaseEntity
    {
        [MaxLength(600)]
        public string? Logo { get; set; }
        [MaxLength(16)]
        public string? PhoneNumber { get; set; }
        [MaxLength(16)]
        public string? PhoneNumber2 { get; set; }
        [MaxLength(50)]
        public string? Email { get; set; }
        [MaxLength(800)]
        public string? Description { get; set; }
        [MaxLength(500)]
        public string? Address { get; set; }
        [MaxLength(800)]
        public string? FbLink { get; set; }
        [MaxLength(800)]
        public string? YoutubeLink { get; set; }
        [MaxLength(800)]
        public string? InstaLink { get; set; }
        [MaxLength(800)]
        public string? TwitterLink { get; set; }
        [MaxLength(800)]
        public string? WpLink { get; set; }
        [MaxLength(18)]
        public string? WpNumber { get; set; }
    }
}

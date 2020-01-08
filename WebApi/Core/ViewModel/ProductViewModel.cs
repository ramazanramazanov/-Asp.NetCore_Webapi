using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Core.ViewModel
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string LongDescription { get; set; }

        [Required]
        [StringLength(255)]
        public decimal Price { get; set; }
    }
}

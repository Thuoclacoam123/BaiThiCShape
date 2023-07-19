using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaithiC_
{
    [Table(name: "Product")]
    internal class Product
    {
        [Key]
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? Price { get; set; } 
    }
    
}

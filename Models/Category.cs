using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Category_id { get; set; }
        public string Categories { get; set; }
    }
}

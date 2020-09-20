using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    [Table("Textbook_Publishers")]
    public class Textbook_Publishers
    {
        [Key]
        public int Publisher_id { get; set; }
        public string Publisher_name { get; set; }
        public string Publisher_website { get; set; }
    }
}

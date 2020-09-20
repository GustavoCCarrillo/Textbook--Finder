using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    [Table("Authors")]
    public class Authors
    {
        [Key]
        public int Author_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }

    }
}

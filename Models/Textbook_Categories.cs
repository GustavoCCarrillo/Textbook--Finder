using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    [Table("Textbook_Categories")]
    public class Textbook_Categories
    {
        public int Textbook_id { get; set; }

        public int Category_id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    [Table("Textbook_Authors")]
    public class Textbook_Authors
    {
        public int Textbook_id { get; set; }

        public int Author_id { get; set;  }
    }
}

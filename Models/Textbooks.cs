using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    [Table("Textbooks")]
    public class Textbooks
    {
        [Key]
        public int Textbook_id { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public string Isbn { get; set; }

        [DataType(DataType.Date)]
        public DateTime published_date { get; set; }

        [ForeignKey("Textbook_Publishers")]
        public int publisher_id { get; set; }

    }
}

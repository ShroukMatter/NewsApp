using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day03.Models
{
    public class News
    {
        public int id { get; set; }

        [MaxLength(50)]
        public string title { get; set; }
        public string description { get; set; }
        public TimeOnly time { get; set; }
        public DateOnly date { get; set; }

        [ForeignKey("catalog")]
        public int catalogId { get; set; }
        public virtual Catalog catalog { get; set; }

        [ForeignKey("author")]
        public int authorId { get; set; }

        public virtual Author author { get; set; }



    }
}

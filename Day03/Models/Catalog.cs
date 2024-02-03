using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03.Models
{
    public class Catalog
    {
        public int id { get; set; }

        [MaxLength(50)]
        public string name { get; set; }
        public string description { get; set; }

        public virtual List<News> news { get; set; } = new List<News>();
    }
}

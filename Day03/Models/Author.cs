using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03.Models
{
    public class Author
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Joindate { get; set; }

        public virtual List<News> news { get; set; } = new List<News>();

    }
}
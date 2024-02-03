using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day03.Models
{
    public class PaperContext:DbContext
    {
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<News> news { get; set; }

        public virtual DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1G999G2\SQLEXPRESS;Database=Paper;Trusted_Connection=True;TrustServerCertificate=True");
       
        }

    }
}

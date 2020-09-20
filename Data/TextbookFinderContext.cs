using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextbookFinder.Models;



namespace TextbookFinder.Data
{
    public class TextbookFinderContext : DbContext
    {
        public TextbookFinderContext(DbContextOptions<TextbookFinderContext> options) : base(options)
        {
     
        }

        public DbSet<Textbooks> Textbooks {get; set;}
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Textbook_Authors> Textbook_Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Textbook_Authors>()
                .HasKey(c => new { c.Textbook_id, c.Author_id });

            modelBuilder.Entity<Textbook_Categories>()
                .HasKey(c => new { c.Textbook_id, c.Category_id });
        }
        public DbSet<Textbook_Categories> Textbook_Categories { get; set; }
       
        public DbSet<Textbook_Publishers> Textbook_Publishers { get; set; }
    }
}

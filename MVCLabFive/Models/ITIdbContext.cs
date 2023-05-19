using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace MVCLabFive.Models
{
    public class ITIdbContext:DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }
        public virtual DbSet<PriceOffers> Priceoffers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Tags> tags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Lab5Mvc;Trusted_Connection=True");
            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(a => new { a.BookId, a.AuthorId });
            base.OnModelCreating(modelBuilder);
        }
    }
}

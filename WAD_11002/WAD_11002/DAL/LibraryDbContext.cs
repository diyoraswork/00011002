using Microsoft.EntityFrameworkCore;
using WAD_11002.Models;

namespace WAD_11002.DAL
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { 
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>()
        //        .HasOne(b => b.Category)
        //        .WithMany(c => c.Books)
        //        .HasForeignKey(b => b.CategoryId);
        //}
    }
}

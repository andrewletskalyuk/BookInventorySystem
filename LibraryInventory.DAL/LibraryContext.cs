using LibraryInventory.DAL.Models;
using System.Data.Entity;

namespace LibraryInventory.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryDbConnection") { }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasRequired(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);
        }
    }
}

namespace Library.Data
{
    using Library.Models;
    using Microsoft.EntityFrameworkCore;

    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=LibraryDb;Integrated Security=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}

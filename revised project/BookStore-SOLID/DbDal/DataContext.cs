using BookLib;
using Microsoft.EntityFrameworkCore;
using System;

namespace DbDal
{

    //remove Idataservie to IRepository
    //add IdataContext
    public class DataContext : DbContext

    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<JournalCategory> JournalCategories { get; set; }
        public DbSet<JournalTopic> Topics { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductBase> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookStoreDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////modelBuilder.Entity<BookItem>().HasKey(b => b.ItemId);
            //modelBuilder.Entity<ProductBase>().HasKey(i => i.ItemId);
            //modelBuilder.Entity<ItemType>().HasKey(t => t.TypeId);
        }
    }
}


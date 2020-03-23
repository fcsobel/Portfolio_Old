//using System;
//using System.Text;
//using Microsoft.EntityFrameworkCore;

//namespace c3o.Portfolio.Data
//{
//    public class PortfolioContext : DbContext
//    {
//        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
//        {
//        }

//        public DbSet<Entry> Entries { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Entry>().ToTable("Entries");
//        }
//    }
//}

//namespace c3o.Portfolio.Data
//{
//    public class Entry
//    {
//        public int ID { get; set; }
//        public string LastName { get; set; }
//        public string FirstMidName { get; set; }
//        public DateTime EnrollmentDate { get; set; }
//    }
//}
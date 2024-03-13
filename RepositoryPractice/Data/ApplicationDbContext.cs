using Microsoft.EntityFrameworkCore;
using RepositoryPractice.Models;

namespace RepositoryPractice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblCustomer> tblCustomer { get; set; }
        public DbSet<tblIssue> tblIssue { get; set; }

        public DbSet<ViewTblCustomerWithIssue> View_CustomerWithIssue { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ViewTblCustomerWithIssue>(Entity =>
            {
                Entity.HasNoKey().ToView("View_CustomerWithIssue");
                Entity.Property(e => e.CustomerId).HasColumnName("CustomerId");
                Entity.Property(e => e.CustomerName).HasMaxLength(50).HasColumnName("CustomerName");
                Entity.Property(e => e.IssueId).HasColumnName("IssueId");
                Entity.Property(e => e.Problem).HasMaxLength(100).HasColumnName("Problem");
                Entity.Property(e => e.CarMake).HasMaxLength(50).HasColumnName("CarMake");
                Entity.Property(e => e.CarModel).HasMaxLength(50).HasColumnName("CarModel");
                Entity.Property(e => e.CarRego).HasMaxLength(50).HasColumnName("CarRego");

            });
            base.OnModelCreating(modelBuilder);
        }


    }
}

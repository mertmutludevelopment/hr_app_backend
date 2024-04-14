using HrApp.Config;
using HrApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HrApp.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }
       
        public DbSet<PendingLeave> PendingLeaves { get; set; }

        public DbSet<ApprovedLeave> ApprovedLeaves { get; set; }

        public DbSet<DeclinedLeave> DeclinedLeaves { get; set; }

        public DbSet<AdvancePayment> AdvancePayments { get; set; }

        public DbSet<ApprovedAdvancePayment> ApprovedAdvancePayments { get; set; }

        public DbSet<Notification> Notifications { get; set; }









        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserConfig());

            modelBuilder.ApplyConfiguration(new EventConfig());


        }
    }
}

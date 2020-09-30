using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Data.Configuration;
using Shared;

namespace Infra.Data
{
    public class CarlDbContext : DbContext, IContext
    {
        public CarlDbContext(DbContextOptions<CarlDbContext> options) : base(options) { }
        
        public DbSet<Account> Account { get { return this.Set<Account>(); } }
        public DbSet<Category> Category { get { return this.Set<Category>(); } }
        public DbSet<Transaction> Transaction { get { return this.Set<Transaction>(); } }
        public DbSet<TransactionType> TransactionType { get { return this.Set<TransactionType>(); } }
        public DbSet<User> User { get { return this.Set<User>(); } }


        public int Commit()
        {
            return this.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return this.SaveChangesAsync();
        }

        public DbSet<T> DbSet<T>() where T : class
        {
            return this.DbSet<T>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
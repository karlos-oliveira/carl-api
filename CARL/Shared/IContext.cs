using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public interface IContext : IDisposable
    {
        DbSet<Account> Account { get; }
        DbSet<Category> Category { get; }
        DbSet<Transaction> Transaction { get; }
        DbSet<TransactionType> TransactionType { get; }
        DbSet<User> User { get; }

        DatabaseFacade Database { get; }
        DbSet<T> DbSet<T>() where T : class;
        Task<int> CommitAsync();
        int Commit();

    }
}

using Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Infra.Data.Repository
{
    public interface IAccountRepository
    {
        void CreateAccount(Account inputs);
        Account GetAccount(Guid IdAccount);
        List<Account> GetAccounts();
        void EditAccount(Account inputs);
        void DeleteAccount(Guid IdAccount);
    }

    public class AccountRepository : IAccountRepository
    {
        private readonly IContext _context;

        public AccountRepository(IContext context)
        {
            _context = context;
        }

        public Account GetAccount(Guid IdAccount)
        {
            return _context.Account.Where(x => x.Id == IdAccount).First();
        }

        public List<Account> GetAccounts()
        {
            //return _context.Account.Where(x => x.IsAtivo).ToList();
            return _context.Account.ToList();
        }

        public void CreateAccount(Account inputs)
        {
            _context.Account.Add(inputs);
            _context.Commit();
        }

        public void DeleteAccount(Guid IdAccount)
        {
            //_context.Account.Find(IdAccount).IsAtivo = false;
            _context.Account.Remove(_context.Account.Find(IdAccount));
            _context.Commit();
        }

        public void EditAccount(Account inputs)
        {
            _context.Account.Update(inputs);
            _context.Commit();
        }
    }
}

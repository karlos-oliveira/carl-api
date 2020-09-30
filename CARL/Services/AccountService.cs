
using Infra.Data.Repository;
using Models;
using System;
using System.Collections.Generic;
namespace Services
{
    public interface IAccountService
    {
        void CreateAccount(Account inputs);
        Account GetAccount(Guid IdAccount);
        List<Account> GetAccounts();
        void EditAccount(Account inputs);
        void DeleteAccount(Guid IdAccount);
    }

    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;
        public AccountService(IAccountRepository repo)
        {
            _repo = repo;
        }

        public Account GetAccount(Guid IdAccount)
        {
            return _repo.GetAccount(IdAccount);
        }

        public List<Account> GetAccounts()
        {
            return _repo.GetAccounts();
        }

        public void CreateAccount(Account inputs)
        {
            _repo.CreateAccount(inputs);
        }

        public void DeleteAccount(Guid IdAccount)
        {
            _repo.DeleteAccount(IdAccount);
        }

        public void EditAccount(Account inputs)
        {
            _repo.EditAccount(inputs);
        }
    }
}

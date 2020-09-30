
using Infra.Data.Repository;
using Models;
using System;
using System.Collections.Generic;
namespace Services
{
    public interface ITransactionService
    {
        void CreateTransaction(Transaction inputs);
        Transaction GetTransaction(Guid IdTransaction);
        List<Transaction> GetTransactions();
        void EditTransaction(Transaction inputs);
        void DeleteTransaction(Guid IdTransaction);
    }

    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repo;
        public TransactionService(ITransactionRepository repo)
        {
            _repo = repo;
        }

        public Transaction GetTransaction(Guid IdTransaction)
        {
            return _repo.GetTransaction(IdTransaction);
        }

        public List<Transaction> GetTransactions()
        {
            return _repo.GetTransactions();
        }

        public void CreateTransaction(Transaction inputs)
        {
            _repo.CreateTransaction(inputs);
        }

        public void DeleteTransaction(Guid IdTransaction)
        {
            _repo.DeleteTransaction(IdTransaction);
        }

        public void EditTransaction(Transaction inputs)
        {
            _repo.EditTransaction(inputs);
        }
    }
}

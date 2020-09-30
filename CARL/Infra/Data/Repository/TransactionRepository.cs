
using Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Infra.Data.Repository
{
    public interface ITransactionRepository
    {
        void CreateTransaction(Transaction inputs);
        Transaction GetTransaction(Guid IdTransaction);
        List<Transaction> GetTransactions();
        void EditTransaction(Transaction inputs);
        void DeleteTransaction(Guid IdTransaction);
    }

    public class TransactionRepository : ITransactionRepository
    {
        private readonly IContext _context;

        public TransactionRepository(IContext context)
        {
            _context = context;
        }

        public Transaction GetTransaction(Guid IdTransaction)
        {
            return _context.Transaction.Where(x => x.Id == IdTransaction).First();
        }

        public List<Transaction> GetTransactions()
        {
            //return _context.Transaction.Where(x => x.IsAtivo).ToList();
            return _context.Transaction.ToList();
        }

        public void CreateTransaction(Transaction inputs)
        {
            _context.Transaction.Add(inputs);
            _context.Commit();
        }

        public void DeleteTransaction(Guid IdTransaction)
        {
            //_context.Transaction.Find(IdTransaction).IsAtivo = false;
            _context.Transaction.Remove(_context.Transaction.Find(IdTransaction));
            _context.Commit();
        }

        public void EditTransaction(Transaction inputs)
        {
            _context.Transaction.Update(inputs);
            _context.Commit();
        }
    }
}

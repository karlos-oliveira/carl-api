
using Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Infra.Data.Repository
{
    public interface ITransactionTypeRepository
    {
        void CreateTransactionType(TransactionType inputs);
        TransactionType GetTransactionType(Guid IdTransactionType);
        List<TransactionType> GetTransactionTypes();
        void EditTransactionType(TransactionType inputs);
        void DeleteTransactionType(Guid IdTransactionType);
    }

    public class TransactionTypeRepository : ITransactionTypeRepository
    {
        private readonly IContext _context;

        public TransactionTypeRepository(IContext context)
        {
            _context = context;
        }

        public TransactionType GetTransactionType(Guid IdTransactionType)
        {
            return _context.TransactionType.Where(x => x.Id == IdTransactionType).First();
        }

        public List<TransactionType> GetTransactionTypes()
        {
            //return _context.TransactionType.Where(x => x.IsAtivo).ToList();
            return _context.TransactionType.ToList();
        }

        public void CreateTransactionType(TransactionType inputs)
        {
            _context.TransactionType.Add(inputs);
            _context.Commit();
        }

        public void DeleteTransactionType(Guid IdTransactionType)
        {
            //_context.TransactionType.Find(IdTransactionType).IsAtivo = false;
            _context.TransactionType.Remove(_context.TransactionType.Find(IdTransactionType));
            _context.Commit();
        }

        public void EditTransactionType(TransactionType inputs)
        {
            _context.TransactionType.Update(inputs);
            _context.Commit();
        }
    }
}

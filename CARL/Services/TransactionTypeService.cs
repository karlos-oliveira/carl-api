
using Infra.Data.Repository;
using Models;
using System;
using System.Collections.Generic;
namespace Services
{
    public interface ITransactionTypeService
    {
        void CreateTransactionType(TransactionType inputs);
        TransactionType GetTransactionType(Guid IdTransactionType);
        List<TransactionType> GetTransactionTypes();
        void EditTransactionType(TransactionType inputs);
        void DeleteTransactionType(Guid IdTransactionType);
    }

    public class TransactionTypeService : ITransactionTypeService
    {
        private readonly ITransactionTypeRepository _repo;
        public TransactionTypeService(ITransactionTypeRepository repo)
        {
            _repo = repo;
        }

        public TransactionType GetTransactionType(Guid IdTransactionType)
        {
            return _repo.GetTransactionType(IdTransactionType);
        }

        public List<TransactionType> GetTransactionTypes()
        {
            return _repo.GetTransactionTypes();
        }

        public void CreateTransactionType(TransactionType inputs)
        {
            _repo.CreateTransactionType(inputs);
        }

        public void DeleteTransactionType(Guid IdTransactionType)
        {
            _repo.DeleteTransactionType(IdTransactionType);
        }

        public void EditTransactionType(TransactionType inputs)
        {
            _repo.EditTransactionType(inputs);
        }
    }
}

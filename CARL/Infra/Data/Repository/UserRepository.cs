
using Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Infra.Data.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User inputs);
        User GetUser(Guid IdUser);
        List<User> GetUsers();
        void EditUser(User inputs);
        void DeleteUser(Guid IdUser);
    }

    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public User GetUser(Guid IdUser)
        {
            return _context.User.Where(x => x.Id == IdUser).First();
        }

        public List<User> GetUsers()
        {
            //return _context.User.Where(x => x.IsAtivo).ToList();
            return _context.User.ToList();
        }

        public void CreateUser(User inputs)
        {
            _context.User.Add(inputs);
            _context.Commit();
        }

        public void DeleteUser(Guid IdUser)
        {
            //_context.User.Find(IdUser).IsAtivo = false;
            _context.User.Remove(_context.User.Find(IdUser));
            _context.Commit();
        }

        public void EditUser(User inputs)
        {
            _context.User.Update(inputs);
            _context.Commit();
        }
    }
}

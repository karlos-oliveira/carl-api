
using Infra.Data.Repository;
using Models;
using System;
using System.Collections.Generic;
namespace Services
{
    public interface IUserService
    {
        void CreateUser(User inputs);
        User GetUser(Guid IdUser);
        List<User> GetUsers();
        void EditUser(User inputs);
        void DeleteUser(Guid IdUser);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public User GetUser(Guid IdUser)
        {
            return _repo.GetUser(IdUser);
        }

        public List<User> GetUsers()
        {
            return _repo.GetUsers();
        }

        public void CreateUser(User inputs)
        {
            _repo.CreateUser(inputs);
        }

        public void DeleteUser(Guid IdUser)
        {
            _repo.DeleteUser(IdUser);
        }

        public void EditUser(User inputs)
        {
            _repo.EditUser(inputs);
        }
    }
}

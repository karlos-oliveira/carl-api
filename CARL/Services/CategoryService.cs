
using Infra.Data.Repository;
using Models;
using System;
using System.Collections.Generic;
namespace Services
{
    public interface ICategoryService
    {
        void CreateCategory(Category inputs);
        Category GetCategory(Guid IdCategory);
        List<Category> GetCategorys();
        void EditCategory(Category inputs);
        void DeleteCategory(Guid IdCategory);
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public Category GetCategory(Guid IdCategory)
        {
            return _repo.GetCategory(IdCategory);
        }

        public List<Category> GetCategorys()
        {
            return _repo.GetCategories();
        }

        public void CreateCategory(Category inputs)
        {
            _repo.CreateCategory(inputs);
        }

        public void DeleteCategory(Guid IdCategory)
        {
            _repo.DeleteCategory(IdCategory);
        }

        public void EditCategory(Category inputs)
        {
            _repo.EditCategory(inputs);
        }
    }
}

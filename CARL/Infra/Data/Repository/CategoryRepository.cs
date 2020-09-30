
using Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Infra.Data.Repository
{
    public interface ICategoryRepository
    {
        void CreateCategory(Category inputs);
        Category GetCategory(Guid IdCategory);
        List<Category> GetCategories();
        void EditCategory(Category inputs);
        void DeleteCategory(Guid IdCategory);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly IContext _context;

        public CategoryRepository(IContext context)
        {
            _context = context;
        }

        public Category GetCategory(Guid IdCategory)
        {
            return _context.Category.Where(x => x.Id == IdCategory).First();
        }

        public List<Category> GetCategories()
        {
            //return _context.Category.Where(x => x.IsAtivo).ToList();
            return _context.Category.ToList();
        }

        public void CreateCategory(Category inputs)
        {
            _context.Category.Add(inputs);
            _context.Commit();
        }

        public void DeleteCategory(Guid IdCategory)
        {
            //_context.Category.Find(IdCategory).IsAtivo = false;
            _context.Category.Remove(_context.Category.Find(IdCategory));
            _context.Commit();
        }

        public void EditCategory(Category inputs)
        {
            _context.Category.Update(inputs);
            _context.Commit();
        }
    }
}

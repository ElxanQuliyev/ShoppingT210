using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        private readonly ShoppingDBContext _context;
        public CategoryService(ShoppingDBContext context)
        {

            _context = context;
        }

        public void Add(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public void Delete(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }
    }
}

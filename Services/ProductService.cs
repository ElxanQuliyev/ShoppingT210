using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        private readonly ShoppingDBContext _context;
        public ProductService(ShoppingDBContext context)
        {

            _context = context;
        }

        public void Add(Product newProduct)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
        }

        public void Update(Product newProduct)
        {
            _context.Update(newProduct);
            _context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return _context.Products.Where(c=>!c.IsDeleted).ToList();
        }
        public Product? GetById(int id)
        {
            return _context.Products.FirstOrDefault(c=>c.Id==id);
        }


        public void Delete(int id)
        {
            var selectedProduct = _context.Products.Find(id);  
            selectedProduct.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}

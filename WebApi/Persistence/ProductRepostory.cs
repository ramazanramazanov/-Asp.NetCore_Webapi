using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Core;
using WebApplication1.Core.Models;

namespace WebApplication1.Persistence
{
    public class ProductRepostory : IProductRepostory
    {
        private readonly ApplicationDbContext _contex;
        public ProductRepostory(ApplicationDbContext context)
        {
            _contex = context;
        }
        public async Task AddCakeAsync(Product product)
        {
            await _contex.Products.AddAsync(product);
           await _contex.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var product = _contex.Products.Find(id);
            _contex.Products.Remove(product);
            _contex.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _contex.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _contex.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void UpdateProduct(int id, Product product)
        {
            var item = _contex.Products.Find(id);
            item.Name = product.Name;
            item.LongDescription = product.LongDescription;
            item.ShortDescription = product.ShortDescription;
            item.Price = product.Price;

            _contex.SaveChanges();
        }
    }
}

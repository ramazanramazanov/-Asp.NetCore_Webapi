using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Core.Models;

namespace WebApplication1.Core
{
    public interface IProductRepostory
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(int id);
        void UpdateProduct(int id,Product product);
        Task AddCakeAsync(Product product);
        void Delete(int id);

    }
}

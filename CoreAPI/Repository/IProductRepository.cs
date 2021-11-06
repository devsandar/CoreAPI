using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPI.Models;
namespace CoreAPI.Repository
{
    public interface IProductRepository
    {
        void Save();
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        IEnumerable<Product> GetProducts();
        Product GetProductbyID(int id);
        void DeleteProduct(int id);
    }
}

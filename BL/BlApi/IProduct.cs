using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BlApi
{
    public interface IProduct
    {
        int Create(Product item);
        Product? Read(int id);
        Product? Read(Func<Product, bool> filter);//stage2
        List<Product?> ReadAll(Func<Product, bool>? filter = null);//stage2
        void Update(Product item);
        void Delete(int id);
        //void AllSales(bool isFavorite, int productId);
        void AllSales(BO.ProductInOrder product, bool isFavorite);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }
        //int Count,
        public int Count { get; set; }
        public categoryProduct category { get; set; }
        public List<SaleInProduct> sales { get; set; }//=new?
                                                      //public Product(string Product_Name, double Price, int Count, categoryProduct category)
                                                      //{

        //    this.Product_Name = Product_Name;
        //    this.Price = Price;
        //    this.Count = Count;
        //    this.category = category;

        //}
        //public Product(int Product_Id,string Product_Name, double Price, int Count,categoryProduct category)
        //{
        //    this.Product_Id = Product_Id;
        //    this.Product_Name = Product_Name;
        //    this.Price = Price;
        //    this.Count = Count;
        //    this.category = category;

        //}
        public Product(int product_Id, string product_Name, double price, int count, categoryProduct category)
        {
            Product_Id = product_Id;
            Product_Name = product_Name;
            Price = price;
            Count = count;
            this.category = category;
        }

        public Product()
        {
        }
    }
}

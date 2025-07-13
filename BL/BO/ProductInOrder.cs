using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BO
{
    public class ProductInOrder
    {
   
        public int Product_Id { get; init; }

        public string Product_Name { get; set; }

        public double Price { get; set; }
        public double TotalPrice { get; set; }

        public int Count { get; set; }

        public categoryProduct category { get; set; }

        public List<SaleInProduct> sales { get; set; }//=new?



        //public ProductInOrder(int product_Id, string product_Name, double price, int count, categoryProduct category)
        //{
        //    Product_Id=product_Id;
        //    Product_Name=product_Name;
        //    Price=price;
        //     Count=count;
        //    this.category = category;
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {

        public bool IsFavoriteCustomer { get; set; }
        public List<ProductInOrder> ProductList { get; set; }
        public double FinalPrice { get; set; }

        //public Order(bool IsFavoriteCustomer, List<ProductInOrder> ProductList, double FinalPrice)
        //{
        //    this.IsFavoriteCustomer = IsFavoriteCustomer;
        //    this.ProductList = ProductList;
        //    this.FinalPrice = FinalPrice;
        //}
        //public Order()
        //{
            
        //}
    }
}

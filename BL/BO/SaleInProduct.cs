using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {



        public int SaleId { get; init; }

        public int Count_Sale { get; set; }
        public double Price_Sale { get; set; }

        public bool If_All_Customers { get; set; }
        public override string ToString() => this.ToStringProperty();



        //public SaleInProduct(int saleId, int count_Sale, double price_Sale, bool if_All_Customers)
        //{
        //    SaleId = saleId;
        //    Count_Sale = count_Sale;
        //    Price_Sale = price_Sale;
        //    If_All_Customers = if_All_Customers;

        //}


    }
}

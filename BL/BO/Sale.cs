using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public double Price_Sale { get; set; }
        public bool If_All_Customers { get; set; }
        public DateTime Date_Start_Sale { get; set; }

       
        public int Count_Sale { get; set; }
        public DateTime? Date_End_Sale { get; set; }
        public override string ToString() => this.ToStringProperty();

        public Sale(int saleId, int productId, double price_Sale, bool if_All_Customers, DateTime date_Start_Sale, int count_Sale, DateTime? date_End_Sale)
        {
            SaleId = saleId;
            ProductId = productId;
            Price_Sale = price_Sale;
            If_All_Customers = if_All_Customers;
            Date_Start_Sale = date_Start_Sale;
            Date_End_Sale = date_End_Sale;
            Count_Sale = count_Sale;

        }
        public Sale()
        {
            
        }
    }
}

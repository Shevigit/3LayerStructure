using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal static class Config
    {
        private static string fileName = @"../xml/data-config.xml";
      //  private static string filePath = "M:\\c#.NET\\lesson15\\DotNet2025_ מתוקן9900_5155\\xml\\data-config";
       
		//private static int ProductNum;

		public static int ProductMinNum
        {
			get {
                 XElement xelement = XElement.Load(fileName);
                int productN = int.Parse(xelement.Element("ProductMinNum").Value);
                xelement.Element("ProductMinNum").SetValue(productN + 10);
                xelement.Save(fileName);
                return productN;
            }
        }
	

		//private static int SaleNum;

		public static int SaleMinNum
        {
			get {
                XElement xelement = XElement.Load(fileName);
                int saleN = int.Parse(xelement.Element("SaleMinNum").Value);
            xelement.Element("SaleMinNum").SetValue(saleN + 10);
            xelement.Save(fileName);
            return saleN;
            }
		}


    }
}

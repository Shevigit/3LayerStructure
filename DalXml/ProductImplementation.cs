

using DalApi;
using DO;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{
    private string PRODUCT = "product";
    private string PRODUCT_ID = "Product_Id";
    private string PRODUCT_NAME = "Product_Name";
    private string PRODUCT_CATEGORY = "category";
    private string PRODUCT_PRICE = "Price";
    private string PRODUCT_COUNT = "Count";
    private string path=@"../xml/products.xml";
   
    public int Create(Product item)
    {
        //XElement productXml = XElement.Load(@"../xml/products.xml");
        int id = Config.ProductMinNum;
        //productXml.Add(new XElement(PRODUCT,
        //    new XElement(PRODUCT_ID, id),
        //    new XElement(PRODUCT_CATEGORY, item.category),
        //    new XElement(PRODUCT_PRICE, item.Price),
        //           new XElement(PRODUCT_COUNT, item.Count)));


       

        XElement productXml = XElement.Load(path);
        productXml.Add(new XElement(PRODUCT,
               new XElement(PRODUCT_ID, id),
               new XElement(PRODUCT_NAME, item.Product_Name),
               new XElement(PRODUCT_PRICE, item.Price),
               new XElement(PRODUCT_COUNT, item.Count),
               new XElement(PRODUCT_CATEGORY, item.category)));

        productXml.Save(path);
        return id;
        //productXml.Add(item with { Product_Id = id });
        //productXml.Save(path);
        //return item.Product_Id;

    }

    public void Delete(int id)
    {
        XElement productXml = XElement.Load(path);
        XElement elementToRemove = productXml.Descendants(PRODUCT_ID).FirstOrDefault(p => p.Value.Equals(id.ToString()));

        if (elementToRemove != null)
        {
            elementToRemove.Parent.Remove();
            productXml.Save(path);
        }
        else
        {
            throw new InvalidOperationException($"לא נמצא מוצר עם ID '{id}'.");
        }


        //XElement productXml = XElement.Load(@"../xml/products.xml");
        //XElement product = productXml.Descendants(PRODUCT).FirstOrDefault(p => (int)p.Element(PRODUCT_ID) == id);
        //if (product != null)
        //{
        //    product.Remove();
        //    productXml.Save(@"../xml/Product.xml");
        //}
    }

    public Product? Read(int id)
    {
        XElement productXml = XElement.Load(path);
        var xel = productXml.Descendants(PRODUCT_ID).FirstOrDefault(p => p.Value == id.ToString()).Parent;
        Product product = new Product(
                                     int.Parse(xel.Element(PRODUCT_ID).Value),
                                     xel.Element(PRODUCT_NAME).Value,
                                     double.Parse(xel.Element(PRODUCT_PRICE).Value),
                                     int.Parse(xel.Element(PRODUCT_COUNT).Value),
                                     (categoryProduct)Enum.Parse(typeof(categoryProduct), xel.Element(PRODUCT_CATEGORY).Value));
        return product;



        //XElement productXml = XElement.Load(@"../xml/products.xml");
        //// LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read customer");
        //XElement product = productXml.Descendants(PRODUCT).FirstOrDefault(p => (int)p.Element(PRODUCT_ID) == id);
        //Product p = new Product
        //    (int.Parse(product.Element(PRODUCT_ID).Value),
        //    (string)product.Element(PRODUCT_NAME).Value,
        //    int.Parse(product.Element(PRODUCT_PRICE).Value),
        //    int.Parse(product.Element(PRODUCT_COUNT).Value),
        //    Enum.Parse<categoryProduct>(product.Element(PRODUCT_CATEGORY).Value));

        //// LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read customer");
        //return p;



    }

    public Product? Read(Func<Product, bool> filter)
    {
        XElement productXml = XElement.Load(path);
        /////////////האם צריך log
        XElement product = productXml.Descendants(PRODUCT_ID).FirstOrDefault(Product_Id => filter != null && filter(new Product((int)Product_Id.Element(PRODUCT_ID),
            Product_Id.Element(PRODUCT_NAME).Value,int.Parse( Product_Id.Element(PRODUCT_PRICE).Value),int.Parse(Product_Id.Element(PRODUCT_COUNT).Value), Enum.Parse<categoryProduct> (Product_Id.Element(PRODUCT_CATEGORY).Value))));
        Product product1 = new Product((int)product.Element(PRODUCT_ID), product.Element(PRODUCT_NAME).Value, (int)product.Element(PRODUCT_PRICE), int.Parse(product.Element(PRODUCT_COUNT).Value), Enum.Parse<categoryProduct>(product.Element(PRODUCT_CATEGORY).Value));
        return product1;
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        XElement productXml = XElement.Load(path);
        ////////////////////////////log????????????????????????????
        List<Product?> product = new List<Product?>();
        if (filter == null)
        {
            product = productXml.Descendants(PRODUCT).Select(Product_Id => new Product(
          int.Parse(Product_Id.Element(PRODUCT_ID).Value),
          (string)Product_Id.Element(PRODUCT_NAME)?.Value,
          int.Parse(Product_Id.Element(PRODUCT_PRICE)?.Value),
          int.Parse(Product_Id.Element(PRODUCT_COUNT)?.Value),
          Enum.Parse<categoryProduct>(Product_Id.Element(PRODUCT_CATEGORY)?.Value))).ToList();
            return product;
        }
        List<Product?> products = productXml.Descendants(PRODUCT).Select(Product_Id => new Product(
         int.Parse(Product_Id.Element(PRODUCT_ID).Value),
        Product_Id.Element(PRODUCT_NAME)?.Value,
        int.Parse(Product_Id.Element(PRODUCT_PRICE)?.Value),
        int.Parse(Product_Id.Element(PRODUCT_COUNT)?.Value),
        Enum.Parse<categoryProduct>(Product_Id.Element(PRODUCT_CATEGORY)?.Value))).Where(pr => filter(pr)).ToList();
        return products;

    }

    public void Update(Product item)
    {
        XElement productXml = XElement.Load(path);
        XElement p = productXml.Descendants(PRODUCT_ID).First(id => int.Parse(id.Value) == item.Product_Id).Parent;
        p.Element(PRODUCT_PRICE).SetValue(item.Price);
        p.Element(PRODUCT_NAME).SetValue(item.Product_Name);
        p.Element(PRODUCT_COUNT).SetValue(item.Count);
        p.Element(PRODUCT_CATEGORY).SetValue(item.category);
        productXml.Save(path);
        /////////////////////log??????????????????
        //Delete(item.Product_Id);
        //Create(item);
    }
}

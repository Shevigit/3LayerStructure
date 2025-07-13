
namespace Dal;

using DO;
using DalApi;
using System.Reflection;
using Tools;

//using System.Collections.Generic;

internal class Product_Implementation : IProduct
{
    // //3.	מימוש מחלקות הגישה לנתונים בפרויקט DalList:
    public int Create(Product item)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "add product");

        Product product = item with { Product_Id = DataSource.Config.CodeProductNum };
        DataSource.products.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "add product");
        LogManager.Exit();
        return product.Product_Id;
        //var q = DataSource.products.Any(p => p.Product_Id == item.Product_Id);
        //if (q)
        //    throw new DalIdExistsException("The product is exists");
        //else
        //{
        //    DataSource.products.Add(item);
        //    return item.Product_Id;
        //}
    }

    public void Delete(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");

        Product p = Read(id);
        DataSource.products.Remove(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");
        LogManager.Exit();
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");

        Product product = DataSource.products.FirstOrDefault(c => filter(c));
        if (product == null)
            throw new DalIdNotExistsException("The product is not exists");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
        LogManager.Exit();
        return product;
    }
    public Product? Read(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");

        Product product = DataSource.products.FirstOrDefault(p => p.Product_Id == id);
        if (product.Product_Id != id)
            throw new DalIdNotExistsException("The product is not exists");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
        LogManager.Exit();
        return product;

    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all product");

        if (filter == null)
        {
            LogManager.Exit();
            return new List<Product?>(DataSource.products);
        }
        var q = DataSource.products.Where(x => filter(x));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all product");
        LogManager.Exit();
        return q.ToList();
    }

    public void Update(Product item)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
        Delete(item.Product_Id);
        DataSource.products.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
        LogManager.Exit();
    }
}

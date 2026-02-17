

namespace Dal;

using DO;
using DalApi;
using System.Reflection;
using Tools;
//using System.Collections.Generic;

internal class Customer_Implementation : ICustomer
{
    //3.	מימוש מחלקות הגישה לנתונים בפרויקט DalList:


    //    עבור כל אחד מתתי הממשקים ממשו בתוך המחלקה DalList את התכונה(property) המתאימה שהוגדרה עבורו בממשק IDal, כך שיחזירו אובייקטים מהטיפוס שמממש את הממשק המתאים לכל ישות נתונים(יש לאתחל את התכונה בהגדרתה).
    //לדוגמא




    //כעת אחרי ש"עטפנו" את כל המחלקות הממשות של כל ישות במחלקה ראשית
    //DalList. אזי ניתן להפוך את כל מחלקות המימוש לבעלות הרשאת
    //internal,
    //שיהיו מוכרות רק בתוך פרויקט DalList
    //ולא מחוצה לו.
    public int Create(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");
        var q = DataSource.customers.Any(c => c.Customer_Id == item.Customer_Id);
        if (q)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Throw Exception: The customer is exists");
            throw new DalIdExistsException("The customer is exists");
        }
        
        else
        {
            DataSource.customers.Add(item);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");
            return item.Customer_Id;
        }
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer");
        Customer c = Read(id);
        DataSource.customers.Remove(c);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer");

        //Console.WriteLine("the customer delete");
    }

    public Customer? Read(Func<Customer, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");

        Customer customer = DataSource.customers.FirstOrDefault(c => filter(c));
        if (customer == null)
            throw new DalIdNotExistsException("The customer is not exists");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");

        return customer;       
    }
    public Customer? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");

        Customer customer = DataSource.customers.FirstOrDefault(c => c.Customer_Id == id);
        if(customer.Customer_Id !=id)
            throw new DalIdNotExistsException("The customer is not exists");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");

        return customer;
        
    }
    public List<Customer?> ReadAll(Func<Customer,bool>? filter=null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all customer");

        if (filter==null)
            return new List<Customer?>(DataSource.customers);
        var q=DataSource.customers.Where(x=>filter(x));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all customer");

        return q.ToList();
    }

    public void Update(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");
        Delete(item.Customer_Id);
        DataSource.customers.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");

        //Console.WriteLine("the customer update");
        //שאלות:
        //מה לעשות עם פונקציית העדכון ששולחת קודם למחיקה ומדפיסה מחיקה.
        //מה לעשות עם שליחה לקטגויה ב askProduct ?
    }
}

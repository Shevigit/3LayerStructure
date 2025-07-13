//using Dal;
using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace DalTest
{

    internal class Program
    {
        private static readonly IDal s_dal = DalApi.Factory.Get;
        public static int PrintMainMenu()
        {
            Console.WriteLine("For customer press 1");
            Console.WriteLine("For product press 2");
            Console.WriteLine("For sale press 3");
            Console.WriteLine("For clean Log folder press 4");
            Console.WriteLine("To exist press 0");
            int select = 0;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }

        public static int PrintSubMenu(string item)
        {
            Console.WriteLine($"To read all {item} press 1");
            Console.WriteLine($"To read one {item} press 2");
            Console.WriteLine($"To add {item} press 3");
            Console.WriteLine($"To delete {item} press 4");
            Console.WriteLine($"To update {item} press 5");
            Console.WriteLine("To go back press 0");
            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }
        public static void ReadProduct<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(crud.Read(code));
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadCustomer(ICrud<Customer> crud)
        {
            try
            {
                Console.WriteLine("enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(crud.Read(code));
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
                Console.WriteLine(item);

        }
        public static void AddProduct()
        {
            try
            {
                Product p = AskProduct();
                int code = s_dal.Product.Create(p);
                p = p with { Product_Id = code };
                Console.WriteLine("the product added successfuly!");
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }

        }
        public static void AddSale()
        {
            try
            {
                Sale s = AskSale();
                int code = s_dal.Sale.Create(s);
                s = s with { ProductId = code };
                Console.WriteLine("the product added to sale successfuly!");
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }

        }
        public static void AddCustomer()
        {
            try
            {
                Customer c = AskCustomer();
                int code = s_dal.Customer.Create(c);
                c = c with { Customer_Id = code };
                Console.WriteLine("the customer added successfuly!");
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }

        }
        public static void Delete<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("enter code");
                int code;
                if (!int.TryParse(Console.ReadLine(), out code))
                    code = -1;
                crud.Delete(code);
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateProduct()
        {
            try
            {
                int code;
                Console.WriteLine("Enter product code");
                if (!int.TryParse(Console.ReadLine(), out code))
                    code = 200;//איזה קוד?
                Product p = AskProduct(code);
                s_dal.Product.Update(p);
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }

        public static void UpdateCustomer()
        {
            try
            {
                //זה מבקש פעמים להקיש customer id
                int code;
                Console.WriteLine("Enter customer Id");
                if (!int.TryParse(Console.ReadLine(), out code))
                    code = 0;//איזה קוד?
                Customer c = AskCustomer(code);
                s_dal.Customer.Update(c);
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateSale()
        {
            try
            {
                int code;
                Console.WriteLine("Enter customer Id");
                if (!int.TryParse(Console.ReadLine(), out code))
                    code = 0;//איזה קוד?
                Sale s = AskSale(code);
                s_dal.Sale.Update(s);
            }
            catch (DalIdNotExistsException e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        public static Product AskProduct(int code = 0)
        {
            //int Product_Id;
            string Product_Name;
            double Price;
            int Count;
            categoryProduct category;


            //Console.WriteLine("Enter product code");
            //if (!int.TryParse(Console.ReadLine(), out Product_Id))
            //    Product_Id = 200;
            Console.WriteLine("Enter product name");
            Product_Name = Console.ReadLine();
            Console.WriteLine("Enter price");
            if (!double.TryParse(Console.ReadLine(), out Price))
                Price = 0;
            //האם באמת צריך להוסיף count///////////////////////////////////////////////////////
            Console.WriteLine("Enter count");
            if (!int.TryParse(Console.ReadLine(), out Count))
                Price = 0;
            Console.WriteLine("enter category between 1-5");
            int catagoryId;
            if (!int.TryParse(Console.ReadLine(), out catagoryId))
                catagoryId = 0;
            category = (categoryProduct)catagoryId;
            ///הוספתי count/////////////////////////////////////////////////////////////////
            return new Product(0, Product_Name, Price,Count, category);
        }

        public static Customer AskCustomer(int code = 0)
        {
            int Customer_Id;
            string Customer_Address;
            string Customer_Phone;
            string? Customer_Name = null;
            bool Customer_IsClub;

            Console.WriteLine("Enter customer Id");
            if (!int.TryParse(Console.ReadLine(), out Customer_Id))
                Customer_Id = code;
            Console.WriteLine("Enter customer name");
            Customer_Name = Console.ReadLine();

            //אם לא הקשתי האם ישים לי null?
            Console.WriteLine("Enter customer address");
            Customer_Address = Console.ReadLine();
            Console.WriteLine("Enter customer phone");
            Customer_Phone = Console.ReadLine();
            Console.WriteLine("Enter customer IsClub");
            Customer_IsClub =bool.Parse(Console.ReadLine());
            //בעיה עם השליחה של  הקטגוריה
            if (Customer_Address != null)
                return new Customer(Customer_Id, Customer_Name , Customer_Phone,Customer_IsClub, Customer_Address);
            return new Customer(Customer_Id, Customer_Name, Customer_Phone,Customer_IsClub, Customer_Address);
        }

        public static Sale AskSale(int code = 0)
        {
            int ProductId;
            int Price_Sale;
            bool If_All_Customers;
            DateTime Date_Start_Sale;
            int Count_Sale;
            DateTime? Date_End_Sale = null;

            int select;
            //double countSale;
            Console.WriteLine("Enter product code");
            if (!int.TryParse(Console.ReadLine(), out ProductId))
                ProductId = 0;
            Console.WriteLine("Enter Price Sale");
            if (!int.TryParse(Console.ReadLine(), out Price_Sale))
                Price_Sale = 0;
            Console.WriteLine("For all the customers? enter 0 or 1");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = 1;
            If_All_Customers = select == 1;
            Price_Sale = 0;
            Console.WriteLine("Enter count Sale");
            if (!int.TryParse(Console.ReadLine(), out Count_Sale))
                Count_Sale = 0;
            Console.WriteLine("Enter date start sale");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = 0;
            Date_Start_Sale = DateTime.Now.AddDays(select);
            Console.WriteLine("Enter date end sale");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = 0;
            Date_End_Sale = Date_Start_Sale.AddDays(select);


            //בעיה עם השליחה של  הקטגוריה
            if (Date_End_Sale != null)
                return new Sale(0,ProductId, Price_Sale, If_All_Customers, Date_Start_Sale, Count_Sale, Date_End_Sale);
            ////הוספתי countSale ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            return new Sale(0,ProductId, Price_Sale, If_All_Customers, Date_Start_Sale,Count_Sale);
            //מה לעשות 
        }


        private static void ProductSubMenu()
        {
            int select = PrintSubMenu("Product");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        ReadAll<Product>(s_dal.Product);
                        break;
                    case 2:
                        ReadProduct<Product>(s_dal.Product);

                        break;
                    case 3:
                        AddProduct();
                        break;
                    case 4:
                        Delete<Product>(s_dal.Product);
                        break;
                    case 5:
                        UpdateProduct();
                        break;
                    case 0:
                        Console.WriteLine("To go back");
                        break;
                    default:
                        Console.WriteLine("worng selection! please press again!");
                        break;
                }

                select = PrintSubMenu("Product");

            }

        }


        private static void CustomerSubMenu()
        {
            int select = PrintSubMenu("customer");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        ReadAll<Customer>(s_dal.Customer);
                        break;
                    case 2:
                        ReadCustomer(s_dal.Customer);

                        break;
                    case 3:
                        AddCustomer();
                        break;
                    case 4:
                        Delete<Customer>(s_dal.Customer);
                        break;
                    case 5:
                        UpdateCustomer();
                        break;
                    case 0:
                        Console.WriteLine("To go back");
                        break;
                    default:
                        Console.WriteLine("worng selection! please press again!");
                        break;
                }

                select = PrintSubMenu("customer");

            }

        }

        private static void SaleSubMenu()
        {
            int select = PrintSubMenu("sale");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        ReadAll<Sale>(s_dal.Sale);
                        break;
                    case 2:
                        ReadProduct(s_dal.Sale);

                        break;
                    case 3:
                        AddSale();
                        break;
                    case 4:
                        Delete<Sale>(s_dal.Sale);
                        break;
                    case 5:
                        UpdateSale();
                        break;
                    case 0:
                        Console.WriteLine("To go back");
                        break;
                    default:
                        Console.WriteLine("worng selection! please press again!");
                        break;
                }

                select = PrintSubMenu("sale");

            }

        }

        static void Main(string[] args)
        {
            Initialization.Initialize();

            try
            {
                int select1 = PrintMainMenu();
                while (select1 != 0)
                {
                    switch (select1)
                    {
                        case 1:
                            Console.WriteLine("customer");
                            CustomerSubMenu();
                            break;
                        case 2:
                            Console.WriteLine("product");
                            ProductSubMenu();
                            break;
                        case 3:
                            Console.WriteLine("sale");
                            SaleSubMenu();
                            break;
                        case 4:
                            Console.WriteLine("delete log");
                            LogManager.DeleteOldFolder();//--אין אפשרות לקרוא לפונקציה זה עושה כאילו לא קישרנו ובאמת כן קישרנו
                            break;
                        case 0:
                            Console.WriteLine("exist");
                            break;
                        default:
                            Console.WriteLine("worng selection! please press again!");
                            break;
                    }
                    select1 = PrintMainMenu();
                }

            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);
                throw new Exception("worng!");
            }

            //int select= PrintSubMenu("product");
            //while (select != 0)
            //{
            //    switch (select)
            //    {
            //        case 1:
            //            Console.WriteLine("customer");

            //            //
            //            //SubMenu(s_dal.Customer,"customer");
            //            break;
            //        case 2:
            //            Console.WriteLine();
            //            break;
            //        case 3:
            //            Console.WriteLine();
            //            break;
            //        case 0:
            //            Console.WriteLine();
            //            break;
            //        default:
            //            Console.WriteLine("worng selection! please press again!");
            //            break;
            //    }

            //}

        }
    }
}
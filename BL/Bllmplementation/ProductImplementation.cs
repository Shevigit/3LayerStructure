using BlApi;
using BO;
using DO;

//using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace Bllmplementation
{
    internal class ProductImplementation : IProduct
    {
        //private DalApi.IDal _dal = DalApi.Factory.Get;

        //public void AllSales(bool isFavorite, int productId)
        //{

        //}

        //public int Create(BO.Product item)
        //{
        //    try
        //    {
        //        return _dal.Product.Create(item.ConvertBoProductToDoProduct());
        //    }
        //    catch
        //    {
        //        throw new Exception("");//??
        //    }


        //}

        //public void Delete(int id)
        //{
        //    try
        //    {
        //        _dal.Product.Delete(id);
        //    }
        //    catch
        //    {

        //    }
        //}

        //public BO.Product? Read(int id)
        //{
        //    try
        //    {
        //       return _dal.Product.Read(id).ConvertDoProductToBoProduct();
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }
        //}

        //public BO.Product? Read(Func<BO.Product, bool> filter)
        //{
        //    try
        //    {
        //        return _dal.Product.Read(s => filter(s.ConvertDoProductToBoProduct())).ConvertDoProductToBoProduct();
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }

        //}

        //public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        //{
        //    try
        //    {
        //        if (filter == null)
        //            return _dal.Product.ReadAll().Select(s => s.ConvertDoProductToBoProduct()).ToList();
        //        else
        //            return _dal.Product.ReadAll(s => filter(s.ConvertDoProductToBoProduct())).Select(s => s.ConvertDoProductToBoProduct()).ToList();
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }


        //}

        //public void Update(BO.Product item)
        //{
        //    try
        //    {
        //        _dal.Product.Update(item.ConvertBoProductToDoProduct());
        //    }
        //    catch { }
        //}



        private DalApi.IDal _dal = DalApi.Factory.Get;

        //public void AllSales(bool isFavorite, int productId)
        public void AllSales(BO.ProductInOrder product, bool isFavorite)
        {
            try
            {
                product.sales = _dal.Sale.ReadAll(s => s.ProductId == product.Product_Id
                && s.Date_Start_Sale <= DateTime.Now && s.Date_End_Sale >= DateTime.Now
                && (isFavorite || s.If_All_Customers))
                    .Select(s => new BO.SaleInProduct() { SaleId = s.SaleId, If_All_Customers = s.If_All_Customers, Price_Sale = s.Price_Sale })
                    .OrderBy(s => s.Price_Sale)
                    .ToList();
            }
            catch (Exception ex)
            {


            }
        }

        public int Create(BO.Product item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Product");
                return _dal.Product.Create(item.ConvertBoProductToDoProduct());
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $" {item} was added");
            }
            catch(Exception e)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Product   Exception: {e.Message}");
                throw new BlIdExistsException("The product is  Exist!");
            }


        }

        public void Delete(int id)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Product");
                _dal.Product.Delete(id);
            }
            catch(Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Product  Exception: {ex.Message}");
                throw new BlIdNotExistsException("The product is not  Exist!");
            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Product");
                return _dal.Product.Read(id).ConvertDoProductToBoProduct();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Product  null");
                throw new BlIdNotExistsException("The product is not Exist!");
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Product");
                return _dal.Product.Read(s => filter(s.ConvertDoProductToBoProduct())).ConvertDoProductToBoProduct();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Product  null");
                throw new BlIdNotExistsException("The product is not Exist!");
            }

        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"ReadAll Product");
                    return _dal.Product.ReadAll().Select(s => s.ConvertDoProductToBoProduct()).ToList();
                }
                return _dal.Product.ReadAll(s => filter(s.ConvertDoProductToBoProduct())).Select(s => s.ConvertDoProductToBoProduct()).ToList();
            }
            catch
            {
                throw new BlIdNotExistsException("The products are not  Exist!");
            }


        }

        public void Update(BO.Product item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Product");
                _dal.Product.Update(item.ConvertBoProductToDoProduct());
            }
            catch(Exception ex) 
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Product  Exeption: {ex.Message}");
                throw new BlIdNotExistsException("The product is not Exist!");
            }
        }
    }
}

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

namespace Bllmplementation
{
    internal class SaleImplementation :ISale
    {
        //private DalApi.IDal _dal = DalApi.Factory.Get;

        //public int Create(BO.Sale item)
        //{
        //    try
        //    {
        //        return _dal.Sale.Create(item.ConvertBoSaleToDoSale());
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
        //        _dal.Sale.Delete(id);
        //    }
        //    catch
        //    {

        //    }
        //}

        //public BO.Sale? Read(int id)
        //{

        //    try
        //    {
        //        return _dal.Sale.Read(id).ConvertDoSaleToBoSale();
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }
        //}

        //public BO.Sale? Read(Func<BO.Sale, bool> filter)
        //{
        //    try
        //    {
        //        return _dal.Sale.Read(s => filter(s.ConvertDoSaleToBoSale())).ConvertDoSaleToBoSale();
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }
        //}

        //public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        //{
        //    try
        //    {
        //        if (filter == null)
        //            return _dal.Sale.ReadAll().Select(s => s.ConvertDoSaleToBoSale()).ToList();
        //        else
        //            return _dal.Sale.ReadAll(s => filter(s.ConvertDoSaleToBoSale())).Select(s => s.ConvertDoSaleToBoSale()).ToList();
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }

        //}

        //public void Update(BO.Sale item)
        //{
        //    try
        //    {
        //        _dal.Sale.Update(item.ConvertBoSaleToDoSale());
        //    }
        //    catch { }
        //}


        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Sale");
                return _dal.Sale.Create(item.ConvertBoSaleToDoSale());
            }
            catch(Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Sale Exeption: {ex.Message}");
                throw new BlIdExistsException("The sale is  Exist!");
            }
        }

        public void Delete(int id)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Sale");
                _dal.Sale.Delete(id);
            }
            catch(Exception ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Sale Exepion: {ex.Message}");
                throw new BlIdNotExistsException("The sale is not Exist!");
            }
        }

        public BO.Sale? Read(int id)
        {

            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Sale");
                return _dal.Sale.Read(id).ConvertDoSaleToBoSale();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {null} Sale");
                throw new BlIdNotExistsException("The sale is not Exist!");
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                DO.Sale sale = _dal.Sale.Read(s => filter(s.ConvertDoSaleToBoSale()));
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {sale} Sale");

                return sale.ConvertDoSaleToBoSale();
            }
            catch
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {null} Sale");
                throw new BlIdNotExistsException("The sale is not Exist!");
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Sale.ReadAll().Select(s => s.ConvertDoSaleToBoSale()).ToList();
                else
                    return _dal.Sale.ReadAll(s => filter(s.ConvertDoSaleToBoSale())).Select(s => s.ConvertDoSaleToBoSale()).ToList();
            }
            catch
            {
                throw new BlIdExistsException("The sales are not  Exist!");
            }

        }

        public void Update(BO.Sale item)
        {
            try
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale");
                _dal.Sale.Update(item.ConvertBoSaleToDoSale());
            }
            catch(BlIdExistsException ex)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale Exeption: {ex.Message}");
                throw new BlIdExistsException("The sale is  Exist!");
            }
        }
    }
}

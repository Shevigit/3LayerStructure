using BlApi;
using BO;

//using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace Bllmplementation
{
    internal class CustomerImplementation : ICustomer {
        ////המופעים המקומיים של הישויות לוגיות שתיצרו בתוך המתודות שממשות את תתי-הממשקים בשכבה זו
        ////לא נשמרים בשום בסיס נתונים,
        ////אלא מחושבים מקומית בתוך המתודות ואז מועברים לטיפול לשכבה שמעל או לשכבה שמתחת.
        ////לכן, הישויות הלוגיות הוגדרו כ
        ////reference types מסוג class.
        //{
        //    private DalApi.IDal _dal = DalApi.Factory.Get;
        //    //מקבלות BO
        //    //ומחזירות DO
        //    //3.	כל מימוש יחזיק שדה פרטי מסוג IDal שדרכו יפנו המתודות לממשקי ה DAL השונים ויפעילו מתודות מתאימות
        //    //11.	המתודות יעטפו קריאות ל DAL בבלוק try/catch ויתפסו חריגות DO. חריגות DO ישלחו כחריגות פנימיות בתוך חריגות BO חדשות שיזרקו כלפי מעלה לתצוגה.
        //    public int Create(BO.Customer item)
        //    {
        //        try
        //        {
        //            return _dal.Customer.Create(item.ConvertBoCustomerToDoCustomer());
        //        }
        //        catch
        //        {
        //            throw new Exception("");//??
        //        }
        //    }

        //    public void Delete(int id)
        //    {
        //        try
        //        {
        //            _dal.Customer.Delete(id);
        //        }
        //        catch
        //        {

        //        }
        //    }

        //    public bool IsExist(int id)
        //    {
        //        try
        //        {
        //            _dal.Customer.Read(id);
        //            return true;
        //        }
        //        catch
        //        {
        //           return false;
        //        }
        //    }

        //    public BO.Customer? Read(int id)
        //    {
        //        try
        //        {
        //            return _dal.Customer.Read(id).ConvertDoCustomerToBoCustomer();
        //        }
        //        catch
        //        {
        //            throw new Exception();
        //        }
        //    }

        //    public BO.Customer? Read(Func<BO.Customer, bool> filter)
        //    {
        //        try
        //        {
        //            return _dal.Customer.Read(s => filter(s.ConvertDoCustomerToBoCustomer())).ConvertDoCustomerToBoCustomer();
        //        }
        //        catch
        //        {
        //            throw new Exception();
        //        }

        //    }

        //    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        //    {

        //        try
        //        {
        //            if (filter == null)
        //                return _dal.Customer.ReadAll().Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
        //            else
        //                return _dal.Customer.ReadAll(s => filter(s.ConvertDoCustomerToBoCustomer())).Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
        //        }
        //        catch
        //        {
        //            throw new Exception();
        //        }

        //    }

        //    public void Update(BO.Customer item)
        //    {
        //        try
        //        {
        //            _dal.Customer.Update(item.ConvertBoCustomerToDoCustomer());
        //        }
        //        catch { }
        //    }



        //המופעים המקומיים של הישויות לוגיות שתיצרו בתוך המתודות שממשות את תתי-הממשקים בשכבה זו
        //לא נשמרים בשום בסיס נתונים,
        //אלא מחושבים מקומית בתוך המתודות ואז מועברים לטיפול לשכבה שמעל או לשכבה שמתחת.
        //לכן, הישויות הלוגיות הוגדרו כ
        //reference types מסוג class.
        private DalApi.IDal _dal = DalApi.Factory.Get;
        //מקבלות BO
        //ומחזירות DO
        //3.	כל מימוש יחזיק שדה פרטי מסוג IDal שדרכו יפנו המתודות לממשקי ה DAL השונים ויפעילו מתודות מתאימות
        //11.	המתודות יעטפו קריאות ל DAL בבלוק try/catch ויתפסו חריגות DO. חריגות DO ישלחו כחריגות פנימיות בתוך חריגות BO חדשות שיזרקו כלפי מעלה לתצוגה.


        public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.ConvertBoCustomerToDoCustomer());
            }
            catch
            {
                throw new BlIdExistsException("The customer is Exist!");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }
        }

        public bool IsExist(int id)
        {
            try
            {
                _dal.Customer.Read(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id).ConvertDoCustomerToBoCustomer();
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(s => filter(s.ConvertDoCustomerToBoCustomer())).ConvertDoCustomerToBoCustomer();
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }

        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {

            try
            {
                if (filter == null)
                    return _dal.Customer.ReadAll().Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
                else
                    return _dal.Customer.ReadAll(s => filter(s.ConvertDoCustomerToBoCustomer())).Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
            }
            catch
            {
                throw new BlIdNotExistsException("The customeres are not Exist!");
            }

        }

        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(item.ConvertBoCustomerToDoCustomer());
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }
        }
    }
}

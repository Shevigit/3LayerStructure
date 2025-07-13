using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ICustomer
    {
        //- נגדיר את חוזה השירות של השכבה הלוגית - הגדרת הממשקים (כנגד כל ישות לוגית ראשית),
        //שיכילו מתודות לצורך גישה לכל ישות לוגית
        int Create(BO.Customer item);
        BO.Customer? Read(int id);
        BO.Customer? Read(Func<BO.Customer, bool> filter);//stage2
        List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null);//stage2
        void Update(BO.Customer item);
        void Delete(int id);

        bool IsExist(int id);//?this or id?
    }
}

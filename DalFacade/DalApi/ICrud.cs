using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface ICrud<T>
    {
        //המטרה: הגדרת ממשק משותף גנרי שיגדיר בתוכו את כל פעולות ה CRUD.
        int Create(T item);
        T? Read(int id);
        T? Read(Func<T,bool> filter);//stage2
        List<T?> ReadAll(Func<T,bool>? filter=null);//stage2
        void Update(T item);
        void Delete(int id);
    }
}

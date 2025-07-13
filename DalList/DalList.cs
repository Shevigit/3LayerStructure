using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed  class DalList : IDal
    {
        //נזכיר שמטרת תבנית העיצוב Singleton
        //היא ליצור מחלקה שאפשר יהיה ליצור ממנה מופע (אובייקט) אחד לכל היותר.
        //לכל היותר הכוונה שאם לא נעשה שימוש במחלקה זו אז לא נרצה ליצור אפילו אובייקט אחד ממנה.
        //לכן לא נשתמש במחלקה סטטית כי ממנה תמיד מיוצר מופע אחד בלבד, ולפעמים לא נרצה שום מופע.
        //להפוך את המחלקה לסינגלטון
        //להפוך את המחלקה לסינגלטון
        private static readonly DalList instance=new DalList();

        public static  DalList Instance
        {
            get { return instance; }
          

        }
        //בנאי פרטי
        private DalList()
        {
            
        }
        public ICustomer Customer =>  new Customer_Implementation();

        public IProduct Product => new Product_Implementation();

        public ISale Sale => new Sale_Implementation();
    }
}

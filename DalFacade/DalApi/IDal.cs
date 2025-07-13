using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDal
    {
        //המטרה: כרגע שכבת הנתונים
        //(Dal), מכילה כמה ממשקים נפרדים וכעת נרצה לעטוף את כל הממשקים בממשק אחד שייצג את שכבת הנתונים (Dal). לכן, נגדיר ממשק חדש בשם
        //IDal, שיכיל בתוכו תכונה נפרדת עבור כל סוג של תת ממשק.
        ICustomer Customer { get; }
        IProduct Product { get; }
        ISale Sale { get; }

    }
}

using Bllmplementation;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    //להגדיר מחלקה דומה עבור השכבה הלוגית BL.
    //נרצה ששכבת התצוגה, אשר היא מעל השכבה הלוגית, תוכל לייצר אובייקטים מסוג Bl מבלי להכיר את המחלקה המממשת BlImplementation אלא רק את הממשק המוסכם IBl.
    //המחלקת Factory שהגדרנו בשכבת נתונים DAL, קראה את שם המחלקה המממשת שעליה לאתחל מקובץ קונפיגורציה.
    //לעומת זאת, בשכבה הלוגית BL, ניצור מחלקת Factory פשוטה יותר שמאתחלת את המחלקה המממשת במפורש דרך הקוד. כלומר, השכבה שמעל לא תכיר את המחלקה המממשת, אך השכבה שמתחת תצטרך להתקמפל מחדש במידה והמחלקה המממשת תשתנה.
    public static class Factory
    {
       public static IBI Get()
         {
             IBI bI = new BI();
               return bI;
        }
    }
}

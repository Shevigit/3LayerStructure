

namespace DalTest;
using DO;
using DalApi;

public static class Initialization
{


    //private static ICustomer? c_dalCustomer;
    //private static IProduct? p_dalProduct;
    //private static ISale? s_dalSale;



    //המטרה: עדכון המחלקה
    //Initialization  לעבוד מול ממשק אחד בשכבת הנתונים ולא מול 3 ממשקים נפרדים.



    //ב.כדי לגשת לרשימות הנתונים של כל ישות, נשתמש בממשקים שהגדרנו בפרקים הקודמים
    //.נגדיר שדה עבור כל ממשק לצורך גישה למתודות הממשק.
    private static IDal s_dal;//האם להוסיף סימן שאלה
    //השדה יחליף את אוסף השדות שסיפקו לנו בשלב הקודם (שלב 1) גישה לממשקי הישויות.

    //private static ICustomer? c_dalCustomer;
    //private static IProduct? p_dalProduct;
    //private static ISale? s_dalSale;
    private static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(354287950, "מירי כהן", "0583259960",false, "רשבי 15"));
        s_dal.Customer.Create(new Customer(205148692, "שבי גרינוולד",  "0548503408",false, "שערי תשובה 10"));
        s_dal.Customer.Create(new Customer(244046540, "ברכי חשין", "0556789585",true, "שדרות יחזקאל 5"));
    }
    private static void CreateProduct()
    {
        s_dal.Product.Create(new Product(0, "טאקי", 50,10, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "חתחתול", 60,12, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "ספרינט", 60,14, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "רביעיות", 30,9, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "מלך הפלאפל", 60,11, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "שלוף", 60,10, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "מלחמה", 40,12, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "קלוץ קאשעס", 80,15, categoryProduct.משחקי_קלפים));
        s_dal.Product.Create(new Product(0, "ספלאזי", 70, 15, categoryProduct.משחקי_קלפים));


        s_dal.Product.Create(new Product(0, "סטרטגו", 150,7, categoryProduct.משחקי_חשיבה));
        s_dal.Product.Create(new Product(0, "קטאן", 120,10, categoryProduct.משחקי_חשיבה));
        s_dal.Product.Create(new Product(0, "ביג דיל",80,8, categoryProduct.משחקי_חשיבה));
        s_dal.Product.Create(new Product(0, "סיכון", 90,5, categoryProduct.משחקי_חשיבה));
        s_dal.Product.Create(new Product(0, "אובונגו",120,10, categoryProduct.משחקי_חשיבה));
        s_dal.Product.Create(new Product(0, "רמי", 100, 13, categoryProduct.משחקי_חשיבה));

        s_dal.Product.Create(new Product(0, "תירס חם", 50,5, categoryProduct.משחקי_קופסא));
        s_dal.Product.Create(new Product(0, "אלוף חמין", 60,9, categoryProduct.משחקי_קופסא));
        s_dal.Product.Create(new Product(0, "בננה ספליט", 100,15, categoryProduct.משחקי_קופסא));
        s_dal.Product.Create(new Product(0, "מנקלה", 60,3, categoryProduct.משחקי_קופסא));
        s_dal.Product.Create(new Product(0, "שחמט", 50, 20, categoryProduct.משחקי_קופסא));
        s_dal.Product.Create(new Product(0, "מונופול", 100, 15, categoryProduct.משחקי_קופסא));
        s_dal.Product.Create(new Product(0, "דמקה", 60, 10, categoryProduct.משחקי_קופסא));



        s_dal.Product.Create(new Product(0, "קשים", 80,10, categoryProduct.משחקי_הרכבה));
        s_dal.Product.Create(new Product(0, "מקליקונים", 70,7, categoryProduct.משחקי_הרכבה));
        s_dal.Product.Create(new Product(0, "קליקס", 120,5, categoryProduct.משחקי_הרכבה));
        s_dal.Product.Create(new Product(0, "לגו", 100,10, categoryProduct.משחקי_הרכבה));
        s_dal.Product.Create(new Product(0, "קפלה", 60,10, categoryProduct.משחקי_הרכבה));
        s_dal.Product.Create(new Product(0, "מגנטים", 120,17, categoryProduct.משחקי_הרכבה));
        s_dal.Product.Create(new Product(0, "פאזל", 20, 13, categoryProduct.משחקי_הרכבה));

        s_dal.Product.Create(new Product(0, "בובת ניו יורק", 100,20, categoryProduct.משחקי_בובות));
        s_dal.Product.Create(new Product(0, "בובה מדברת", 120,10, categoryProduct.משחקי_בובות));
        s_dal.Product.Create(new Product(0, "בובה הולכת", 150,9, categoryProduct.משחקי_בובות));
        s_dal.Product.Create(new Product(0, "בובת חרסינה", 100,10, categoryProduct.משחקי_בובות));
        s_dal.Product.Create(new Product(0, "בובת ספוג", 30, 20, categoryProduct.משחקי_בובות));
        s_dal.Product.Create(new Product(0, "בובת מיקימאוס", 25, 10, categoryProduct.משחקי_בובות));




    }
    private static void CreateSale()
    {
        //קטאן
        s_dal.Sale.Create(new Sale(0,101, 100, true, new DateTime( 2024,04,11), 1, new DateTime(2024, 11, 14)));
       //ביג דיל
        s_dal.Sale.Create(new Sale(0,111, 60, false, new DateTime(2024,04, 20), 1, new DateTime(2024, 11, 29)));
      //מונופול
        s_dal.Sale.Create(new Sale(0,120, 80, true, new DateTime(2024, 12, 04), 2));
      //מגנטים
        s_dal.Sale.Create(new Sale(0,127, 100, false, new DateTime(2024, 11,04 ), 1, new DateTime(2024, 11,14)));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        if (s_dal.Customer.ReadAll().Any())
            return;
        //s_dal = dal;
        CreateCustomer();
        CreateProduct();
        CreateSale();
     
    }

}

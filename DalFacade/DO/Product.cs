

namespace DO;
public record Product
    (int Product_Id,
    string Product_Name,
    double Price,
    int Count,
    categoryProduct category
     
    )

{


    ///הוא כותב את ה-productid תמיד 0
    public Product() : this("", 0, 0, categoryProduct.משחקי_חשיבה)
    {

    }
    public Product(string product_Name, 
    double price,
    int count,
    categoryProduct category)
        : this(111, "", 0,0,categoryProduct.משחקי_חשיבה)
    {

    }
   

}

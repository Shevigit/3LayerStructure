namespace DO;

public record Sale(
    int SaleId,
    int ProductId,
    double Price_Sale,
    bool If_All_Customers,
    DateTime Date_Start_Sale,

    //double? Count_Sale = null,
    int Count_Sale,
    DateTime? Date_End_Sale=null
    )
{
 
    //public Sale()
    //     : this(0, 0, 111, true, DateTime.Now, 1, null)
    //{

    //}
}


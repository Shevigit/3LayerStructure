

namespace DO;

public record Customer
    (
    int Customer_Id,
    string Customer_Name,
    string Customer_Phone,
    bool Customer_IsClub,
    string Customer_Address = null)

{

    public Customer() : this(111, "", "1111111111", false, "")
    {

    }

}

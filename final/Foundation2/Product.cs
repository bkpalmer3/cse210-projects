public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quanity;

    public Product(string name, string ID, double price, int quanity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quanity = quanity;
    }   

    public double CalculateProductPrice()
    {
         double productPrice = _price * _quanity;
         return productPrice;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }
}

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double OrderTotal()
    {
        double totalPrice = 0;
        foreach(Product p in _products)
        {
            double productPrice = p.CalculateProductPrice();
            totalPrice += productPrice;
        }
        bool inUSA = _customer.CheckLocation();
        if (inUSA)
        {
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }

        return totalPrice;
    }

    public void DisplayPackingLable()
    {
        foreach (Product p in _products)
        {
            Console.Write("Product: ");
            Console.WriteLine(p.GetName());
            Console.Write("ID: ");
            Console.WriteLine(p.GetProductID());
            Console.WriteLine();

        }
    }

// A shipping label should list the name and address of the customer
    public void DisplayShippingLabel()
    {
        Console.WriteLine("===================");
        Console.Write("Name: ");
        Console.WriteLine(_customer.GetName());
        Console.Write("Adress: ");
        Console.WriteLine(_customer.GetAdress());
        Console.WriteLine("==================");

    }

}
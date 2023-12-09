public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CheckLocation()
    {
        return _address.DetermineCountry();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAdress()
    {
        return _address.StringifyAddress();
    }
}
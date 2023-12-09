public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    private bool _inUSA;

    public Address(string street, string city, string stateProvince, string country, bool inUSA)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        _inUSA = inUSA;
    }

    public bool DetermineCountry()
    {
       return _inUSA;
    }

    public string StringifyAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }



}
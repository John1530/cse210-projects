using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _postalCode;
    private string _country;

    public Address(string street, string city, string stateProvince, string postalCode, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _postalCode = postalCode;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}, {_postalCode}\n{_country}";
    }
}
/*1. The address contains a string for the street address, the city, 
state/province, and country.

2. The address should have a method that can return whether it is in 
the USA or not.

3. The address should have a method to return a string all of its 
fields together in one string (with newline characters where 
appropriate)*/
using System;

public class Address{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public Address(string streetAddress, string city, string stateOrProvince, string country){
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool LivesInUSA(){
        if (_country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }
    public string CreateAddress(){
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}, {_country}";
    }
}
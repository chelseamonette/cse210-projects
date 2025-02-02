/*1. The customer contains a name and an address.

2. The name is a string, but the Address is a class.

3. The customer should have a method that can return whether 
they live in the USA or not. (Hint this should call a method on 
the address to find this.)*/
using System;
using System.Dynamic;

public class Customer{
private string _customerName;
private Address _address;
public Customer(string customerName, Address address){
    _customerName = customerName;
    _address = address;
}
public bool LivesInUSA(){
    return _address.LivesInUSA();
}
public string GetCustomerName(){
    return _customerName;
}
public Address GetCustomerAddress(){
    return _address;
}
}
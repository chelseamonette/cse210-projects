/* 1. Contains a list of products and a customer. Can calculate the total 
cost of the order. Can return a string for the packing label. 
Can return a string for the shipping label.

2. The total price is calculated as the sum of the total cost of each 
product plus a one-time shipping cost.

3. This company is based in the USA. If the customer lives in the USA,
then the shipping cost is $5. If the customer does not live in the USA,
then the shipping cost is $35.

4. A packing label should list the name and product id of each product 
in the order.

5. A shipping label should list the name and address of the customer.*/

using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

public class Order{
private int _quantity;
private List<Product> _productList;
private Customer _customer;
public Order(Customer customer, int quantity){
    _customer = customer;
    _quantity = quantity;
    List<Product> _productList = new List<Product>();
}
public float CalculateTotalCost(){
    return 0;
}
public string PackingLabel(){
    return "";
}
public string ShippingLabel(){
    return"";
}
}
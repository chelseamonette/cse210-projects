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

public class Order{
private List<Product> _productList;
private Customer _customer;
public Order(Customer customer){
    _customer = customer;
    _productList = new List<Product>();
}
public void CreateProductList(Product product){
    _productList.Add(product);
}
public float CalculateTotalCost(){
    float productCost = 0;
    foreach(var product in _productList){
        float totalCost = product.ComputeTotalCost() + productCost;
        return productCost;
    }
    if(_customer.LivesInUSA()){
        float costPlusShipping = productCost + 5;
        return costPlusShipping;
    }
    else{
        float costPlusShipping = productCost + 35;
        return costPlusShipping;
    }
}
public List<string> PackingLabel(Product product){
    List<string> packingList = new();
    foreach(var products in _productList){
        string productName = product.GetProductName();
        int productID = product.GetProductID();
        string packingLabel = $"Name: {productName} ID: {productID}";
        packingList.Add(packingLabel);
    }
    return packingList; 
}
public List<string> ShippingLabel(Customer customer, Address address){
    List<string> shippingList = new();
    shippingList.Add($"{customer.GetCustomerName}");
    shippingList.Add($"{address.CreateAddress}");
    return shippingList;
}
}
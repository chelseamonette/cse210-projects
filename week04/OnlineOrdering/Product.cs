/*1. Contains the name, product id, price, and quantity of each 
product.

2. The total cost of this product is computed by multiplying the 
price per unit and the quantity. (If the price per unit was $3 and 
they bought 5 of them, the product total cost would be $15.)*/
using System;

public class Product{
private string _name;
private int _productID;
private double _price;
private int _quantity;

public Product(string name, int productID, double price, int quantity){
    _name = name;
    _price = price;
    _quantity = quantity;
    _productID = productID;
}
public double ComputeTotalCost(){
    double totalCost = _price * _quantity;
    return totalCost;
}

public string GetProductName(){
    return _name;
}
public void SetProductName(string name){
    _name = name;
}

public int GetProductID(){
    return _productID;
}
public double GetPrice(){
    return _price;
}
public int GetQuantity(){
    return _quantity;
}
}
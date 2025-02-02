/*1. Contains the name, product id, price, and quantity of each 
product.

2. The total cost of this product is computed by multiplying the 
price per unit and the quantity. (If the price per unit was $3 and 
they bought 5 of them, the product total cost would be $15.)*/
using System;

public class Product{
private string _name;
private float _price;
private int _quantity;

public Product(string name, float price, int quantity){
    _name = name;
    _price = price;
    _quantity = quantity;
}
public float ComputeTotalCost(){
    float totalCost = _price * _quantity;
    return totalCost;
}
}
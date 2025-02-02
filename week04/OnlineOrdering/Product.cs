/*1. Contains the name, product id, price, and quantity of each 
product.

2. The total cost of this product is computed by multiplying the 
price per unit and the quantity. (If the price per unit was $3 and 
they bought 5 of them, the product total cost would be $15.)*/
using System;

public class Product{
private string _name;
private float _price;

public Product(string name, float price){
    _name = name;
    _price = price;
}
public float ComputeTotalCost(){
    return 0;
}
}
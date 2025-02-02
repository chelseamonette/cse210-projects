/*Once you have created these classes, write a program that creates
 at least two orders with a 2-3 products each. Call the methods to 
 get the packing label, the shipping label, and the total price of 
 the order, and display the results of these methods.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Chelsea Monette",(new Address("4855 Pradera St", "Sparks", "NV", "USA"))));
        Order order2 = new Order(new Customer("Maria Monette", (new Address("236 S 860 W", "Rexburg", "ID", "USA"))));
        Order order3 = new Order(new Customer("Valerie Monette", (new Address("495 Riverdale Cir", "Verdi", "NV", "USA"))));

        List<Order> orders = new();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        int orderCounter = 1;
        foreach(var order in orders){

            Console.WriteLine($"Order Number: {orderCounter}");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine(order.CalculateTotalCost());

            orderCounter = orderCounter + 1;
        }
        
        
    }
}
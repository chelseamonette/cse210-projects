/*Once you have created these classes, write a program that creates
 at least two orders with a 2-3 products each. Call the methods to 
 get the packing label, the shipping label, and the total price of 
 the order, and display the results of these methods.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        Order order1 = new Order(new Customer("Chelsea Monette",(new Address("4855 Pradera St", "Sparks", "NV", "USA"))));
        order1.CreateProductList(new Product("Bananas", rand.Next(100,1000), 3.99, 2));
        order1.CreateProductList(new Product("GF Flour", rand.Next(100,1000), 15.99, 1));

        Order order2 = new Order(new Customer("Maria Monette", (new Address("236 S 860 W", "Rexburg", "ID", "USA"))));
        order2.CreateProductList(new Product("Corn Pops Cereal", rand.Next(100,1000), 4.99, 3));
        order2.CreateProductList(new Product("Milk", rand.Next(100,1000), 5.49, 1));

        Order order3 = new Order(new Customer("Valerie Monette", (new Address("495 Riverdale Cir", "Verdi", "NV", "USA"))));
        order3.CreateProductList(new Product("Deli Turkey", rand.Next(100,1000), 6.99, 2));
        order3.CreateProductList(new Product("100 Calorie Bread", rand.Next(100,1000), 3.00, 1));

        List<Order> orders = new();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);



        int orderCounter = 1;
        foreach(var order in orders){

            Console.WriteLine($"Order Number: {orderCounter}");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel(order.GetCustomer(), order.GetAddress()));
            Console.WriteLine($"Order Total: ${order.CalculateTotalCost()}");               

            Console.WriteLine();
            
            orderCounter = orderCounter + 1;
        }
        
        
    }
}
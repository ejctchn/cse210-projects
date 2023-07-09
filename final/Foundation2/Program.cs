using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        Order order2 = new Order();

        Console.WriteLine("\n\nORDER #1");
        Console.WriteLine($"Order Total: ${order.orderTotal()}");
        order.packingLabel();
        order.shippingLabel();
        
        Console.WriteLine("\n\nORDER #2");
        Console.WriteLine($"Order Total: ${order2.orderTotal()}");
        order2.packingLabel();
        order2.shippingLabel();
        
    }
}
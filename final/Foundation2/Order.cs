public class Order
{
    Product product = new Product();
    Customer customer = new Customer();
    List<string> products = new List<string>();
    //private bool inUSA;
    private double order_total; 
    private string curr_customer;
    private string customer_name;
    private double shipping;

    public Order()
    {
        curr_customer = customer.ReturnAddress();
        customer_name = customer.returnName();
    }
    public double orderTotal()
    {
        for(int i = 0; i < 2; i++)
        {
            products.Add(product.chooseProducts());
            order_total += product.returnTotal();
        }

        if(customer.livesInUSA() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        order_total += shipping;
        return order_total;
    }
    public void packingLabel()
    {
        Console.WriteLine("\nPACKING LABEL");
        for(int j = 0; j < products.Count; j++)
        {
            Console.WriteLine(products[j]);
        }
    }
    public void shippingLabel()
    {
        Console.WriteLine("\nSHIPPING LABEL");
        Console.WriteLine($"{customer_name}\n{curr_customer}");
    }
}
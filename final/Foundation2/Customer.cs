public class Customer
{
    Address address = new Address();
    string name;

    public string returnName()
    {
        Console.Write("What is your name? ");
        name = Console.ReadLine();
        return name;
    }
}
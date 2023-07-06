

public class Address
{
    
    Customer customer = new Customer();
    string street;
    string city;
    string state;
    int zip_code;
    string country;
    string complete_address;
    bool zip_entered = false;


    public void livesInUSA()
    {

    }
    public string returnAddress()
    {
        
        string name = customer.returnName();
        Console.Write("Please enter your street address ");
        street = Console.ReadLine();
        Console.Write("Please enter your city ");
        city = Console.ReadLine();
        Console.Write("Please enter your state ");
        state = Console.ReadLine();
        Console.Write("Please enter your zip code");
        while(!zip_entered)
        {
            try
            {    
                zip_code = Convert.ToInt32(Console.ReadLine());
                zip_entered = true;
            }
            catch
            {
                Console.WriteLine("\nPlease only enter numeric values");
            }
        }
        Console.Write("Please enter your country");
        country = Console.ReadLine();

        complete_address = $"{name}\n{street}\n{city}, {state} {zip_code}\n{country}";
        return complete_address;
    }
    
}

public class Customer
{
    Address address = new Address();
    Random rnd = new Random();
    List<string> poss_names = new List<string>();
    private string name;

    public Customer()
    {
        poss_names.Add("Marvin Pajuelo");
        poss_names.Add("Jason Rock");
        poss_names.Add("Samantha Montgomry");
        poss_names.Add("Brenda Smoothe");
        poss_names.Add("Mark Cold");
        poss_names.Add("Neva Winter");
        poss_names.Add("Harry Potter");

    }
    public string returnName()
    {
        name = poss_names[rnd.Next(poss_names.Count)];
        return name;
    }
    public string ReturnAddress()
    {
        return address.returnAddress();
    }
    public bool livesInUSA()
    {
        return address.livesInUSA();
    }
}
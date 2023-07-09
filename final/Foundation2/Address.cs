

public class Address
{   
    Random rnd = new Random();
    private string street;
    private string city;
    private string state;
    private int zip_code;
    private string country;
    private string complete_address;
    List<string> poss_countries = new List<string>();
    List<string> poss_street = new List<string>();
    List<string> poss_city = new List<string>();
    List<string> poss_state = new List<string>();
    List<int> poss_zip = new List<int>();

    public Address()
    {
        poss_countries.Add("USA");
        poss_countries.Add("Peru");
        poss_countries.Add("Germany");
        poss_countries.Add("Brazil");
        poss_countries.Add("Georgia");
        poss_countries.Add("Chile");
        poss_countries.Add("Mali");
        poss_countries.Add("Sweden");

        poss_street.Add("123 Peach St");
        poss_street.Add("5546 Georgia Rd");
        poss_street.Add("528491 Inception Dr");
        poss_street.Add("8675309 Jenny St");

        poss_city.Add("Três Pinheiros");
        poss_city.Add("Perry");
        poss_city.Add("Pachacutec");
        poss_city.Add("Rexburg");

        poss_state.Add("ID");
        poss_state.Add("GA");
        poss_state.Add("Barranca");
        poss_state.Add("Pueblo Supe");

        poss_zip.Add(31069);
        poss_zip.Add(83440);
        poss_zip.Add(15169);
        poss_zip.Add(68193);
    }
    public string returnAddress()
    {
        street = poss_street[(rnd.Next(poss_street.Count))];
        city = poss_city[rnd.Next(poss_city.Count)];
        state = poss_state[rnd.Next(poss_state.Count)];
        zip_code = poss_zip[rnd.Next(poss_zip.Count)];
        country = poss_countries[rnd.Next(poss_countries.Count)];
        
        complete_address = $"{street}\n{city}, {state} {zip_code}\n{country}";
        return complete_address;
    }
    public bool livesInUSA()
    {
        if(country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}

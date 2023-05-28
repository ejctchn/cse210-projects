public class Reference
{
    private string [] reference = 
    {
        "1 Nephi 3:7", "Jacob 2:17-18"
    };

    public string Pick_Reference(int rand_num)
    {
        string picked_ref = reference[rand_num];

        return picked_ref;
    }
}
public class Finished
{
    private bool fin = false;
    public bool Check(string chosen_scripture)
    {
        int counter = 0;
        string[] split_scrip = chosen_scripture.Split(" ");

        for(int j = 0; j < split_scrip.Length; j++)
        {
            try
            {
                if(split_scrip[j][0] == '_')
                {
                    counter++;
                } 
            }
            catch(IndexOutOfRangeException)
            {
            }
        }
        if(counter >= split_scrip.Length)
        {
            Console.WriteLine("All words have been removed");
            fin = true;
        }
        return fin;
    }
}


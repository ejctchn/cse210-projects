using System.Collections.Generic;
public class Write
{   
    public string[] prompts = {"If I could do one thing different today, what would it be?", "What was the best part of my day?", 
                            "Who was the most interesting person I interacted with today?","What was the best part of my day?", 
                            "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
                            "If I had one thing I could do over today, what would it be?"};
    
    //declairing entry global variable 
    //so I can use it in two places.
    string entry;
    
    public string take_entry()
    {
        Console.Write("> ");
        entry = Console.ReadLine();
        return entry;
    }
    public string rand_prompt()
    {
        Console.WriteLine();
        Random rnd = new Random();
        int rand_num = rnd.Next(7);
        Console.WriteLine(prompts[rand_num]);

        return prompts[rand_num];
    }
    public int word_count()
    {
        int count = 1;
        for(int i = 0; i < entry.Length; i++)
        {
            //check for spaces or new lines
            if(entry[i] == ' ' || entry[i] == '\n' || entry[i] == '\t')
            {
                count++;
            }
        }
        //check to see if the file ends in a space
        //(don't count that as a new word)
        if(entry[entry.Length - 1] == ' ')
        {
            count--;
        }
        //check to see if someone put a space before a symbol
        if(entry[entry.Length - 1] == '!' || entry[entry.Length - 1] == '?' || entry[entry.Length - 1] == '.')
        {
            if(entry[entry.Length - 2] == ' ')
            {
                count--;
            }
        }
        return count;
    }
    public int char_count()
    {
         int count = 1;
        for(int i = 0; i < entry.Length; i++)
        {
            count++;
        }
        if(entry[entry.Length - 1] == ' ')
        {
            count--;
        }
        return count;   
    }
}
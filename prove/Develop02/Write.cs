using System.Collections.Generic;
public class Write
{   
    public string[] prompts = {"If I could do one thing different today, what would it be?", "What was the best part of my day?", 
                            "Who was the most interesting person I interacted with today?","What was the best part of my day?", 
                            "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
                            "If I had one thing I could do over today, what would it be?"};    
    
    public string take_entry()
    {
        Console.Write("> ");
        string entry = Console.ReadLine();
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
}
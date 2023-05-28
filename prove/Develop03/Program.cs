using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int rand_num = rnd.Next(2);

        Scriptures scripture = new Scriptures();
        Reference reference = new Reference();
        ChooseWords choose_words = new ChooseWords();
        Finished finished = new Finished();

        string chosen_scripture = scripture.Pick_Scripture(rand_num);
        string chosen_ref = reference.Pick_Reference(rand_num);
        Console.Clear();
        Console.WriteLine(chosen_ref + " " + chosen_scripture);

        bool fin = false;

        string user_input = "";
        while(user_input != "quit" || !fin)
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            user_input = Console.ReadLine();
            if(user_input.ToLower() == "quit")
            {
                Console.Clear();
                fin = true;
            }
            else if(user_input == "")
            {
                chosen_scripture = choose_words.Remove_Words(chosen_scripture);
                chosen_scripture = choose_words.Remove_Words(chosen_scripture);
                chosen_scripture = choose_words.Remove_Words(chosen_scripture);
                fin = finished.Check(chosen_scripture);
                if(fin)
                {
                    Console.WriteLine(chosen_ref + " " + chosen_scripture);
                    Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine(chosen_ref + " " + chosen_scripture);
                }

            }
            else
            {
                Console.WriteLine("That is not a valid entry.");
            }
        }
    }
}
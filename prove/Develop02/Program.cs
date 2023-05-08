using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool keep_going = true;
        List<string> to_be_saved = new List<string>();
        while(keep_going)
        {
            Console.WriteLine("Please select one of the folowing options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            int input = Convert.ToInt32(Console.ReadLine());

            Write write = new Write();
            

            switch(input)
            {
                case 1:
                    Console.WriteLine("Starting write");

                    string prompt = write.rand_prompt();
                    string entry = write.take_entry();
                    DateTime currentDateTime = DateTime.Now;
                    to_be_saved.Add("Date: " + currentDateTime + " - Prompt: " + prompt + "\r\nEntry: " + entry + "\r\n");
                    break;
                case 2:
                    for(int i = 0; i < to_be_saved.Count; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine(to_be_saved[i]);
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Load load = new Load();
                    string load_file = load.loading();
                    to_be_saved.Add(File.ReadAllText(load_file));
                    break;
                case 4:
                    Save save = new Save();
                    string file = save.Saving();
                    System.IO.File.WriteAllLines(file, to_be_saved);
                    break;
                case 5:
                    Console.WriteLine("Quitting...");
                    keep_going = false;
                    break;
                default:
                    Console.WriteLine("this is default");
                    break;
            }
        }
    }
}
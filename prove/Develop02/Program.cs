using System;
using System.Linq;
using System.Collections.Generic;

/*
    Additions:
    1 - I added a word count and character count for each entry.
    2 - I added the ability for the program to understand that a 
        trailing space does not count as an extra word. 
    3 - I also added logic to ensure that if someone added a space 
        before a !, ?, or period, that it wouldn't count that as
        another word.

    Example: "Entry: Amazing Work !", will count as 2 words, 
            not 3 because of the space before the exclamation mark.

*/
class Program
{
    static void Main(string[] args)
    {
        bool keep_going = true;
        List<string> to_be_saved = new List<string>();
        while(keep_going)
        {
            //tell the user their options
            Console.WriteLine("Please select one of the folowing options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            //turn their input into an integer
            int input = Convert.ToInt32(Console.ReadLine());

            //create an instance of the Write Class
            Write write = new Write();
            
            //determine which input was selected
            switch(input)
            {
                //Write
                case 1:
                    //get a random prompt from list
                    string prompt = write.rand_prompt();
                    //take in the entry
                    string entry = write.take_entry();
                    //count the words and characters
                    int w_count = write.word_count();
                    int c_count = write.char_count(); 
                    //instatiate the day and time
                    DateTime currentDateTime = DateTime.Now;
                    //create string that will be saved in file
                    to_be_saved.Add("Date: " + currentDateTime + " - Prompt: " + prompt + "\r\nWord Count: " + w_count + " Character Count: " + c_count + "\r\nEntry: " + entry + "\r\n");
                    break;
                //Display
                case 2:
                    for(int i = 0; i < to_be_saved.Count; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine(to_be_saved[i]);
                        Console.WriteLine();
                    }
                    break;
                //Load
                case 3:
                    Load load = new Load();
                    string load_file = load.loading();
                    to_be_saved.Add(File.ReadAllText(load_file));
                    break;
                //Save
                case 4:
                    Save save = new Save();
                    string file = save.Saving();
                    System.IO.File.WriteAllLines(file, to_be_saved);
                    break;
                //Quit
                case 5:
                    Console.WriteLine("Quitting...");
                    keep_going = false;
                    break;
                //Just in case someone divides by zero...
                default:
                    Console.WriteLine("this is default");
                    break;
            }
        }
    }
}
public class Save 
{
    public string Saving()
    {
        Console.WriteLine();
        Console.Write("Please provide a save file name: ");
        string file = Console.ReadLine();
        return file;
    }
}
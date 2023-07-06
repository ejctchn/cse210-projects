public class Video
{
    private string title;
    private string author = "Eli Cutchen";
    private int length;
    private Random rnd = new Random();
    List<string> comments_on_video = new List<string>();
    List<string> possible_titles = new List<string>();
    Comments comments = new Comments();
    public Video()
    {
        possible_titles.Add("The most exciting video you will ever see!");
        possible_titles.Add("Man Frontflips over a car");
        possible_titles.Add("Back Home!");
        possible_titles.Add("How to make a paracord necktie");
        possible_titles.Add("Does milk really help your bones?");
        possible_titles.Add("This may be the last video you ever see...");   
    }
    public void displayVideoDetails()
    {
        Console.WriteLine("\nVIDEOS"); 
        for(int j = 0; j < 3; j++)
        {
            //whipe the previous comments out of the list 
            comments_on_video.Clear();
            for(int i = 0; i < 3; i++)
            {
                comments_on_video.Add(comments.makeComment());
            }
            int rand_num = rnd.Next(possible_titles.Count);
            title = possible_titles[rand_num];
            length = rnd.Next(1, 800);
            
            Console.WriteLine($"\nTitle: {title}");
            Console.WriteLine($"Uploaded by: {author}");
            Console.WriteLine($"Length of video (in seconds): {length}");
            Console.WriteLine("Comments:");
            for(int i = 0; i < comments_on_video.Count; i++)
            {
                Console.WriteLine(comments_on_video[i]);
            }
        }
    }

}
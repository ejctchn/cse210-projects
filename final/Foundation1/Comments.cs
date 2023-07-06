public class Comments
{
    private List<string> all_comments = new List<string>();
    private List<string> all_authors = new List<string>();
    private Random rnd = new Random();
    private string text;
    private string comment_author;

    public Comments()
    {
        all_comments.Add("Great Video!");
        all_comments.Add("Can't wait for the next one!");
        all_comments.Add("Keep up the great work!");
        all_comments.Add("I can't believe this video exists.");
        all_comments.Add("Do better...");
        all_comments.Add("Is that it? Disappointing...");
        all_comments.Add("I want my BB back!");
        all_comments.Add("To believe what I'm about to tell you, you need to believe in the impossible.");
        all_comments.Add("What is real?");
        all_comments.Add("I will never buy this product... 2 Nephi 9:51");

        all_authors.Add("Lex Luthor");
        all_authors.Add("Clark Kent");
        all_authors.Add("Grant Gustin");
        all_authors.Add("Steven Strange");
        all_authors.Add("Peter Parker");
        all_authors.Add("Mads Mikkelsen");
    }
    public string makeComment()
    {
        //get random comment author
        int rand_num = rnd.Next(all_authors.Count);
        comment_author = all_authors[rand_num];

        //get random comment
        rand_num = rnd.Next(all_comments.Count);
        text = all_comments[rand_num];

        //put it all together and whaddya get?
        string final_comment = $"{comment_author}: {text}";

        return final_comment;
    }
}
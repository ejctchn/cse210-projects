public class Scriptures
{
    private string [] scripts = 
    {
        // 1 Nephi 3:7
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        // Jacob 2:18-19
        "But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted."
    };

    public string Pick_Scripture(int rand_num)
    {
        string chosen_scrip = scripts[rand_num];
        return chosen_scrip;
    }
}
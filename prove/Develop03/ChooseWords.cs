public class ChooseWords
{
    Random rnd = new Random();
    public string Remove_Words(string chosen_scripture)
    {
        bool word_not_found = true;
        string trimmed = " ";
        while(word_not_found)
        {
            string[] split_scrip = chosen_scripture.Split(" ");
            int rand_word_index = rnd.Next(split_scrip.Length);
            int word_length = split_scrip[rand_word_index].Length;
            string replaced_word = "";
            char first_letter = ' ';
            string new_scrip = "";

            try
            {
                first_letter = split_scrip[rand_word_index][0];
            }
            catch(IndexOutOfRangeException)
            {
                word_not_found = false;
                break;
            }
            if(first_letter == '_')
            {
            }
            else
            {
                for(int i = 0; i < word_length; i++)
                {
                    replaced_word += "_";
                }
                word_not_found = false;
            }

            
            split_scrip[rand_word_index] = replaced_word;
            for(int k = 0; k < split_scrip.Length; k++)
            {
                new_scrip += split_scrip[k] + " ";
            }
            Console.Clear();
            trimmed = new_scrip.Trim();
        }

        return trimmed;
    }

}
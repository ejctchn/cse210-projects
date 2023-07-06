public class DisplayGoals
{
    int sep_counter;
    public void displayGoals(List<string> goals_list)
    {
        for(int i = 0; i < goals_list.Count; i++) 
        {
            //check to see if it is a simple goal
            if(goals_list[i][0] == '1')
            {
                //check to see if completed
                if(goals_list[i][2] == '1')
                {
                    Console.Write("[x]");  
                }
                //is not completed
                else
                {
                    Console.Write("[ ]");
                }
            }

            for(int j = 3; j < goals_list[i].Length; j++)
            {
                if(goals_list[i][j] == '+')
                {
                    //check for description to put parenthasis around it
                    if(sep_counter == 1)
                    {
                        Console.Write(" (");
                        sep_counter++;
                    }
                    else if(sep_counter == 2)
                    {
                        Console.Write(") ");
                        sep_counter++;
                    }
                    else
                    {
                        sep_counter++;
                        Console.Write(" ");
                    }
                }
                else if(j == goals_list[i].Length - 1)
                {
                    Console.WriteLine(goals_list[i][j]);
                }
                else
                {
                    Console.Write(goals_list[i][j]);
                }
        
            }
            
        }
    }
}
class Prompt
{
    private string[] reflection_prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] reflection_questions = 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string[] list_prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    Random rnd = new Random();
    string rand_prompt;
    int rand_num;
    public string ReturnPrompt(int selection)
    {

        switch(selection)
        {
            //reflection prompts
            case 1:
                rand_num = rnd.Next(reflection_prompts.Length);
                rand_prompt = reflection_prompts[rand_num];
                break;
            // reflection questions
            case 2:
                rand_num = rnd.Next(reflection_questions.Length);
                rand_prompt = reflection_questions[rand_num];
                break;
            //list prompts
            case 3:
                break;
            //error handling
            default:
                Console.WriteLine("There was an issue with the Switch Statement.");
                break;
        }
        return rand_prompt;
    }
}
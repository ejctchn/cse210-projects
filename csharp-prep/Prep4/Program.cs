using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        List<float> sort_numbers = new List<float>();
        List<float> pos_numbers = new List<float>();
        bool keep_going = true;
        float num = 0;
        float sum = 0;
        
        int count = 0;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        while(keep_going)
        {
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            count++;
            if(num == 0)
            {
                keep_going = false;
            }
            else
            {
                numbers.Add(num);
            }
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i] > 0)
            {
                sum += numbers[i];
                pos_numbers.Add(numbers[i]);
            }
            else
            {
                sum += numbers[i];
            }
        }

        float average = sum/(count - 1);
        float max = numbers.Max();
        
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
        
        numbers.Sort();
        pos_numbers.Sort();
        Console.WriteLine("The smallest positive number is: " + pos_numbers[0]);

        Console.WriteLine("The sorted list is: ");
        for(int j = 0; j < numbers.Count; j++)
        {
            Console.WriteLine(numbers[j]);
        }
        
    }
}
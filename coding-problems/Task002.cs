/*
 * "Write a program that prints the numbers from 1 to 100.
 * But for multiples of three print Fizz instead of the number and for the multiples of five print Buzz.
 * For numbers which are multiples of both three and five print FizzBuzz.
*/

public class Task002
{
    private bool isDivBy3 = false;
    private bool isDivBy5 = false;
    
    public void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            // Init the checks
            isDivBy3 = false;
            isDivBy5 = false;

            if (i % 3 == 0)
            {
                isDivBy3 = true;
            }
            
            if (i % 5 == 0)
            {
                isDivBy5 = true;
            }
            
            // Print handling
            switch (isDivBy3)
            {
                case true when isDivBy5:
                    Console.WriteLine("FizzBuzz");
                    continue;
                case true:
                    Console.WriteLine("Fizz");
                    continue;
            }

            if (isDivBy5)
            {
                Console.WriteLine("Buzz");
                continue;
            }
            
            Console.WriteLine(i.ToString());
        }
    }
}
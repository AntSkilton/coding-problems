/* 
 *  Print out all the prime numbers from 1 to 250
 */

public class Task004
{
    private List<int> m_foundPrimeNums = new();

    public void Main()
    {
        m_foundPrimeNums.Add(2); // Special handling for 2 as it's the only even prime

        // Start at 3 as 1 isn't prime. Remove all even numbers with iteration
        for (int i = 3; i <= 250; i+=2)
        {
            // Check against other numbers going up to it
            for (int j = 3; j <= i; j+=2)
            {
                // If there's a remainder, ignore it and move on
                if (i % j != 0) continue;
                
                // It's either a divisor or the number itself
                if (i == j)
                {
                    m_foundPrimeNums.Add(i);
                }

                // If it's a divisor, then we know it can't be prime
                break;
            }
        }

        Console.WriteLine($"Prime Numbers:");
        foreach (var num in m_foundPrimeNums)
        {
            Console.WriteLine(num);
        }
    }
}

    

   
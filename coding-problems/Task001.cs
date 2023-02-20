/*
 * Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
 * For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
*/

public class Task001
{
    private readonly int m_targetNumber = 17;
    readonly IList<int> m_inputListOne = new List<int>(new[]
    { 
        10, 25, 3, 7
    });

    public void Main()
    {
        for (int x = 0; x < m_inputListOne.Count; x++)
        { 
            for (int y = 0; y < m_inputListOne.Count; y++)
            {
                // In the 2D array, we don't want to check the same values twice (nor itself), so pass. 
                if (m_inputListOne[y] <= m_inputListOne[x])
                {
                    continue;
                }

                if (m_inputListOne[y] + m_inputListOne[x] != m_targetNumber) continue;
                Console.WriteLine($"The results of {m_inputListOne[y]} and {m_inputListOne[x]} add to make {m_targetNumber}!");
                return;
            }
        }
        
        Console.WriteLine($"Nothing adds to sum to make {m_targetNumber}.");
    }
}
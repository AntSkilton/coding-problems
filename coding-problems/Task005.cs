/* 
 * Given an array of integers, find the first missing positive integer in linear time and constant space.
 * In other words, find the lowest positive integer that does not exist in the array.
 * The array can contain duplicates and negative numbers as well.
 * For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
 * You can modify the input array in-place.
 */

public class Task005
{
   readonly IList<int> m_inputList1 = new List<int>(new[] { 3, 4, -1, 1 });
   readonly IList<int> m_inputList2 = new List<int>(new[] { 4, 5, -3, -2, 1, 7, -4 });
   readonly IList<int> m_inputList3 = new List<int>(new[] { 1, -2, 5, -4, 1, 3, -4, 6, 0, 7 });

   private int GetLowestInt(IList<int> intList)
   {
       HashSet<int> posNumList = new HashSet<int>();
       foreach (var num in intList)
       {
           if (num == 0) // Catch and remove zeros
           {
               continue;
           }
           posNumList.Add(Math.Abs(num)); // Get the absolute
       }
       
       var distinctList = posNumList.Distinct().ToList(); // Remove dupes and back to a list.
       distinctList.Sort(); // Order

       for (int i = 0; i < distinctList.Count; i++)
       {
          var value = distinctList[i];
           
           if (value == i+1) // List pos to the cycle number 
           {
               continue;
           }
           return i+1; // Found the lowest gap
       }

       return distinctList.Count + 1; // No gaps in list, so return the next highest value after the list
   }
   
   public void Main()
    {
        Console.WriteLine($"Lowest missing: {GetLowestInt(m_inputList1)}");
        Console.WriteLine($"Lowest missing: {GetLowestInt(m_inputList2)}");
        Console.WriteLine($"Lowest missing: {GetLowestInt(m_inputList3)}");
    }
}
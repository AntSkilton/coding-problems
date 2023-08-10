/*
 * 
 */

public class Task006
{
    private List<List<int>> arr = new();
    private List<int> list1 = new() { 3 };
    private List<int> list2 = new() { 11, 2, 4 };
    private List<int> list3 = new() { 4, 5, 6 };
    private List<int> list4 = new() { 10, 8, -12 };
    
    private static int GetAbsolute(int num)
    {
        if (num < 0)
        {
            num = num * -1;
        }

        return num;
    }

    private static int diagonalDifference(List<List<int>> arr)
    {
        var size = arr[0][0] -1;
        arr.RemoveAt(0);
        int leftToRightSum = 0;
        int rightToLeftSum = 0;

        for (int i = 0; i < size +1; i++)
        {
            leftToRightSum += arr[i][i] * -1;
            rightToLeftSum += arr[i][size-i] * -1;// 0,2   1,1    2,0
        }
        
        return (leftToRightSum - rightToLeftSum) * -1;
    }

    public void Main()
    {
        arr.Add(list1);
        arr.Add(list2);
        arr.Add(list3);
        arr.Add(list4);
        Console.WriteLine(diagonalDifference(arr));
    }
}
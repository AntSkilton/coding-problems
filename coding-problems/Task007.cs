/* 
 * Return the pattern 1,-2,3,-4,0,6,-7,8,-9,0... up to any given positive int as an input.
 */

public class Task007
{
	public void Main()
	{
		Console.WriteLine(AggregateFirstMiddleAndLast(new List<int> { 6, 5, 9, 11, 7, 1 }));
	}

	private int AggregateFirstMiddleAndLast(List<int> inputList)
	{
		bool isEven = inputList.Count % 2 == 0;
		var middleValue = inputList[((inputList.Count - 1) / 2)];

		if (isEven)
		{
			int oneUnderHalf = inputList[(inputList.Count / 2) - 1];
			int oneOverHalf = inputList[inputList.Count / 2];
			middleValue = oneUnderHalf + oneOverHalf;
		}

		return inputList[0] + middleValue + inputList[^1];
	}
}
namespace data_structures.Sorting
{
	using System;

	public class BubbleSorter
	{
		// Bubble sort also callled sinking sort
		// Compares every adjacent item with the next
		// Swaps them when neccessary
		// O(n2)
		public int[] Sort(int[] array)
		{
			Console.Out.WriteLine(string.Join(",", array));

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 1; j < array.Length; j++)
				{
					if (array[j] < array[j - 1])
					{
						var temp = array[j - 1];
						array[j - 1] = array[j];
						array[j] = temp;
					}
				}

				Console.Out.WriteLine(string.Join(",", array));
			}

			return array;
		}
		
	}
}

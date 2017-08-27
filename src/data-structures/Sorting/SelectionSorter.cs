using System;

namespace data_structures.Sorting
{
	public class SelectionSorter
	{
		// Selection sort
		// Compare first with every item
		// Then second with every item
		// And so on
		// Swap if required
		// O(n2)
		public int[] Sort(int[] array)
		{
			Console.Out.WriteLine(string.Join(",", array));

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[j] < array[i])
					{
						var temp = array[j];
						array[j] = array[i];
						array[i] = temp;
					}
				}

				Console.Out.WriteLine(string.Join(",", array));
			}

			return array;
		}
	}
}

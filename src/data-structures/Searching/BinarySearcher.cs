using System;

namespace data_structures.Searching
{
	public class BinarySearcher
	{
		public int Search(int[] array, int sortAfter)
		{
			if (array.Length == 0)
			{
				return -1;
			}

			return SearchBetween(array, 0, array.Length - 1, sortAfter);
		}

		private static int SearchBetween(int[] array, int from, int to, int sortAfter)
		{
			if (to < from || from > to)
			{
				return -1; // not found
			}

			if (from == to)
			{
				if (array[from] == sortAfter)
				{
					return array[from];
				}
				return -1; // not found
			}

			int mid = ((to - from) / 2) + from;

			if (array[mid] == sortAfter)
			{
				return array[mid];
			}
			else if (array[mid] > sortAfter)
			{
				// search in lower half
				return SearchBetween(array, from, mid - 1, sortAfter);
			}
			else if (array[mid] < sortAfter)
			{
				// search in upper half
				return SearchBetween(array, mid + 1, to, sortAfter);
			}

			return -1; // not found
		}
	}
}

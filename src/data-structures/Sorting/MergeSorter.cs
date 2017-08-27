namespace data_structures.Sorting
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class MergeSorter
	{
		// MergeSort
		// Recursively split the array into 2 subarrays
		// Sort each subarray using the same process
		// Merge 2 sorted arrays back together
		// O(nlogn)
		// Needs a lot of auxilary memory
		public int[] Sort(int[] array)
		{
			if(array.Length < 2)
			{
				return array;
			}

			int mid = array.Length / 2;
			var sorted1 = Sort(array.Take(mid).ToArray());
			var sorted2 = Sort(array.Skip(mid).ToArray());

			return Merge(sorted1, sorted2);
		}

		private int[] Merge(int[] sorted1, int[] sorted2)
		{
			int[] sorted = new int[sorted1.Length + sorted2.Length];
			var pointer1 = 0;
			var pointer2 = 0;
			var sortedPointer = 0;

			while(pointer1 < sorted1.Length || pointer2 < sorted2.Length)
			{
				if (pointer1 == sorted1.Length)
				{
					sorted[sortedPointer] = sorted2[pointer2];
					sortedPointer++;
					pointer2++;
				}
				else if (pointer2 == sorted2.Length)
				{
					sorted[sortedPointer] = sorted1[pointer1];
					sortedPointer++;
					pointer1++;
				}
				else if(sorted1[pointer1] < sorted2[pointer2])
				{
					sorted[sortedPointer] = sorted1[pointer1];
					sortedPointer++;
					pointer1++;
				}
				else if (sorted2[pointer2] < sorted1[pointer1])
				{
					sorted[sortedPointer] = sorted2[pointer2];
					sortedPointer++;
					pointer2++;
				}				 
			}

			return sorted.ToArray();
		}
	}
}

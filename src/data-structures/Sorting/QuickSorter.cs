using System;
using System.Linq;

namespace data_structures.Sorting
{
	public class QuickSorter
	{
		// Quick sort
		// Use a pivot to move all the smaller items to the left and others greater to the right
		// Swap as neccessary
		// Then do the same on each subarray
		// Good case O(nlogn)
		// Bad case O(nlogn)
		public int[] Sort(int[] array)
		{
			if (array.Length < 2)
			{
				return array;
			}

			var pivot = array[array.Length - 1];

			var wall = 0;

			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i] < pivot)
				{
					var rightOfWall = array[wall];
					array[wall] = array[i];
					array[i] = rightOfWall;
					wall = wall + 1;
				}
			}

			// move the pivot to the right of the wall
			var rightOfWall2 = array[wall];
			array[wall] = array[array.Length - 1];
			array[array.Length - 1] = rightOfWall2;

			var arrayLessThanPivot = array.Take(wall).ToArray();
			var arrayMoreThanPivot = array.Skip(wall).ToArray();

			return Sort(arrayLessThanPivot).Concat(Sort(arrayMoreThanPivot)).ToArray();
		}
	}
}

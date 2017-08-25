using System;

namespace data_structures.Sorting
{
	public class QuickSorter
	{
		// Quick sort
		// Use a pivot to move all the smaller items to the left and others greater to the right
		// Swap as neccessary
		// Then do the same on subarray
		// Good case O(nlogn)
		// Bad case O(nlogn)
		public int[] Sort(int[] array)
		{
			if(array.Length < 2)
			{
				return array;
			}

			// ok good luck
			var pivot = array[array.Length - 1];

			var wall = 0;

			for(int i = 0; i < array.Length - 1 ; i++)
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

			var arrayLessThanPivot = CopyArray(array, 0, wall - 1);
			var arrayMoreThanPivot = CopyArray(array, wall, array.Length - 1);
			array = AddArrays(Sort(arrayLessThanPivot) , Sort(arrayMoreThanPivot));
			return array;
		}

		private int[] AddArrays(int[] a1, int[] a2)
		{
			var array = new int[a1.Length + a2.Length];
		    for (int i = 0; i < a1.Length; i++)
			{
				array[i] = a1[i];
			}

			for (int i = 0; i < a2.Length; i++)
			{
				array[a1.Length + i] = a2[i];
			}

			return array;
		}

		private int[] CopyArray(int[] array, int start, int end)
		{
			var newArray = new int[end-start + 1];

			for (int i = 0; i<end-start + 1; i++ )
			{
				newArray[i] = array[start + i];
			}

			return newArray;
		}
	}
}

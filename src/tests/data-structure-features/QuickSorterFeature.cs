namespace data_structure_features
{
	using Xbehave;
	using data_structures.Sorting;

	public class QuickSorterFeature
	{
		[Scenario]
		[Example(new int[] { 12, 2, 36, 45, 13 }, new int[] { 2, 12, 13, 36, 45 })]
		[Example(new int[] { 46, 12, 2, 36, 45, 13 }, new int[] { 2, 12, 13, 36, 45, 46 })]
		[Example(new int[] { 6, 5, 4, 3 }, new int[] { 3, 4, 5, 6 })]
	    [Example(new int[] { 28, 34, 23, 24, 16, 4, 33, 9, 90, 87, 26, 27, 17, 2, 5, 6, 62 }, new int[] { 2, 4, 5, 6, 9, 16, 17, 23, 24, 26, 27, 28, 33, 34, 62, 87, 90 })]
		public void QuickSortTest(int[] unsorted, int[] expected, int[] sorted, QuickSorter quickSorter)
		{
			"Given an unsorted array"
				.x(() =>
				{
				});

			"And a QuickSorter"
				.x(() =>
				{
					quickSorter = new QuickSorter();
				});

			"When I QuickSort it"
				.x(() =>
				{
					sorted = quickSorter.Sort(unsorted);
				});

			"Then it is sorted as I expect"
				.x(() =>
				{
					Xunit.Assert.Equal(expected, sorted);
				});

		}
	}
}

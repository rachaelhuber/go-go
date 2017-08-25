namespace data_structure_features
{
	using Xbehave;
	using data_structures.Sorting;

	public class BubbleSorterFeature
	{
		[Scenario]
		[Example(new int[] { 12, 2, 36, 45, 13 }, new int[] { 2, 12, 13, 36, 45 })]
		[Example(new int[] { 46, 12, 2, 36, 45, 13 }, new int[] { 2, 12, 13, 36, 45, 46 })]
		[Example(new int[] { 6, 5, 4, 3 }, new int[] { 3, 4, 5, 6 })]
		[Example(new int[] { 4, 16, 28, 34, 23, 24, 16, 17, 4, 33, 9, 90, 87, 34, 26, 27, 28, 17, 2, 5, 6, 62 }, new int[] { 2, 4, 4, 5, 6, 9, 16, 16, 17, 17, 23, 24, 26, 27, 28, 28, 33, 34, 34, 62, 87, 90 })]
		public void BubbleSortTest(int[] unsorted, int[] expected, int[] sorted, BubbleSorter bubbleSorter)
		{
			"Given an unsorted array"
				.x(() =>
				{
				});

			"And a BubbleSorter"
				.x(() =>
				{
					bubbleSorter = new BubbleSorter();
				});

			"When I BubbleSort it"
				.x(() =>
				{
					sorted = bubbleSorter.Sort(unsorted);
				});

			"Then it is sorted as I expect"
				.x(() =>
				{
					Xunit.Assert.Equal(expected, sorted);
				});

		}
	}
}

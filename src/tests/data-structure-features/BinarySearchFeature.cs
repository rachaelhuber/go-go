namespace data_structure_features
{
	using Xbehave;
	using data_structures.Searching;

	public class BinarySearchFeature
	{
		[Scenario]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 1, 1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 2, -1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 3, 3)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 4, 4)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 5, 5)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 6, -1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 40, 40)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 41, -1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 42, 42)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 43, -1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 44, 44)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 45, -1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 52, -1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 53, 53)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 54, -1)]
		[Example(new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53 }, 55, -1)]
		public void BinarySearchTest(int[] sorted, int sort, int expected, int found, BinarySearcher binarySearcher)
		{
			"Given a sorted array"
				.x(() =>
				{
				});

			"And a BinarySearch"
				.x(() =>
				{
					binarySearcher = new BinarySearcher();
				});

			"When I search for"
				.x(() =>
				{
					found = binarySearcher.Search(sorted, sort);
				});

			"Then it is sorted as I expect"
				.x(() =>
				{
					Xunit.Assert.Equal(expected, found);
				});
		}
	}
}

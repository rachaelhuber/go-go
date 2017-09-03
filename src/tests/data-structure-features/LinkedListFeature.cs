namespace data_structure_features
{
	using System.Collections.Generic;
	using Xbehave;

	public class LinkedListFeature
	{
		[Scenario]
		public void LinkedListTest(LinkedList<string> list)
		{
			"Given a C# linked list".x(() =>
			{
				list = new LinkedList<string>();
			});

			"When I add items".x(() =>
			{
				list.AddFirst("rach");
				list.AddLast("smith");
			});

			"Then the count is 2".x(() =>
			{
				Xunit.Assert.Equal(2, list.Count);
			});
		}
	}
}

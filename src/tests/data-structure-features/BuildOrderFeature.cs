namespace data_structure_features
{
	using data_structures.Questions;
	using System.Collections.Generic;
	using System.Linq;
	using Xbehave;

	public class BuildOrderFeature
	{
		[Scenario]
		public void BuildOrderTest(Project[] buildOrder, string[] projects, List<KeyValuePair<string, string>> dependancies)
		{
			"Given a list of projects and dependancies".x(() => 
			{
				projects = new[] { "a", "b", "c", "d", "e", "f" };
				dependancies = new List<KeyValuePair<string, string>>()
				{
					// d is dependant on a
					new KeyValuePair<string, string>("a", "d"),
					new KeyValuePair<string, string>("f", "b"),
					new KeyValuePair<string, string>("b", "d"),
					new KeyValuePair<string, string>("f", "a"),
					new KeyValuePair<string, string>("d", "c")
				};
			});

			"When I calculate the build order".x(() => 
			{
				var buildOrderCalculator = new BuildOrderCalculator();
				buildOrder = buildOrderCalculator.FindBuildOrder(projects, dependancies);
			});

			"Then the build order is as expected".x(() => 
			{
				var expected = new string[] { "e", "f","b", "a", "d", "c"};
				var actual = buildOrder.Select(b => b.GetName()).ToArray();

				Xunit.Assert.Equal(expected, actual);
			});
		}
	}
}

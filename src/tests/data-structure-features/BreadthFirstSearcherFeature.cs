namespace data_structure_features
{
	using data_structures.DataStructures;
	using data_structures.Searching;
	using System.Collections.Generic;
	using Xbehave;
	using Xunit;

	public class BreadthFirstSearcherFeature
	{
		[Scenario]
		public void BreadthFirstSearchTest(Graph graph, string[] order)
		{
			// a --- b ----------f---------h
			//  -               -
			//   -           -
			//   -        -
			//   c------d-------e----------g
			"Given an undirected graph".x(() =>
			{
				graph = new Graph();

				var a = new GraphNode() { name = "a" };
				var b = new GraphNode() { name = "b" };
				var c = new GraphNode() { name = "c" };
				var d = new GraphNode() { name = "d" };
				var e = new GraphNode() { name = "e" };
				var f = new GraphNode() { name = "f" };
				var g = new GraphNode() { name = "g" };
				var h = new GraphNode() { name = "h" };

				a.children = new GraphNode[] { b, c };
				b.children = new GraphNode[] { a, f };
				c.children = new GraphNode[] { a, d };
				d.children = new GraphNode[] { e, c, f };
				e.children = new GraphNode[] { d, g };
				f.children = new GraphNode[] { h, b, d };
				g.children = new GraphNode[] { e };
				h.children = new GraphNode[] { f };

				graph.root = a;
			});

			"When I do a breadth first search".x(() =>
			{
				var searcher = new BreadthFirstSearcher();
				order = searcher.Search(graph);
			});

			"Then the print order is as expected".x(() =>
			{
				var expected = new[] { "a", "b", "c", "f", "d", "h", "e", "g"};
				Assert.Equal(expected, order);
			});
		}
	}
}

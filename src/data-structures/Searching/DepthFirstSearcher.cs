namespace data_structures.Searching
{
	using data_structures.DataStructures;
	using System.Collections.Generic;

	public class DepthFirstSearcher
	{
		public string[] Search(Graph graph)
		{
			var order = new List<string>();

			var root = graph.root;

			NavigateAndAddToPrintOrder(order, root);

			return order.ToArray();
		}

		private static void NavigateAndAddToPrintOrder(List<string> order, GraphNode node)
		{
			order.Add(node.name);

			foreach (var child in node.children)
			{
				if (order.Contains(child.name))
				{
					continue;
				}

				NavigateAndAddToPrintOrder(order, child);
			}
		}
	}
}

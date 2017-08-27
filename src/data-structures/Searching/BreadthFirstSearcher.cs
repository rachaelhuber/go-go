namespace data_structures.Searching
{
	using data_structures.DataStructures;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	public class BreadthFirstSearcher
	{
		public string[] Search(Graph graph)
		{
			var order = new List<string>();
			var queue = new Queue();

			var root = graph.root;
			NavigateAndAddToPrintOrder(order, queue, root);

			return order.ToArray();
		}

		private static void NavigateAndAddToPrintOrder(List<string> order, Queue queue, GraphNode node)
		{
			order.Add(node.name);

			foreach (var child in node.children)
			{
				if (order.Contains(child.name) || queue.ToArray().Any(n => ((GraphNode)n).name == child.name))
				{
					continue;
				}
	
				queue.Enqueue(child);
			}

			if (queue.Count == 0)
			{
				return;
			}

			var next = queue.Dequeue();

			NavigateAndAddToPrintOrder(order, queue, (GraphNode)next);
		}
	}
}

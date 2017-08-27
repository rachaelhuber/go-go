namespace data_structures.Searching
{
	using data_structures.DataStructures;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	public class BreadthFirstSearcher
	{
		public string[] PrintOrder(Graph graph)
		{
			var printOrder = new List<string>();
			var queue = new Queue();
			var visited = new HashSet<string>();

			queue.Enqueue(graph.root);
			
			while (queue.Count > 0)
			{
				var next = (GraphNode)queue.Dequeue();

				if (visited.Contains(next.name))
				{
					continue;
				}

				printOrder.Add(next.name);
				visited.Add(next.name);

				foreach (var child in next.children)
				{
					queue.Enqueue(child);
				}				
			}

			return printOrder.ToArray();
		}
	}
}

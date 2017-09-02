namespace data_structures.DataStructures
{
	using System;

	public class Graph
	{
		public GraphNode root;
	}

	public class GraphNode
	{
		public String name;
		public GraphNode[] children;
	}
}
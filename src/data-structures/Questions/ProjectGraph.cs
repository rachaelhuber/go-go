namespace data_structures.DataStructures
{
	using data_structures.Questions;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class ProjectGraph
	{
		private List<Project> nodes = new List<Project>();
		private Dictionary<string, Project> map = new Dictionary<string, Project>();

		public List<Project> GetNodes()
		{
			return nodes;
		}

		public void CreateNode(string name)
		{
			GetOrCreateNode(name);
		}

		private Project GetOrCreateNode(string name)
		{
			if(!map.ContainsKey(name))
			{
				Project project = new Project(name);
				nodes.Add(project);
				map.Add(name, project);
			}

			return map[name];
		}

		public void AddEdge(string startName, string endName)
		{
			Project isDependancy = GetOrCreateNode(startName);
			Project hasDependancy = GetOrCreateNode(endName);
			isDependancy.AddNeighbour(hasDependancy);
		}
	}	
}

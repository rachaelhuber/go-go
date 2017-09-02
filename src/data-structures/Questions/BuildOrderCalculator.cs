using System;
using data_structures.DataStructures;
using System.Collections.Generic;

namespace data_structures.Questions
{
	public class BuildOrderCalculator
	{
		public Project[] FindBuildOrder(string[] projects, List<KeyValuePair<string, string>> dependancies)
		{
			ProjectGraph graph = BuildGraph(projects, dependancies);
			return OrderProjects(graph.GetNodes());
		}

		private Project[] OrderProjects(List<Project> projects)
		{
			Project[] order = new Project[projects.Count];

			int endOfList = AddNonDependantProjects(order, projects, 0);

			int toBeProcessed = 0;
			while (toBeProcessed < order.Length)
			{
				Project current = order[toBeProcessed];

				if(current == null)
				{
					return null;
				}

				var children = current.GetProjectsThatDependOnMe();
				foreach(var child in children)
				{
					child.DecrementDependancies();
				}

				endOfList = AddNonDependantProjects(order, children, endOfList);
				toBeProcessed++;
			}

			return order;

		}

		private ProjectGraph BuildGraph(string[] projects, List<KeyValuePair<string, string>> dependancies)
		{
			ProjectGraph graph = new ProjectGraph();
			foreach(string project in projects)
			{
				graph.CreateNode(project);
			}

			foreach(var dependancy in dependancies)
			{
				graph.AddEdge(dependancy.Key, dependancy.Value);
			}

			return graph;
		}

		private int AddNonDependantProjects(Project[] order, List<Project> projects, int offset)
		{
			foreach(Project project in projects)
			{
				if(project.GetNumberOfDependancies() == 0)
				{
					order[offset] = project;
					offset++;
				}
			}

			return offset;
		}
	}
}

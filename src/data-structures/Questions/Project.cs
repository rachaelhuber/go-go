using System;
using System.Collections.Generic;

namespace data_structures.Questions
{
	public class Project
	{
		private string name;
		private int dependancies = 0;
		private List<Project> projectsThatDependOnMe = new List<Project>();
		private Dictionary<string, Project> map = new Dictionary<string, Project>();

		public Project(string name)
		{
			this.name = name;
		}

		internal void AddNeighbour(Project projectWithADependancy)
		{
			if(!map.ContainsKey(projectWithADependancy.GetName()))
			{
				projectsThatDependOnMe.Add(projectWithADependancy);
				map.Add(projectWithADependancy.GetName(), projectWithADependancy);
				projectWithADependancy.IncrementDependancies();
			}
		}


		public string GetName()
		{
			return name;
		}

		public int GetNumberOfDependancies()
		{
			return dependancies;
		}

		internal List<Project> GetProjectsThatDependOnMe()
		{
			return projectsThatDependOnMe;
		}

		internal void DecrementDependancies()
		{
			this.dependancies--;
		}
		internal void IncrementDependancies()
		{
			this.dependancies++;
		}
	}
}
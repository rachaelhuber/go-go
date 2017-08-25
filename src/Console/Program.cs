namespace Console
{
	using data_structures.Sorting;
	using System;

	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Out.WriteLine("Running Bubble Sort");
			var sorter = new BubbleSorter();
			sorter.Sort(new int[]{ 4, 16, 28, 34, 23, 24, 16, 17, 4, 33, 9, 90, 87, 34, 26, 27, 28, 17, 2, 5, 6, 62 });
			Console.Out.WriteLine();

			Console.Out.WriteLine("Running Selection Sort");
			var sorter2 = new SelectionSorter();
			sorter2.Sort(new int[] { 4, 16, 28, 34, 23, 24, 16, 17, 4, 33, 9, 90, 87, 34, 26, 27, 28, 17, 2, 5, 6, 62 });
			Console.Out.WriteLine();

			Console.Out.WriteLine("Complete, press any key.");
			Console.ReadKey();
		}
	}
}

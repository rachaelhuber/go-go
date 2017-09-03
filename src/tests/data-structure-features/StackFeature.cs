namespace data_structure_features
{
	using System.Collections.Generic;
	using Xbehave;

	public class StackFeature
	{
		[Scenario]
		public void StackTest(Stack<string> stack)
		{
			"Given a C# stack".x(() =>
			{
				stack = new Stack<string>();
			});

			"When I add items".x(() =>
			{
				stack.Push("rach");
				stack.Push("smith");
			});

			"Then the top of the stack comes off".x(() =>
			{
				Xunit.Assert.Equal("smith", stack.Pop());
			});
		}
	}
}

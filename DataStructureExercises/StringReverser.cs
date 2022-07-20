namespace DataStructureExercises
{
	internal class StringReverser
	{
		internal static string Reverse(string input)
		{
			if (input.Length == 1)
				return input;
			else
			{
				var lastIndex = input.Length - 1;
				var inputSubstring = input.Substring(0, lastIndex);

				return input[lastIndex] + Reverse(inputSubstring);
			}
		}
	}
}

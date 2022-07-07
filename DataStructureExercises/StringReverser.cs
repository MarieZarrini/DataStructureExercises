namespace DataStructureExercises
{
	internal class StringReverser
	{
		public static string Reverse(string input)
		{
			if (input.Length == 1)
				return input;
			else
				return input[^1] + Reverse(input[0..^1]);
		}
	}
}

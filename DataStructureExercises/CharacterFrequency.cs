namespace DataStructureExercises
{
	internal class CharacterFrequency
	{
		public static string Calculate(string input)
		{
			var result = input.ToLower().GroupBy(ch => ch).Select(group => new
			{
				Character = group.Key,
				Count = group.Count()
			});

			return string.Join(Environment.NewLine, result);
		}
	}
}

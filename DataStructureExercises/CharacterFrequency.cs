namespace DataStructureExercises
{
	internal class CharacterFrequency
	{
		internal static string Calculate(string input)
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

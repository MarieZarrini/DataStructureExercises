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

		internal static string Calculate2(string input)
		{
			var result = new Dictionary<char, int>();

			foreach (var character in input)
			{
				if (result.ContainsKey(character))
					result[character]++;
				else
					result[character] = 1;
			}

			return string.Join(Environment.NewLine, result);
		}
	}
}

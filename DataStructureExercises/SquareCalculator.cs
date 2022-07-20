namespace DataStructureExercises
{
	internal class SquareCalculator
	{
		internal int[] Numbers { get; set; }


		internal void Calculate()
		{
			Numbers = Numbers.Select(n => n * n).ToArray();
		}

		internal void Calculate2()
		{
			for (int i = 0; i < Numbers.Length; i++)
				Numbers[i] *= Numbers[i];
		}

		internal string GetResult()
		{
			return string.Join(", ", Numbers);
		}
	}
}

namespace DataStructureExercises
{
	internal class SquareCalculator
	{
		public int[] Numbers { get; set; }

		internal void Calculate()
		{
			Numbers = Numbers.Select(n => n * n).ToArray();
		}

		internal string GetResult()
		{
			return string.Join(", ", Numbers);
		}
	}
}

namespace DataStructureExercises
{
	public class SquareCalculator
	{
		public int[] Numbers { get; set; }


		public void Calculate()
		{
			Numbers = Numbers.Select(n => n * n).ToArray();
		}

		public void Calculate2()
		{
			for (int i = 0; i < Numbers.Length; i++)
				Numbers[i] *= Numbers[i];
		}

		public string GetResult()
		{
			return string.Join(", ", Numbers);
		}
	}
}

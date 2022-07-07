namespace DataStructureExercises
{
	internal class SquareCalculator
	{
		public static string Calculate(int[] numbers)
		{
			var result = numbers.Select(n => n * n).ToArray();
			return string.Join(", ", result);
		}
	}
}

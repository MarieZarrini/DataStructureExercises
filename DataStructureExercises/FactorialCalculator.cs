namespace DataStructureExercises
{
	internal class FactorialCalculator
	{
		public static int Calculate(int number)
		{
			if (number == 1)
				return number;
			else
				return number * Calculate(number - 1);
		}
	}
}

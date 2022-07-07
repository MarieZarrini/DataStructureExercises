namespace DataStructureExercises
{
	internal class PowerCalculator
	{
		public static int Calculate(int number, int power)
		{
			if (power == 1)
				return number;
			else
				return number * Calculate(number, power - 1);
		}
	}
}

namespace DataStructureExercises
{
	internal class PowerCalculator
	{
		internal static int Calculate(int number, int power)
		{
			return power == 1 ? number : number * Calculate(number, power - 1);
		}
	}
}

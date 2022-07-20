namespace DataStructureExercises
{
	internal class FactorialCalculator
	{
		internal static int Calculate(int number)
		{
			return number == 1 ? number : number * Calculate(number - 1);
		}
	}
}

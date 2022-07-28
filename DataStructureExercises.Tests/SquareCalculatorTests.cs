using System;
using Xunit;

namespace DataStructureExercises.Tests
{
	public class SquareCalculatorTests
	{
		[Fact]
		public void Numbers_Length_Should_Not_Change_After_Calling_Calculate_Method()
		{
			var numbers = new int[] { 2, 4, 5, 10, 20 };
			SquareCalculator squareCalculator = new() { Numbers = numbers};

			squareCalculator.Calculate();
			bool haveEqualLength = (numbers.Length == squareCalculator.Numbers.Length);

			Assert.True(haveEqualLength);
		}

		[Fact]
		public void GetResult_Should_Return_Empty_String_If_Numbers_Is_Empty()
		{
			var numbers = Array.Empty<int>();
			SquareCalculator squareCalculator = new() { Numbers = numbers };

			var result = squareCalculator.GetResult();

			Assert.Empty(result);
		}
	}
}

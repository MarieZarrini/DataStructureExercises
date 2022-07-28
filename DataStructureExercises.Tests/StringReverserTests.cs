using FluentAssertions;
using System;
using Xunit;

namespace DataStructureExercises.Tests
{
	public class StringReverserTests
	{
		[Fact]
		public void Reverse_Should_Return_Input_If_Input_Length_Equals_One()
		{
			var input = "a";

			var result = StringReverser.Reverse(input);

			Assert.Equal(1, result.Length);
		}

		[Fact]
		public void Reverse_Output_Length_Should_Be_Equal_To_Input_Length()
		{
			var input = "Let's test this";

			var result = StringReverser.Reverse(input);
			bool haveEqualLength = (result.Length == input.Length);

			Assert.True(haveEqualLength);
		}

		[Fact]
		public void Reverse_Should_Throw_Argument_Null_Exception_When_Input_Is_Null_Or_Empty()
		{
			string input = null;

			var reverse = () => StringReverser.Reverse(input);

			reverse.Should().Throw<ArgumentNullException>();
		}
	}
}
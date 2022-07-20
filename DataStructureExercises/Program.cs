using DataStructureExercises;

Console.WriteLine(FactorialCalculator.Calculate(6));
Console.WriteLine(PowerCalculator.Calculate(5, 3));
Console.WriteLine(StringReverser.Reverse("Let's test this sentence."));

var numbers = new int[] { 2, 4, 5, 10, 20 };
SquareCalculator squareCalculator = new() { Numbers = numbers };
squareCalculator.Calculate();
Console.WriteLine(squareCalculator.GetResult());

Console.WriteLine(CharacterFrequency.Calculate("Let's test this sentence."));

FileCreator.Create(@"E:\test.txt");
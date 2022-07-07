using DataStructureExercises;

Console.WriteLine(FactorialCalculator.Calculate(6));
Console.WriteLine(PowerCalculator.Calculate(5, 3));
Console.WriteLine(StringReverser.Reverse("Let's test this sentence."));

var test = new int[] { 2, 4, 5, 10, 20 };
Console.WriteLine(SquareCalculator.Calculate(test));

Console.WriteLine(CharacterFrequency.Calculate("Let's test this sentence."));

FileCreator.Create(@"E:\test.txt");
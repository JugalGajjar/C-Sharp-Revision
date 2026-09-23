// Array creation
int[] numbers = { 1, 2, 3, 4, 5 };
Console.Write("Array elements: ");
foreach (int number in numbers) { // Foreach is used to iterate through the array
    Console.Write(number + " ");
}

Console.WriteLine();

// Array length
Console.WriteLine($"Array length: {numbers.Length}");

Console.WriteLine();

// Array input
int[] someNumbers = new int[5];
Console.WriteLine("Enter some numbers: ");
for (int i = 0; i < someNumbers.Length; i++) {
    Console.Write($"Enter number {i + 1}: ");
    someNumbers[i] = int.Parse(Console.ReadLine());
}
Console.Write("You entered the following numbers: ");
foreach (int number in someNumbers) {
    Console.Write(number + " ");
}
Console.WriteLine("\n");

// Array sorting
Array.Sort(someNumbers);
Console.Write("Sorted array elements: ");
foreach (int number in someNumbers) {
    Console.Write(number + " ");
}
Console.WriteLine("\n");

// Array reversal
Array.Reverse(someNumbers);
Console.Write("Reversed array elements: ");
foreach (int number in someNumbers) {
    Console.Write(number + " ");
}
Console.WriteLine();

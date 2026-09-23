Console.WriteLine("For Loop:");
for (int i = 0; i < 3; i++) {
    Console.WriteLine($"Iteration {i}");
}

Console.WriteLine();
Console.WriteLine("While Loop:");

int counter = 0;
while (counter < 3) {
    Console.WriteLine($"Counter: {counter}");
    counter++;
}

Console.WriteLine();
Console.WriteLine("Do-While Loop:");

counter = 0;
do {
    Console.WriteLine($"Counter: {counter}");
    counter++;
} while (counter < 3);
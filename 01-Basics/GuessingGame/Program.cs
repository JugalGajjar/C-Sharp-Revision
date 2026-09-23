Random random = new Random();
int targetNumber = random.Next(1, 101); // Generates a number between 1 and 100
int attempts = 0;
bool hasGuessedCorrectly = false;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I have chosen a number between 1 and 100. Can you guess it?");

while (!hasGuessedCorrectly) {
    Console.Write("\nEnter your guess: ");
    string input = Console.ReadLine();

    // Validate that the input is a valid integer
    if (!int.TryParse(input, out int playerGuess)) {
        Console.WriteLine("Invalid input. Please enter a whole number.");
        continue;
    }

    attempts++;

    if (playerGuess < targetNumber) {
        Console.WriteLine("Too low! Try again.");
    } else if (playerGuess > targetNumber) {
        Console.WriteLine("Too high! Try again.");
    } else {
        hasGuessedCorrectly = true;
        Console.WriteLine($"\nCongratulations! You found the number {targetNumber} in {attempts} attempts.");
    }
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

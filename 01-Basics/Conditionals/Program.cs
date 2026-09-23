Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18) {
    Console.WriteLine("You are an adult.");
} else {
    Console.WriteLine("You are a minor.");
}

Console.WriteLine();

Console.Write("Enter any number between 1-7 (days of week): ");
int dayNumber = int.Parse(Console.ReadLine());

switch (dayNumber) {
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day number.");
        break;
}
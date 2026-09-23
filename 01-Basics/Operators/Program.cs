int a = 10;
int b = 5;

int sum = a + b;
int difference = a - b;
int product = a * b;
int quotient = a / b;
int remainder = a % b;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");

int power = (int)Math.Pow(a, b);
Console.WriteLine($"Power: {power}");

double sqrtA = Math.Sqrt(a);
Console.WriteLine($"Square Root of a: {sqrtA}");
double sqrtB = Math.Sqrt(b);
Console.WriteLine($"Square Root of b: {sqrtB}");

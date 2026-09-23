// Returns nothing
void PrintHello() {
    Console.WriteLine("Hello, World!");
}
PrintHello();

Console.WriteLine();

// Returns a value
string GetHello() {
    return "Hello, World!";
}
Console.WriteLine($"The function returned: {GetHello()}");

Console.WriteLine();

// Takes parameters
void PrintHelloTo(string name) {
    Console.WriteLine($"Hello, {name}!");
}

PrintHelloTo("John");

Console.WriteLine();

// Takes parameters and returns a value
string GetHelloTo(string name) {
    return $"Hello, {name}!";
}
Console.WriteLine($"The function returned: {GetHelloTo("John")}");

Console.WriteLine();

// Takes parameters, returns a value, and demonstrates default arguments
string GetHelloToDefault(string name = "World") {
    return $"Hello, {name}!";
}
Console.WriteLine($"The function returned: {GetHelloToDefault()}");
Console.WriteLine($"The function returned: {GetHelloToDefault("John")}");

// Class definition
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int TopSpeedMph { get; set; }

    // Constructor
    public Car(string brand, string model, int year, int topSpeedMph) {
        Brand = brand;
        Model = model;
        Year = year;
        TopSpeedMph = topSpeedMph;
    }

    // Methods
    public void DisplayInfo() {
        Console.WriteLine($"{Year} {Brand} {Model} (Top Speed: {TopSpeedMph} mph)");
    }

    public void RevEngine() {
        Console.WriteLine($"The {Brand} {Model} roars to life!");
    }
}

class Program
{
    static void Main() {
        // Creating objects
        Car car1 = new Car("Porsche", "911 GT3 RS", 2024, 184);
        Car car2 = new Car("Aston Martin", "Valkyrie", 2022, 220);

        // Using the objects
        car1.DisplayInfo();
        car1.RevEngine();

        Console.WriteLine();

        car2.DisplayInfo();
        car2.RevEngine();
    }
}
// BASE CLASS (Parent)
class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Base constructor
    public Vehicle(string brand, string model, int year) {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Common method inherited by all derived classes
    public void Honk() {
        Console.WriteLine($"{Brand} {Model} goes: Beep beep!");
    }

    // Virtual method: provides a default implementation that child classes can override
    public virtual void DisplaySpecs() {
        Console.WriteLine($"\nVehicle: {Year} {Brand} {Model}");
    }
}

// DERIVED CLASS 1: ElectricCar inherits from Vehicle
class ElectricCar : Vehicle
{
    public int BatteryCapacityKWh { get; set; }

    // ': base(...)' sends the shared data to Vehicle's constructor
    public ElectricCar(string brand, string model, int year, int batteryKWh) : base(brand, model, year) {
        BatteryCapacityKWh = batteryKWh;
    }

    // Overriding the base class method to add electric-specific info
    public override void DisplaySpecs() {
        base.DisplaySpecs(); // Call parent display logic
        Console.WriteLine($"Type: Electric | Battery: {BatteryCapacityKWh} kWh");
    }

    // Specialized method unique to ElectricCar
    public void Charge() {
        Console.WriteLine($"{Brand} {Model} is now fast charging...");
    }
}

// DERIVED CLASS 2: GasCar inherits from Vehicle
class GasCar : Vehicle
{
    public int Horsepower { get; set; }

    public GasCar(string brand, string model, int year, int horsepower) : base(brand, model, year) {
        Horsepower = horsepower;
    }

    public override void DisplaySpecs() {
        base.DisplaySpecs();
        Console.WriteLine($"Type: Combustion | Engine: {Horsepower} HP");
    }
}

class Program
{
    static void Main() {
        // Instantiate derived classes
        ElectricCar taycan = new ElectricCar("Porsche", "Taycan Turbo S", 2024, 93);
        GasCar gt3 = new GasCar("Porsche", "911 GT3 RS", 2024, 518);

        // Inherited methods from Vehicle
        taycan.Honk();
        gt3.Honk();

        // Overridden methods displaying shared + specialized details
        taycan.DisplaySpecs();
        taycan.Charge(); // Specific to ElectricCar

        gt3.DisplaySpecs();
    }
}

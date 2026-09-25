// DEFINE INTERFACES
public interface IElectric
{
    int BatteryCapacityKWh { get; }
    void Charge();
}

public interface ITrackReady
{
    int TopSpeedMph { get; }
    void ActivateTrackMode();
}

// Rimac Nevera (Multiple Interfaces)
public class RimacNevera : IElectric, ITrackReady
{
    public string Model => "Rimac Nevera";
    public int BatteryCapacityKWh => 120;
    public int TopSpeedMph => 258;

    public void Charge() {
        Console.WriteLine($"{Model}: 500 kW ultra-fast charging engaged.");
    }

    public void ActivateTrackMode() {
        Console.WriteLine($"{Model}: Active aero lowered, 1,914 HP unlocked!");
    }
}

// Porsche 911 GT3 RS (implements only ITrackReady)
public class PorscheGT3RS : ITrackReady
{
    public string Model => "Porsche 911 GT3 RS";
    public int TopSpeedMph => 184;

    public void ActivateTrackMode() {
        Console.WriteLine($"{Model}: DRS wing opened, suspension stiffened.");
    }
}

// Tesla Model 3 (implements only IElectric)
public class TeslaModel3 : IElectric
{
    public string Model => "Tesla Model 3";
    public int BatteryCapacityKWh => 75;

    public void Charge() {
        Console.WriteLine($"{Model}: Charging at Tesla Supercharger.");
    }
}

// Polymorphism via interfaces
class Program
{
    static void Main() {
        RimacNevera nevera = new RimacNevera();
        PorscheGT3RS gt3 = new PorscheGT3RS();
        TeslaModel3 model3 = new TeslaModel3();

        // Track Day Event
        List<ITrackReady> trackCars = new List<ITrackReady> { nevera, gt3 };

        Console.WriteLine("=== TRACK DAY SESSIONS ===");
        foreach (ITrackReady car in trackCars) {
            car.ActivateTrackMode();
            Console.WriteLine($"Top Track Speed: {car.TopSpeedMph} mph\n");
        }

        // Charging Station Hub
        List<IElectric> evQueue = new List<IElectric> { nevera, model3 };

        Console.WriteLine("=== EV CHARGING HUB ===");
        foreach (IElectric ev in evQueue) {
            ev.Charge();
            Console.WriteLine($"Pack Size: {ev.BatteryCapacityKWh} kWh\n");
        }
    }
}

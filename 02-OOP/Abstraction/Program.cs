// ABSTRACT CLASS
abstract class Supercar
{
    public string Model { get; }

    protected Supercar(string model) {
        Model = model;
    }

    // Common functionality shared by all supercars
    public void TurnOnElectronics() {
        Console.WriteLine($"{Model}: Digital cockpit and telemetry systems activated.");
    }

    // Hidden implementation detail
    public abstract void Accelerate();
}

class RimacNevera : Supercar
{
    public RimacNevera() : base("Rimac Nevera") { }

    public override void Accelerate() {
        Console.WriteLine($"{Model}: Inverters route 1.4MW to four independent wheel motors. 0-60 in 1.74s.");
    }
}

class FerrariDaytonaSP3 : Supercar
{
    public FerrariDaytonaSP3() : base("Ferrari Daytona SP3") { }

    public override void Accelerate() {
        Console.WriteLine($"{Model}: Direct-injection opens, 6.5L V12 screams to 9,500 RPM delivering 829 HP.");
    }
}

// DRIVER
class Program
{
    static void Main() {
        // Driver only interacts with the Supercar abstraction
        Supercar car1 = new RimacNevera();
        Supercar car2 = new FerrariDaytonaSP3();

        DriveCar(car1);
        Console.WriteLine();
        DriveCar(car2);
    }

    static void DriveCar(Supercar car) {
        car.TurnOnElectronics();
        car.Accelerate();
    }
}

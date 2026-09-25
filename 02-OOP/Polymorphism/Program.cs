using System;
using System.Collections.Generic;

// BASE CLASS
class Vehicle
{
    public string Model { get; set; }

    public Vehicle(string model) {
        Model = model;
    }

    // Virtual method: provides a default implementation that can be overridden
    public virtual void StartEngine() {
        Console.WriteLine($"{Model}: Engine starts normally.");
    }
}

// DERIVED CLASSES
class ElectricCar : Vehicle
{
    public ElectricCar(string model) : base(model) { }

    public override void StartEngine() {
        Console.WriteLine($"{Model}: Powers on silently with a digital chime.");
    }
}

class Supercar : Vehicle
{
    public Supercar(string model) : base(model) { }

    public override void StartEngine() {
        Console.WriteLine($"{Model}: ROARS to life with an aggressive exhaust rev!");
    }
}

class Truck : Vehicle
{
    public Truck(string model) : base(model) { }

    public override void StartEngine() {
        Console.WriteLine($"{Model}: Heavy diesel engine rumbles to idle.");
    }
}

class Program
{
    static void Main() {
        // A single list of the base type (Vehicle) holding different derived types
        List<Vehicle> garage = new List<Vehicle> {
            new ElectricCar("Porsche Taycan"),
            new Supercar("Bugatti Chiron"),
            new Truck("Ford F-350")
        };

        // Call overridden StartEngine() for each vehicle
        foreach (Vehicle v in garage) {
            v.StartEngine();
        }
    }
}
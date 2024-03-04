using System;
using System.Collections.Generic;
using System.Linq;

public class VehicleRepository : IVehicleRepository
{
    private readonly List<Vehicle> vehicles;

    public VehicleRepository()
    {
        // Initialize with sample data
        vehicles = new List<Vehicle>
        {
            new Car { Id = 1, Color = "Red", Wheels = 4, Headlights = false },
            new Bus { Id = 2, Color = "Blue" },
            new Boat { Id = 3, Color = "Black" },
            new Car { Id = 4, Color = "White", Wheels = 4, Headlights = true },
            new Car { Id = 5, Color = "Red", Wheels = 4, Headlights = true },
            new Bus { Id = 6, Color = "Blue" },
            new Boat { Id = 7, Color = "Black" },
            new Car { Id = 8, Color = "White", Wheels = 4, Headlights = false },
        };
    }

    public IEnumerable<Vehicle> GetAllVehicles()
    {
        return vehicles;
    }

    public IEnumerable<Car> GetCarsByColor(string color)
    {
        return vehicles.OfType<Car>().Where(c => c.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Bus> GetBusesByColor(string color)
    {
        return vehicles.OfType<Bus>().Where(b => b.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Boat> GetBoatsByColor(string color)
    {
        return vehicles.OfType<Boat>().Where(b => b.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
    }
}

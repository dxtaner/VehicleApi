using System.Collections.Generic;

public interface IVehicleRepository
{
    IEnumerable<Vehicle> GetAllVehicles();
    IEnumerable<Car> GetCarsByColor(string color);
    IEnumerable<Bus> GetBusesByColor(string color);
    IEnumerable<Boat> GetBoatsByColor(string color);
}

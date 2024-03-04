using System.Collections.Generic;

public interface IVehicleService
{
    IEnumerable<Vehicle> GetAllVehicles();
    IEnumerable<Car> GetCarsByColor(string color);
    IEnumerable<Bus> GetBusesByColor(string color);
    IEnumerable<Boat> GetBoatsByColor(string color);
    ServiceResult ToggleHeadlights(int id);
    ServiceResult DeleteCar(int id);
}

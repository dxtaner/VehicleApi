using System;
using System.Collections.Generic;
using System.Linq;

public class VehicleService : IVehicleService
{
    private readonly IVehicleRepository _vehicleRepository;

    public VehicleService(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    public IEnumerable<Vehicle> GetAllVehicles()
    {
        return _vehicleRepository.GetAllVehicles();
    }

    public IEnumerable<Car> GetCarsByColor(string color)
    {
        return _vehicleRepository.GetCarsByColor(color);
    }

    public IEnumerable<Bus> GetBusesByColor(string color)
    {
        return _vehicleRepository.GetBusesByColor(color);
    }

    public IEnumerable<Boat> GetBoatsByColor(string color)
    {
        return _vehicleRepository.GetBoatsByColor(color);
    }

    public ServiceResult ToggleHeadlights(int id)
    {
        // Your implementation for toggling headlights goes here
        // It should interact with the repository to perform the operation
        // Return a ServiceResult object with appropriate values
        throw new NotImplementedException();
    }

    public ServiceResult DeleteCar(int id)
    {
        // Your implementation for deleting a car goes here
        // It should interact with the repository to perform the operation
        // Return a ServiceResult object with appropriate values
        throw new NotImplementedException();
    }
}

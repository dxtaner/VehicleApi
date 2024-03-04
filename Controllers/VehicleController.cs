using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleService _vehicleService;

    public VehicleController(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    [HttpGet("cars/{color}")]
    public IActionResult GetCarsByColor(string color)
    {
        var cars = _vehicleService.GetCarsByColor(color);
        return Ok(cars);
    }

    [HttpGet("buses/{color}")]
    public IActionResult GetBusesByColor(string color)
    {
        var buses = _vehicleService.GetBusesByColor(color);
        return Ok(buses);
    }

    [HttpGet("boats/{color}")]
    public IActionResult GetBoatsByColor(string color)
    {
        var boats = _vehicleService.GetBoatsByColor(color);
        return Ok(boats);
    }

    [HttpPost("toggle-headlights/{id}")]
    public IActionResult ToggleHeadlights(int id)
    {
        var result = _vehicleService.ToggleHeadlights(id);

        if (result.Success)
        {
            return Ok(new { Message = result.Message });
        }

        return NotFound(new { Error = result.Message });
    }

    [HttpDelete("delete-car/{id}")]
    public IActionResult DeleteCar(int id)
    {
        var result = _vehicleService.DeleteCar(id);

        if (result.Success)
        {
            return Ok(new { Message = result.Message });
        }

        return NotFound(new { Error = result.Message });
    }

    [HttpGet("all-vehicles")]
    public IActionResult GetAllVehicles()
    {
        var allVehicles = _vehicleService.GetAllVehicles();
        return Ok(allVehicles);
    }
}

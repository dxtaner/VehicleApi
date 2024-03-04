public class Vehicle
{
    public int Id { get; set; }
    public string Color { get; set; }

    public Vehicle()
    {
        Color = string.Empty;
    }
}

public class Car : Vehicle
{
    public int Wheels { get; set; }
    public bool Headlights { get; set; }
}

public class Bus : Vehicle { }

public class Boat : Vehicle { }

Vehicle Controller API
======================

This repository contains a simple ASP.NET Core Web API controller for managing vehicles. The controller provides endpoints for retrieving vehicles by color, toggling headlights, deleting cars, and retrieving all vehicles.

Endpoints
---------

### Get Cars By Color

*   **Endpoint:** `GET /api/vehicle/cars/{color}`
*   **Description:** Retrieves cars of the specified color.
*   **Parameters:**
    *   `{color}`: The color of the cars to retrieve.
*   **Example:** `/api/vehicle/cars/red`
*   **Response:** Array of car objects.

Technologies Used
-----------------

*   ASP.NET Core
*   C#
*   Microsoft.AspNetCore.Mvc

How to Use
----------

1.  Clone the repository.
2.  Build and run the project.
3.  Use any API testing tool (e.g., Postman) to access the endpoints described above.

Setup
-----

1.  Make sure you have .NET Core SDK installed.
2.  Clone this repository.
3.  Navigate to the project directory.
4.  Run `dotnet build` to build the project.
5.  Run `dotnet run` to start the API server.

Contributing
------------

Contributions are welcome. If you find any issues or want to suggest improvements, feel free to open an issue or create a pull request.

License
-------

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace VehicleApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IVehicleRepository, VehicleRepository>();
            services.AddSingleton<IVehicleService, VehicleService>();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}


using InternshipTask.API.Extensions;
using InternshipTask.API.Middleware;
using InternshipTask.DataLayer;

namespace InternshipTask.API
{
    public class Startup
    {
        private readonly IConfigurationRoot _configuration;

        public Startup(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureBuilder(WebApplicationBuilder builder)
        {

        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddExceptionHandler<GlobalExceptionHandler>();

            services.AddDataLayer(_configuration)
                .AddBusinessLayer(_configuration);

            services.AddCustomCors(_configuration);

            services.AddProblemDetails();
        }
        public void Configure(WebApplication app)
        {


            app.UseForwardedHeaders();

            app.UseExceptionHandler();
            app.UseHttpsRedirection();

            app.UseCors(CorsExtensions.AllowsOrigins);

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
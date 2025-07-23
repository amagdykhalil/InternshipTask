using InternshipTask.BusinessLayer.Services;
using InternshipTask.BusinessLayer.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternshipTask.DataLayer
{
    public static class BusinessDependencyInjection
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}

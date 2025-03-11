using Api.Data;
using Api.Interfaces;
using Api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddCors();

            // Implentacion de repositorios
            services.AddScoped<IEstudianteRepository, EstudianteRepository>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}

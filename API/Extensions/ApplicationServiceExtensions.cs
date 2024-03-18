using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(optons =>
        {
            optons.UseSqlite(configuration.GetConnectionString("ConStr"));
        });
        services.AddScoped<ITokenService,TokenService>();

        return services;
    }
}

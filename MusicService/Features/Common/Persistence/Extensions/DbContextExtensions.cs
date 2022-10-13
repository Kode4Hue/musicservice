using Microsoft.EntityFrameworkCore;

namespace MusicService.Features.Common.Persistence.Extensions
{
    public static class DbContextExtensions
    {

        public static void SeedInitialData(this IApplicationBuilder app, IConfiguration configuration)
        {

            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>())
                {
                    if(context is not null)
                    {
                        context.Database.Migrate();

                        var assembly = typeof(DbContextExtensions).Assembly;
                        var files = assembly.GetManifestResourceNames();
                    }
                }
            }
        }
    }
}

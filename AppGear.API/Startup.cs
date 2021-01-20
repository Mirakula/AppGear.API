using AppGear.API.Models;
using AppGear.API.Repositories;
using AppGear.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AppGear.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<LorawanContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("LoraWanDb")));

            services.AddScoped<ILoriotTestRepository, LoriotTestRepository>();
            services.AddScoped<ILoriotProductionRepository, LoriotProductionRepository>();
            services.AddScoped<ILoriotDecoderRepository, LoriotDecoderRepository>();
            services.AddScoped<IBusCapacaityCalculator, BusCapacityCalculator>();

            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Potvrda da je baza podataka napravljena preko EF Core
            // Ako nije onda je EF Core napravi sam
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<LorawanContext>().Database.Migrate();
                scope.ServiceProvider.GetRequiredService<LorawanContext>().Database.EnsureCreated();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
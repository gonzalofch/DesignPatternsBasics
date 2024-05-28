using DataAccess.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Agregar soporte para controladores con vistas.
            services.AddControllersWithViews();


            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

            services.AddScoped<DataAccess.EFCore.ApplicationContext>();
            // Registrar otros servicios aquí, como servicios de aplicación, bases de datos, etc.
            // Ejemplo: services.AddScoped<IMyService, MyService>();

            // Agregar servicios de autenticación y autorización si es necesario.
            // services.AddAuthentication();
            // services.AddAuthorization();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Muestra la página de excepciones detalladas en desarrollo.
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Maneja excepciones en producción.
                app.UseHsts(); // Añadir encabezado HSTS para mejorar la seguridad.
            }

            app.UseHttpsRedirection(); // Redirigir HTTP a HTTPS.
            app.UseStaticFiles(); // Servir archivos estáticos (CSS, JS, imágenes, etc.).

            app.UseRouting(); // Configurar el enrutamiento.

            app.UseAuthentication(); // Añadir autenticación a la canalización.
            app.UseAuthorization(); // Añadir autorización a la canalización.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                // Configurar otras rutas o endpoints de la API aquí.
            });
        }

    }
}

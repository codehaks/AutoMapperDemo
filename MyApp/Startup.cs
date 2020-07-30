using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyApp.Data;
using MyApp.Models;

namespace MyApp
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>
                (options => options.UseSqlite("Data Source=app.sqlite"));

            services.AddControllers();

            services.AddRazorPages()
                .AddRazorRuntimeCompilation();

            var config = new MapperConfiguration(cfg => {
                //cfg.AddProfile<AppProfile>();
                cfg.CreateMap<Book, BookViewModel>();
            });

            var mapper = config.CreateMapper();

            //services.AddAutoMapper(typeof(Startup));

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using aah_real_cms_api.Persistence.Contexts;
using aah_real_cms_api.Domain.Repositories;
using aah_real_cms_api.Persistence.Repositories;

namespace aah_real_cms_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
                {
                    options.AddPolicy("dev",
                    builder =>
                    {
                        // Not a permanent solution, but just trying to isolate the problem
                        builder.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
                    });
                });
            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("aah-real-cms-api-in-memory");
            });
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IContentService, ContentService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("dev");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

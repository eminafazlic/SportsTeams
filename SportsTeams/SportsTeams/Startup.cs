using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Services;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams
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


            //services.AddControllers();
            services.AddMvc();
            services.AddApiVersioning(o=> 
                { o.AssumeDefaultVersionWhenUnspecified = true; 
                    o.DefaultApiVersion = new ApiVersion(1, 0); 
                    
                });



            services.AddSwaggerGen(o=> 
            {
                o.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API V1 Title",
                    Description = "API V1 Description"
                });

                o.SwaggerDoc("v2", new OpenApiInfo
                {
                    Version = "v2",
                    Title = "API V2 Title",
                    Description = "API V2 Description"
                });
                o.ResolveConflictingActions(a => a.First());
                o.OperationFilter<RemoveVersionFromParameter>();
                o.DocumentFilter<ReplaceVersionWithExactValueInPath>();
            });

            services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:SportsTeamsDb"]));

            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ITeamService, TeamService>();

            services.AddAutoMapper(typeof(Startup));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", "API V1");
                c.SwaggerEndpoint($"/swagger/v2/swagger.json", "API V2");
               
            });


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

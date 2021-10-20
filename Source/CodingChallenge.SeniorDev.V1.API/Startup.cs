using CodingChallenge.SeniorDev.V1.API.AM;
using CodingChallenge.SeniorDev.V1.Common.Middleware;
using CodingChallenge.SeniorDev.V1.Business.Actions.Courses;
using CodingChallenge.SeniorDev.V1.Common.Configuration;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace CodingChallenge.SeniorDev.V1.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CodingChallengeConfiguration>(Configuration);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CodingChallenge - Senior Developers", Version = "v1" });
            });

            // Adding MediatR
            services.AddMediatR(typeof(GetAllCoursesQueryHandler));

            // Adding AutoMapper
            services.AddAutoMapper(
                typeof(AutoMapperProfile)
            );

            services.AddDbContext<CodingChallengeDataContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString(ConnectionStringKeys.CodingChallengeDB)));

            services.Add(ServiceDescriptor.Singleton(typeof(IOptionsSnapshot<>), typeof(OptionsManager<>)));

            services.AddTransient<HttpResponseMiddleware>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CodingChallenge - Senior Developers"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseMiddleware<HttpResponseMiddleware>();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public static class ConnectionStringKeys
    {
        public const string CodingChallengeDB = "CodingChallengeDb";
    }
}

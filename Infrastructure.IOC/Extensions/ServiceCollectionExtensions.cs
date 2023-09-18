using Infrastructure.Configuration.Configuration;
using Infrastructure.DB;
using Infrastructure.Security.Interface;
using Infrastructure.Security.Service;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Serilog;
using Service.Interface;
using Service.Service;
using System.Data.Common;
using System.Globalization;
using System.Reflection;

namespace Infrastructure.IOC.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();
            services.BindConfigurations(configuration);
            services.AddDatabaseConfigurations(configuration);

            return services;
        }

        public static IServiceCollection AddDatabaseConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            DbConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection,
                                                                                        assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
                                                                   
            return services;
        }

        public static IServiceCollection ConfigureRequestLocation(this IServiceCollection services)
        {
            return services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("pt-BR");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("pt-BR") };
            });
        }

        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(_ =>
            {
                _.SwaggerDoc(ApplicationConfiguration.Current?.Version, new OpenApiInfo
                {
                    Title = ApplicationConfiguration.Current?.Name,
                    Version = ApplicationConfiguration.Current?.Version
                });

                _.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. Enter 'Bearer' [space] and then your token in the text input below. Example: 'Bearer 123456asdf'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = "Bearer"
                });

                _.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
            });
        }

        public static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(Log.Logger);
            services.AddScoped<IDevService, DevService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped<ITipoDevService, TipoDevService>();

            return services;
        }

        public static IServiceCollection BindConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationConfiguration = new ApplicationConfiguration();
            configuration.Bind("Application", applicationConfiguration);
            services.AddSingleton(applicationConfiguration);

            return services;
        }
    }
}

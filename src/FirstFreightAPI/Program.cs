using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Infrastructure.Configuration;
using Infrastructure.Persistence.DbContexts.Shared;
using Application.Configuration;
using Application.Common.Interfaces;
using FirstFreightAPI.Middleware;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Application.Common.Settings;
using Serilog;
using Microsoft.ApplicationInsights;
using Serilog.Extensions.Logging;
using FirstFreightAPI;

public class Program
{
    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        IServiceCollection services = builder.Services;

        // Configure
        bool isApplicationInsightsActive = AddApplicationInsights(builder);
        AddLogging(services, isApplicationInsightsActive);
        AddDbContexts(builder, services);
        ConfigureAppSettingsIOptions(builder, services);
        AddControllers(services);
        AddSwagger(services);
        AddInfrastructure(builder, services);
        AddApplicationServices(services);

        // Build and run
        WebApplication app = builder.Build();
        ConfigureServices(app);
        app.Run();
    }

    private static bool AddApplicationInsights(WebApplicationBuilder builder)
    {
        string? key = builder.Configuration.GetConnectionString("APPLICATIONINSIGHTS_CONNECTION_STRING");
        if (string.IsNullOrEmpty(key))
        {
            return false;
        }

        builder.Logging.AddApplicationInsights(
        configureTelemetryConfiguration: (config) =>
            config.ConnectionString = key,
            configureApplicationInsightsLoggerOptions: (options) => { });

        return true;
    }

    private static void AddApplicationServices(IServiceCollection services)
    {
        services.AddApplicationServices();
    }

    private static void AddControllers(IServiceCollection services)
    {
        services.AddControllers().AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        });
    }

    private static void ConfigureServices(WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseMiddleware<ValidationMappingMiddleware>();
        app.MapControllers();
    }

    private static void AddInfrastructure(WebApplicationBuilder builder, IServiceCollection services)
    {
        // Add Stripe Infrastructure
        string stringKey = 
            Environment.GetEnvironmentVariable("Stripe_SecretKey", EnvironmentVariableTarget.Process)
            .ValidateNotNull("Stripe_SecretKey");
        string connectionString =
            Environment.GetEnvironmentVariable("SharedMsSqlConnectionString", EnvironmentVariableTarget.Process)
            .ValidateNotNull("SharedMsSqlConnectionString");

        services.AddInfrastructureServices(stringKey, connectionString);
    }

    private static void AddSwagger(IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "FirstFreight",
                Description = "FirstFreight Api"
            });

            // using System.Reflection;
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });
        services.AddSwaggerGenNewtonsoftSupport();
    }

    private static void ConfigureAppSettingsIOptions(WebApplicationBuilder builder, IServiceCollection services)
    {
        services.Configure<StripeSettings>(builder.Configuration.GetSection("StripeSettings"));
    }

    private static void AddDbContexts(WebApplicationBuilder builder, IServiceCollection services)
    {
        string connectionString = 
            Environment.GetEnvironmentVariable("SharedMsSqlConnectionString", EnvironmentVariableTarget.Process)
            .ValidateNotNull("SharedMsSqlConnectionString");

        // initialize contexts 
        services.AddDbContext<SharedDbContext>(
            options => options.UseSqlServer(
                connectionString,
                x => x.MigrationsAssembly("Infrastructure")));

        // Disable DataCenter unless requird. As we want to try to only use Shared.
        /*
        services.AddDbContext<DataCenterDbContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataContext")));

        services.AddScoped<IDataCenterDbContext>(provider => provider.GetRequiredService<DataCenterDbContext>());
        */

        services.AddScoped<ISharedDbContext>(provider => provider.GetRequiredService<SharedDbContext>());
    }

    private static void AddLogging(IServiceCollection services, bool isApplicationInsightsActive)
    {
        services.AddSingleton<ILoggerProvider>((sp) =>
        {
            IHostEnvironment hostEnvironment = sp.GetRequiredService<IHostEnvironment>();
            LoggerConfiguration loggerConfiguration;

            if (hostEnvironment.IsDevelopment())
            {
                const string template = "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";

                loggerConfiguration = new LoggerConfiguration()
                    .MinimumLevel.Information()
                    .Enrich.FromLogContext()
                    .WriteTo.Console(outputTemplate: template);
            }
            else
            {
                // Never log to console in production
                loggerConfiguration = new LoggerConfiguration()
                    .MinimumLevel.Information()
                    .Enrich.FromLogContext();
            }

            if (isApplicationInsightsActive)
            {
                loggerConfiguration.WriteTo.ApplicationInsights(sp.GetRequiredService<TelemetryClient>(), TelemetryConverter.Traces);
            }

            Log.Logger = loggerConfiguration.CreateLogger();

            return new SerilogLoggerProvider(Log.Logger, true);
        });
    }
}
using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.AzureAppServices;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace BookClub.UI
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        public static void Main(string[] args)
        {
            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(Configuration)
            //    //.WriteTo.File(new JsonFormatter(), @"c:\temp\logs\book-club.json", shared: true)
            //    .WriteTo.Seq("http://localhost:5341")
            //    .CreateLogger();           

            try
            {
                //Log.Information("Starting web host");
                //logger.Info("Starting web host");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                //Log.Fatal(ex, "Host terminated unexpectedly");
                //logger.Error(ex, "Host terminated unexpectedly");
            }
            finally
            {
                //Log.CloseAndFlush();
                //NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging(logging => logging.AddAzureWebAppDiagnostics())
                .ConfigureServices(serviceCollection => serviceCollection
                    .Configure<AzureFileLoggerOptions>(options =>
                    {
                        options.FileName = "azure-diagnostics-";
                        options.FileSizeLimit = 50 * 1024;
                        options.RetainedFileCountLimit = 5;
                    })
                    .Configure<AzureBlobLoggerOptions>(options =>
                    {
                        options.BlobName = "log.txt";
                    }))
                .UseStartup<Startup>();               
                //.UseSerilog();               
                //.UseNLog();
    }
}

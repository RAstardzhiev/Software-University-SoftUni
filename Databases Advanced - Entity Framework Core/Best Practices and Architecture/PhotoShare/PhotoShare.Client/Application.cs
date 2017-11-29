namespace PhotoShare.Client
{
    using System;
    using Core;
    using Data;
    using PhotoShare.Services.Interfaces;
    using PhotoShare.Services;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;
    using Microsoft.EntityFrameworkCore;
    using System.IO;
    using PhotoShare.Client.Interfaces;

    public class Application
    {
        private const string ConnectionString = "DefaultConnection";

        public static void Main()
        {
            // ResetDatabase();

            var secviceProvider = ConfigureServices();
            
            var commandDispatcher = new CommandDispatcher(secviceProvider);
            var engine = new Engine(commandDispatcher);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            /* Installed Packages:
             *  - Microsoft.Extensions.DependencyInjection
             *  - Microsoft.Extensions.Configuration.Json
             */

            var serviceCollection = new ServiceCollection();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            serviceCollection.AddDbContext<PhotoShareContext>(options =>
                options.UseSqlServer(config.GetConnectionString(ConnectionString)));

            serviceCollection.AddSingleton<IUserSessionService, UserSessionService>();
            serviceCollection.AddTransient<IWriter, Writer>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }

        private static void ResetDatabase()
        {
            using (var db = new PhotoShareContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                new DbSeeder(db).SeedTestData();
            }
        }
    }
}

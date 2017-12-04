namespace Employees.App
{
    using AutoMapper;
    using Core;
    using Employees.App.Interfaces;
    using Employees.App.IO;
    using Employees.Data;
    using Employees.Data.Config;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class Startup
    {
        private const string ConnectionString = "DefaultConnection";

        public static void Main()
        {
            /* Mapper URL -> https://github.com/AutoMapper/AutoMapper */
            InitializeMapper();

            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var serviceProvider = ConfigureServices();
            var commandInterpreter = new CommandInterpreter<ICommand>(serviceProvider);

            var engine = new Engine(reader, writer, commandInterpreter);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            /* JSON ConnectionString
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            serviceCollection.AddDbContext<EmployeesContext>(options =>
                options.UseSqlServer(config.GetConnectionString(ConnectionString))
            );
             */

            /* Class config ConnectionCtring */
            serviceCollection.AddDbContext<EmployeesContext>(options =>
                options.UseSqlServer(DbConfig.ConnectionString)
            );

            serviceCollection.AddTransient<IWriter, ConsoleWriter>();
            serviceCollection.AddTransient<IReader, ConsoleReader>();

            // Adding Mapper but it can be used from the static Mapper class
            // serviceCollection.AddAutoMapper(); // Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection

            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }

        private static void InitializeMapper()
        {
            /* One place configuration 
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>();
            });
            */

            /* Moving the configuration in separate file */
            Mapper.Initialize(cfg => cfg.AddProfile<MapperProfile>());

            /* Complex Mapping Configuration example: 
            Mapper.Initialize(cfg => {
                cfg.CreateMap<OnlineOrder, OnlineOrderDto>();
                cfg.CreateMap<MailOrder, MailOrderDto>();
            
                cfg.CreateMap<Product, ProductDTO>()
                            .ForMember(dto => dto.StockQty, opt => opt
                                .MapFrom(src => src
                                    .ProductStocks.Sum(p => p.Quantity)))
            
                cfg.CreateMap<Order, OrderDto>()
                    .Include<OnlineOrder, OnlineOrderDto>()
                    .Include<MailOrder, MailOrderDto>();
            });
             */
        }

        /* If want to return an instance of the mapper */
        //private static IMapper GetMapper()
        //{
        //    var config = new MapperConfiguration(cfg => cfg.AddProfile<MapperProfile>());
        //    return new Mapper(config);
        //}
    }
}

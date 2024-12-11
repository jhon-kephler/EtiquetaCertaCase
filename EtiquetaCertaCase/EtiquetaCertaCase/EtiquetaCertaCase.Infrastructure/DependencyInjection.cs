using EtiquetaCertaCase.Application.Services.ManageServices;
using EtiquetaCertaCase.Application.Services.ManageServices.Interfaces;
using EtiquetaCertaCase.Application.Services.SearchServices;
using EtiquetaCertaCase.Application.Services.SearchServices.Interfaces;
using EtiquetaCertaCase.Data;
using EtiquetaCertaCase.Data.Repositories;
using EtiquetaCertaCase.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EtiquetaCertaCase.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddContext(configuration);
            services.AddRepository();
            services.AddHandler();
            services.AddServices();
            //services.AddCommand();

            return services;
        }

        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<EtiquetaCertaCaseContext>(options => { options.UseNpgsql(configuration["ConnectionString:DefaultConnection"]); });

        public static IServiceCollection AddHandler(this IServiceCollection services)
        {
            services.AddAutoMapper(Core.AssemblyReference.Assembly);
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Application.AssemblyReference.Assembly));

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IManageProductService, ManageProductService>();
            services.AddScoped<ISearchProductService, SearchProductService>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));

            services.AddScoped(typeof(DbContext), typeof(EtiquetaCertaCaseContext));

            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using NSE.Catalogo.Api.Data;
using NSE.Catalogo.Api.Data.Repository;
using NSE.Catalogo.Api.Models;

namespace NSE.Catalogo.Api.Configuration
{
    public static class DependencyInjectionConfig {
        public static void RegisterServices(this IServiceCollection services) {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
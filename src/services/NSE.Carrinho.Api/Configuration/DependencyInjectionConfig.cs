using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace NSE.Carrinho.Api.Configuration {
    public static class DependencyInjectionConfig {
        public static void RegisterServices(this IServiceCollection services) {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSE.Clientes.Api.Services;
using NSE.Core.Utils;
using NSE.MessageBus;

namespace NSE.Clientes.Api.Configuration {
    public static class MessageBusConfig {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}
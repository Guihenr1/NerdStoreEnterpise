using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NSE.Clientes.Api.Application.Commands;
using NSE.Core.Mediator;

namespace NSE.Clientes.Api.Configuration
{
    public static class DependencyInjectionConfig {
        public static void RegisterServices(this IServiceCollection services) {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();
        }
    }
}
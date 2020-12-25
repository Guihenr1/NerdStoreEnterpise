using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NSE.Clientes.Api.Application.Commands;
using NSE.Clientes.Api.Application.Events;
using NSE.Clientes.Api.Data;
using NSE.Clientes.Api.Data.Repository;
using NSE.Clientes.Api.Models;
using NSE.Clientes.Api.Services;
using NSE.Core.Mediator;

namespace NSE.Clientes.Api.Configuration
{
    public static class DependencyInjectionConfig {
        public static void RegisterServices(this IServiceCollection services) {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();

            services.AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}
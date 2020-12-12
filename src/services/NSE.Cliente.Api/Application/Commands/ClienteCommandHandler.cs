using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using MediatR;
using NSE.Clientes.Api.Models;
using NSE.Core.Messages;

namespace NSE.Clientes.Api.Application.Commands
{
    public class ClienteCommandHandler : CommandHandler, IRequestHandler<RegistrarClienteCommand, ValidationResult> {
        public async Task<ValidationResult> Handle(RegistrarClienteCommand message, CancellationToken cancellationToken) {
            if (!message.EhValido()) return message.ValidationResult;

            var cliente = new Cliente(message.Id, message.Nome, message.Email, message.Cpf);

            // Validacoes de negocio

            // Persistir no banco
            if (true)
            {
                AdicionarErro("CPF já existente");
                return ValidationResult;
            }

            return message.ValidationResult;
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace NSE.Clientes.Api.Application.Events
{
    public class ClienteEventHandler : INotificationHandler<ClienteRegistradoEvent> {
        public Task Handle(ClienteRegistradoEvent notification, CancellationToken cancellationToken) {
            // Enviar evento de confirmação (Email de confirmação...)
            return Task.CompletedTask;
        }
    }
}

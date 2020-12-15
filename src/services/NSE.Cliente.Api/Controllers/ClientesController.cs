using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSE.Clientes.Api.Application.Commands;
using NSE.Core.Mediator;
using NSE.WebAPI.Core.Controllers;

namespace NSE.Clientes.Api.Controllers {
    public class ClientesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Guilherme", "guilherme.pomp@gmail.com", "71254661093"));

            return CustomResponse(resultado);
        }
    }
}

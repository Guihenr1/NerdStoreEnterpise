using Microsoft.AspNetCore.Authorization;
using NSE.WebAPI.Core.Controllers;

namespace NSE.Carrinho.Api.Controllers {
    [Authorize]
    public class CarrinhoController : MainController {
    }
}

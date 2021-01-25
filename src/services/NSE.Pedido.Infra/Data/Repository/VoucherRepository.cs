using System.Threading.Tasks;
using NSE.Core.Data;
using NSE.Pedido.Domain.Vouchers;

namespace NSE.Pedido.Infra.Data.Repository
{
    public class VoucherRepository : IVoucherRepository {
        private readonly PedidosContext _context;

        public VoucherRepository(PedidosContext context) {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Dispose() {
            _context.Dispose();
        }
    }
}
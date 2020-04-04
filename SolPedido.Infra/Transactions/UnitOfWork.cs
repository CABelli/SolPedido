using SolPedido.Infra.Persistencia;

namespace SolPedido.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SolPedidoContexto _context;
        public UnitOfWork(SolPedidoContexto context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

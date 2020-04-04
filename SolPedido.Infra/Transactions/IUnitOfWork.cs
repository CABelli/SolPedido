namespace SolPedido.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}

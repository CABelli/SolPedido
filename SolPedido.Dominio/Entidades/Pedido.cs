using System;

namespace SolPedido.Dominio.Entidades
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public Vendedor Vendedor { get; set; }

        public Cliente Cliente { get; set; }

        public DateTime DataEntrada { get; set; }

    }
}

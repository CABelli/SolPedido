using System;

namespace SolPedido.Dominio.Entidades
{
    public class MeusPedidos
    {
        public Guid Id { get; set; }

        public Pedido Pedido { get; set; }

        public bool Incluo { get; set; }

        public DateTime DtInclusao { get; set; }

        public bool Bloqueio { get; set; }
        public bool Disponibilizo { get; set; }
        public bool Faturo { get; set; }
        public bool Cancelo { get; set; }

        public DateTime MyProperty { get; set; }
    }
}

using System;

namespace SolPedido.Dominio.Entidades
{
    public class Vendedor
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Site { get; set; }
    }
}

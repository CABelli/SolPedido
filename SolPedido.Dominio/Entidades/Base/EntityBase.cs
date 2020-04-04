using prmToolkit.NotificationPattern;
using System;

namespace SolPedido.Dominio.Entidades.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

    }
}

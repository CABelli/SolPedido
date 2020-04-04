using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SolPedido.Dominio.Entidades.Base;
using SolPedido.Dominio.Enum;
using SolPedido.Dominio.Extensoes;
using SolPedido.Dominio.Recursos;
using SolPedido.Dominio.ValorObjetos;
using System;

namespace SolPedido.Dominio.Entidades
{
    public class Usuario : EntityBase
    {
        protected Usuario()
        {

        }
        public Usuario(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Usuario>(this)
                .IfNullOrInvalidLength(x=> x.Senha, 6, 8,"A senha deve ter entre 6 e 8 caracteres")
                ; if (IsValid())
            {
                Senha = Senha.ConverteToMDS();

            }
        }

        public Usuario(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            //Id = Guid.NewGuid();
            Status = EnumSituacaoUsuario.EmAndamento;

            new AddNotifications<Usuario>(this)
                .IfNullOrInvalidLength(x => x.Senha, 5, 9, Mensagem.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Senha", "3", "9"))
                ;
            if (IsValid())
            {
                Senha = Senha.ConverteToMDS();

            }

            AddNotifications(nome, email);
        }

        public void AlterarUsuario (Nome nome, Email email, EnumSituacaoUsuario status )
        {
            Nome = nome;
            Email = email;

            new AddNotifications<Usuario>(this).IfFalse(Status == EnumSituacaoUsuario.Ativo, "SO_SE_ALTERA_ATIVO");

            AddNotifications(nome, email);
        }
        
        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }

        public EnumSituacaoUsuario Status { get; private set; }

        public override string ToString()
        {
            return this.Nome.PrimeiroNome + " " + this.Nome.UltimoNome;
        }

    }
}

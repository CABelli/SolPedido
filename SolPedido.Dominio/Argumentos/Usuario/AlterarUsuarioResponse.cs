using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolPedido.Dominio.Argumentos.Usuario
{
    public class AlterarUsuarioResponse
    {

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Mensagem { get; set; }

        public static explicit operator AlterarUsuarioResponse(Entidades.Usuario usuario)
        {
            return new AlterarUsuarioResponse()
            {
                  Id = usuario.Id
                , Email = usuario.Email.Endereco
                , PrimeiroNome = usuario.Nome.PrimeiroNome
                , UltimoNome = usuario.Nome.UltimoNome
                , Mensagem = "Alterado com sucesso" //

            };
        }
    }
}

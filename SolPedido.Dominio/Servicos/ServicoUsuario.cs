using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SolPedido.Dominio.Argumentos.Base;
using SolPedido.Dominio.Argumentos.Usuario;
using SolPedido.Dominio.Entidades;
using SolPedido.Dominio.Interfaces.Repositorios;
using SolPedido.Dominio.Interfaces.Servicos;
using SolPedido.Dominio.Recursos;
using SolPedido.Dominio.ValorObjetos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolPedido.Dominio.Servicos
{
    public class ServicoUsuario : Notifiable, IServicoUsuario

    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public ServicoUsuario()
        {
        }

        public ServicoUsuario(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            Usuario usuario = new Usuario(nome, email, request.Senha);

            AddNotifications(nome, email);

            //if (this.IsInvalid())
            //{
            //    return null;
            // }

            if (_repositorioUsuario.Existe(x => x.Email.Endereco == request.Email))
            {
                AddNotification("E-mail", "Já existe e-mail"); // Mensagem.JA_EXISTE_UM_X0_CHAMADO_X1.ToFormat("e-mail", request.Email));
            }
            if (this.IsInvalid())
            {
                return null;
            }

            usuario = _repositorioUsuario.Adicionar(usuario);

            return (AdicionarUsuarioResponse)usuario;
        }        

        public AlterarUsuarioResponse AlterarUsuario(AlterarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarUsuarioRequest", Mensagem.X0_E_OBRIGATORIO.ToFormat("AlterarUsuarioRequest"));
            }

            Usuario usuario = _repositorioUsuario.ObterPorId(request.Id);
            if (usuario == null)
            {
                AddNotification("Id", "DADOS_NAO_ENCONTRADOS"); // Mensagem.DADOS_NAO_ENCONTRADOS
                return null;
            }

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            usuario.AlterarUsuario(nome, email, usuario.Status);

            AddNotifications(usuario);

            if (IsInvalid())
            {
                return null;
            }

            _repositorioUsuario.Editar(usuario);

            return (AlterarUsuarioResponse)usuario;
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            if (request == null)
            {                
                AddNotification("AutenticarUsuarioRequest", Mensagem.X0_E_OBRIGATORIO.ToFormat("AutenticarUsuarioRequest"));
            }

            var email = new Email(request.Email);
            var usuario = new Usuario(email, request.Senha);

            AddNotifications(usuario, email);
            if(usuario.IsInvalid())
            {
                return null;
            }

            //usuario = _repositorioUsuario.AutenticarUsuario(usuario.Email.Endereco, usuario.Senha);
            usuario = _repositorioUsuario.ObterPor(x => x.Email.Endereco == usuario.Email.Endereco, x => x.Senha == usuario.Senha);

            return (AutenticarUsuarioResponse)usuario;
        }
        
        public IEnumerable<UsuarioResponse> ListarUsuario()
        {
            return _repositorioUsuario.Listar().ToList().Select(Usuario => (UsuarioResponse)Usuario).ToList();
            // return _repositoryJogador.Listar().ToList().Select(jogador => (JogadorResponse)jogador).ToList();

        }

        public ResponseBase ExcluirUsuario(Guid id)
        {
            Usuario usuario = _repositorioUsuario.ObterPorId(id);

            if(usuario == null)
            {
                AddNotification("Id", "DADOS_NAO_ENCONTRADOS"); // Mensagem.DADOS_NAO_ENCONTRADOS
                return null;
            } else
            {
                _repositorioUsuario.Remover(usuario);

                return new ResponseBase();
            }
        }

    }
}

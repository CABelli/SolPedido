﻿using System;

namespace SolPedido.Dominio.Argumentos.Usuario
{
    public class AlterarUsuarioRequest
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
    }
}

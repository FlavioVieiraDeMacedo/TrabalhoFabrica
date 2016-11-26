using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeilaoFabrica.ViewModels
{
    public class UsuarioViewModel
    {
        public string Mensagem { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Tel { get; set; }
        public int Cep { get; set; }
        public string Complemento { get; set; }
    }
}
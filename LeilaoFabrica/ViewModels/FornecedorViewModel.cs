using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeilaoFabrica.ViewModels
{
    public class FornecedorViewModel
    {        
        public string Mensagem { get; set; }
        public string TipoMensagem { get; set; }

        #region FIELDS

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }

        //TODO:trocar nome no banco de Tel para Telefone
        public string Tel { get; set; }
        //TODO:adicionar ajax para pegar logradouro etc no formulário
        public int Cep { get; set; }
        public string Complemento { get; set; }

        #endregion

    }
}
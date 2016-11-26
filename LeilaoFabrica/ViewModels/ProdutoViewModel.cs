using LeilaoFabrica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeilaoFabrica.ViewModels
{
    public class ProdutoViewModel
    {
        //public SelectList Fornecedores { get; set; }        
        //public int[] FornecedoresId { get; set; }
        public string Mensagem { get; set; }
        public string TipoMensagem { get; set; }

        #region FIELDS

        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Descrição do Produto")]
        public string Descricao { get; set; }
        [Required]
        [Display(Name = "Valor do Produto ")]
        public decimal PrecoBase { get; set; }

        //TODO: verificar o campo Foto (image?string)
        //public byte[] Foto { get; set; }
        #endregion

    }
}
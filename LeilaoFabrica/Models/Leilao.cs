//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeilaoFabrica.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leilao
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_ProdutoFornecedor { get; set; }
        public decimal PrecoDoFornecedor { get; set; }
    
        public virtual ProdutoFornecedor ProdutoFornecedor { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

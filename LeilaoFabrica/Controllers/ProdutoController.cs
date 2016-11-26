using LeilaoFabrica.Models;
using LeilaoFabrica.UnitsOfWork;
using LeilaoFabrica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeilaoFabrica.Controllers
{
    public class ProdutoController : Controller
    {
        #region FIELDS

        private UnitOfWork _unit = new UnitOfWork();

        #endregion

        #region GETS

        [HttpGet]
        public ActionResult Cadastrar(string mensagem, string tipoMensagem)
        {
            var viewModel = new ProdutoViewModel()
            {
                Mensagem = mensagem,
                TipoMensagem = tipoMensagem
                //Fornecedores = ListarFornecedores()
            };
            return View(viewModel);
        }

        #endregion


        #region POSTS
        [HttpPost]
        public ActionResult Cadastrar(ProdutoViewModel pViewModel)
        {
            if (ModelState.IsValid)
            {
                var produto = new Produto()
                {
                    Nome = pViewModel.Nome,
                    Descricao = pViewModel.Descricao,
                    PrecoBase = pViewModel.PrecoBase,
                    //TODO: verificar Foto
                    Foto = new byte[1]                    
                    //TODO: trocar esse nome para Fornecedores                                  
                };

                //foreach(var id in pViewModel.FornecedoresId)
                //{
                //    Fornecedor f = _unit.FornecedorRepository.BuscarPorId(id);
                //    produto.ProdutoFornecedors.Add(f);
                //}

                _unit.ProdutoRepository.Cadastrar(produto);
                _unit.Save();

                return RedirectToAction("Cadastrar", 
                    new { mensagem = "Cadastro Realizado!", tipoMensagem = "alert alert-success" });
            }else
            {
                return View(pViewModel);
            }           
        }

        #endregion

        #region PRIVATE
        private SelectList ListarFornecedores()
        {
            return new SelectList(_unit.FornecedorRepository.Listar(), "Id", "Nome");
        }
        #endregion
    }
}
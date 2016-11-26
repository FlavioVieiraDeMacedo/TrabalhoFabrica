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
    public class FornecedorController : Controller
    {

        #region FIELDS

        private UnitOfWork _unit = new UnitOfWork();

        #endregion

        #region GETS
        [HttpGet]
        public ActionResult Cadastrar(string mensagem, string tipoMensagem)
        {
            var viewModel = new FornecedorViewModel()
            {
                Mensagem = mensagem,
                TipoMensagem = tipoMensagem
            };

            return View(viewModel);
        }

        #endregion

        #region POSTS
        [HttpPost]
        public ActionResult Cadastrar(FornecedorViewModel fViewModel)
        {
            if (ModelState.IsValid)
            {
                var fornecedor = new Fornecedor()
                {
                    Nome = fViewModel.Nome,
                    Email = fViewModel.Email,
                    Senha = fViewModel.Senha,
                    Cpf = fViewModel.Cpf,
                    Tel = fViewModel.Tel,
                    Cep = fViewModel.Cep,
                    Complemento = fViewModel.Complemento
                };

                _unit.FornecedorRepository.Cadastrar(fornecedor);
                _unit.Save();

                return RedirectToAction("Cadastrar", 
                    new { mensagem = "Cadastro Realizado!", tipoMensagem = "alert alert-success" });
            }else
            {
                return View(fViewModel);
            }           
        }
        #endregion
    }
}
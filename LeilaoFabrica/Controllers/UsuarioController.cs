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
    public class UsuarioController : Controller

    {
        private UnitOfWork _unit = new UnitOfWork();
        // GET: Usuario
        [HttpGet]
        public ActionResult Cadastrar(string msg)

        {
            var viewModel = new UsuarioViewModel()
            {
                Mensagem = msg
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Cadastrar(UsuarioViewModel usuarioViewModel)
        {
            var usuario = new Usuario()
            {
                Id = usuarioViewModel.Id,
                Nome = usuarioViewModel.Nome,
                Email = usuarioViewModel.Email,
                Senha = usuarioViewModel.Senha,
                Cpf = usuarioViewModel.Cpf,
                Cep = usuarioViewModel.Cep,
                Complemento = usuarioViewModel.Complemento,
                Tel = usuarioViewModel.Tel
            };
            _unit.UsuarioRepository.Cadastrar(usuario);

            _unit.Save();
            return RedirectToAction("Cadastrar", new { msg = "Cadastrado Com Sucesso!" });

        }
        
    }
}
﻿using LeilaoFabrica.Models;
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
        // GET: Usuario
        [HttpGet]
        public ActionResult Cadastrar(string msg)
        {
            var viewModel = new UsuarioViewModel()
            {
                Mensagem = msg
            };
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(UsuarioViewModel usuarioViewModel)
        {
            var usuario = ConverteEmUsuario(usuarioViewModel);
                _unit.UsuarioRepository.Cadastrar(usuario);
                _unit.Salvar();
                return RedirectToAction("Cadastro", new { msg = "Cadastrado Com Sucesso!" });
            
    }
        private Usuario ConverteEmUsuario(UsuarioViewModel usuarioViewModel)
        {
            Usuario usuario = new Usuario()
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
            return usuario;
        }
}
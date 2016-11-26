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
        [HttpPost]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}
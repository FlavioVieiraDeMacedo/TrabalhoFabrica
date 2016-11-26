using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeilaoFabrica.Controllers
{
    public class ProdutoController : Controller
    {
        #region GETS

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        #endregion
    }
}
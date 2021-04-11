using Inventario.Business;
using Inventario.Entity;
using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{
    public class RegistroEmpresaController : Controller
    {
        private modelList model;
        private BUPais bupais;

        public RegistroEmpresaController()
        {
            model = new modelList();
            bupais = new BUPais();
        }
        // GET: RegistroEmpresa
        public ActionResult RegistroEmpresa(ENRegistroEmpresa params)
        {
            string token = "";
            model.listPais = bupais.listaPaises(params,token);

            return View();
        }
    }
}
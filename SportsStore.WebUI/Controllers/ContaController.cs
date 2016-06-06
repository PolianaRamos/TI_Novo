using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ContaController : Controller
    {
        // GET: Conta
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            if(f["txtUsuario"] == "Paulo" &&  f["txtSenha"] == "123")
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(f["txtUsuario"],false);
                return Redirect("/");
            }

            return View();
        }

        public ActionResult LogOff()
        {
            System.Web.Security.FormsAuthentication.SignOut();

            return Redirect("/Conta/Login");
        }


    }
}
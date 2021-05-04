using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            Utilizador userModel = new Utilizador();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddorEdit(Utilizador userModel)
        {
            using (Receitas2020Entities dbModel = new Receitas2020Entities())
            {
                if(dbModel.Utilizador.Any(x => x.Username == userModel.Username))
                {
                    ViewBag.DuplicateMessage = "O UserName já existe!";
                    return View("AddOrEdit", userModel);
                }
                dbModel.Utilizador.Add(userModel);
                dbModel.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Criado com Sucesso";
            return View("AddorEdit", new Utilizador());
        }
    }
}
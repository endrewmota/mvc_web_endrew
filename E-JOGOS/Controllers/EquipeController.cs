using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_JOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();


        // GET: /<controller>/
        public IActionResult Index()
        {
            //VIEW = responssavel pela exibicao da frontend.

            //ViewBag = armazenar as informacoes da backend para serem acessadas
            //no fronetend. (CONTROLLER PARA VIEW

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }

        public IActionResult Cadastrar(IFormCollection form);
    }
}

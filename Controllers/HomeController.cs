using Fiap01.Data;
using Fiap01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Controllers
{
    public class HomeController : Controller
    {

        private PerguntasContext _context;

        public HomeController(PerguntasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //ViewBag.Nome = "Everton";
            //ViewData["NomeDoAluno"] = $"Outro Nome {DateTime.Now.TimeOfDay}";

            //Imaginem um acesso ao DB

            //var pergunta = new Pergunta() {

            //    Id = 1,
            //    Autor = "Daniel",
            //    Descricao = "Teste teste"             

            //};

            return View(_context.Perguntas.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                // Salva no banco

                _context.Perguntas.Add(pergunta);
                
                await _context.SaveChangesAsync();


                var a = pergunta;
            }
           
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(IFormCollection collection)
        //{
        //    var desc = collection["Descricao"];
        //    return View(desc);
        //}



        public IActionResult Ajuda()
        {
            return View();
        }
        public IActionResult Sobre()
        {
            return View();
        }
    }
}

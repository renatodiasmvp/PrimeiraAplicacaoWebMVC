using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicacaoMVC.Models;

namespace CalculadoraDePinturaMVC.Controllers
{
    public class CalculadoraPinturaController : Controller
    {
        private CalculadoraDePintura calculadora = new CalculadoraDePintura();
        
        // GET: Calculadora
        public ActionResult Index()
        {
            return View();
        }

        

        // POST: Calculadora/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind("Largura,Altura,Profundidade")] Comodo comodo)
        {
            Double quantidadeEmlitros = 0;
            
              quantidadeEmlitros = calculadora.calcularLitragem(comodo);

                return RedirectToRoute(new {Controller = "CalculadoraPintura", Action = "QuantidadeLitros", litros = quantidadeEmlitros});        
        }

        // GET: Calculadora/Lista/5
        public ActionResult QuantidadeLitros(Double litros)
        {
            ViewBag.Litros = Math.Round(litros, 2);
            
            return View();
        }

        
    }
}
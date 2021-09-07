using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula3.Models;

namespace Aula3.Controllers
{
    public class InicialController : Controller
    {
        // Get: Inicial
        public IActionResult Index()
        {
           return View();

        }

        public string Welcome()
        {

            return "Testando retorno";
        }
        
}
}
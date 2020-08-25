using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebVendas.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Mensagem"] = "Esta é uma Página de Teste";
            ViewData["Email"] = "hericson@prof.faccar.com.br";
            return View();
        }
    }
}

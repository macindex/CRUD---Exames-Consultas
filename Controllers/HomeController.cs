using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CH.ExamesConsultas.UI.Models;

namespace CH.ExamesConsultas.UI.Controllers
{
    public class HomeController : Controller
    { 

        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Consultas()
        {
            return View();
        }
        public ViewResult Sobre()
        {
            return View();
        }

    }
}


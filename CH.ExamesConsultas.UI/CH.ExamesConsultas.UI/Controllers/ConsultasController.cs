
using CH.ExamesConsultas.UI.Data;
using CH.ExamesConsultas.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CH.ExamesConsultas.UI.Controllers
{
    public class ConsultasController : Controller
    {
        public ViewResult Index()
        {
           return View();
        }
    }
}

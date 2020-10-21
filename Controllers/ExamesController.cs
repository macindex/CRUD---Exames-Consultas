using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.ExamesConsultas.UI.Controllers
{
    public class ExamesController : Controller
    {
        public ViewResult Index() 
        {
            return View();
        }
    }
}

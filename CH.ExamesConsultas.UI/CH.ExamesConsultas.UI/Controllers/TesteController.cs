using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CH.ExamesConsultas.UI.Controllers
{
    public class TesteController:Controller
    {
        public string Ping() 
        {
            return "Pong";
        }
    }
}

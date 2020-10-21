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
    public class PacientesController : Controller
    {
        private readonly CHExamesConsultasDataContext _ctx = new CHExamesConsultasDataContext();

        

        public ViewResult Index()
        {
            ///IList<Paciente> pacientes = null;
            ///using (var ctx = new CHExamesConsultasDataContext())
            ///var ctx = new CHExamesConsultasDataContext();
            ///
            {
                var pacientes = _ctx.Pacientes.ToList();
                return View(pacientes);
            }
            
        }
            [HttpGet]
            public ViewResult AddEd(int? id)
            {
                Paciente paciente = new Paciente();

                if(id != null)
                {
                 paciente = _ctx.Pacientes.Find(id);
                }
                return View(paciente);
            }
            
           
            [HttpPost]
            public ActionResult AddEd(Paciente paciente)
            {
                _ctx.Pacientes.Add(paciente);
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }
        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }

    }
}

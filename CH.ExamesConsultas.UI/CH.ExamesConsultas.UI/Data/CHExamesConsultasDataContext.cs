using CH.ExamesConsultas.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.ExamesConsultas.UI.Data
{
    public class CHExamesConsultasDataContext:DbContext
    {
        public CHExamesConsultasDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=chexamesconsultas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Paciente>Pacientes{ get; set; }

        public DbSet<Consulta> Consultas { get; set; }

    }
}

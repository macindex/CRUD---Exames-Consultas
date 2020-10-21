using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.ExamesConsultas.UI.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public DateFormat DataNasc { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.Entities
{
    public class Asignatura
    {
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int AulaId { get; set; }
        public int CicloId { get; set; }
        public int FacultadId { get; set; }
    }
}

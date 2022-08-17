using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.Entities
{
    public class Carrera
    {
        public int CarreraId { get; set; }
        public string Nombre { get; set; }
        public int FacultadId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.Entities
{
    public class Estudiante
    {
        public int EstudianteId { get; set; } 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Codigo { get; set; }
        public int CarreraId { get; set; }
        public string NumTelefono { get; set; }
        public string Genero { get; set; }
        public string Natalicio { get; set; }
        public int EstadoId { get; set; }
        public byte[] Foto { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public int Dias { get; set; }

        public Libro() { }

        public Libro(string titulo, string tipo, int dias)
        {
            Titulo = titulo;
            Tipo = tipo;
            Dias = dias;
        }
    }
}

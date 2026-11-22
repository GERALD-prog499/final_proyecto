using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class ControlAcademico
    {
        public static bool ValidarAcceso(string entradaCodigo, string entradaCiclo, out int ciclo, out string mensajeError)
        {
            ciclo = 0;
            mensajeError = "";

            if (!int.TryParse(entradaCodigo, out _) || entradaCodigo.Trim().Length != 8)
            {
                mensajeError = "Error: El código debe tener EXACTAMENTE 8 dígitos numéricos.";
                return false;
            }

            if (!int.TryParse(entradaCiclo, out ciclo) || ciclo < 1 || ciclo > 10)
            {
                mensajeError = "Error: El ciclo debe ser un número entre 1 y 10.";
                return false;
            }

            return true;
        }
    }
}

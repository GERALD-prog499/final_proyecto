using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class GestorPrestamos
    {
        public static int max_prestamos = 5;

        public static int CalcularDiasPrestamo(int ciclo, string tipoLibro)
        {
            if (ciclo >= 5 || tipoLibro.ToLower() == "general")
                return 7;
            else
                return 3;
        }

        public static void SolicitarPrestamo(ref int prestamosActivos)
        {
            prestamosActivos++;
        }
    }
}


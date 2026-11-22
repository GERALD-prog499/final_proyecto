using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROYECTO_FINAL
{
    public class InventarioBiblioteca
    {
        // Ordenamiento Burbuja con string.Compare
        public static void OrdenarAlfabeticamente(List<Libro> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = 0; j < lista.Count - i - 1; j++)
                {
                    if (string.Compare(lista[j].Titulo, lista[j + 1].Titulo, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Libro aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
                }
            }
        }

        // Búsqueda parcial con IndexOf y fragmento con Substring
        public static List<string> BuscarPorPalabra(List<Libro> lista, string palabra)
        {
            List<string> resultados = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                int pos = lista[i].Titulo.IndexOf(palabra, StringComparison.OrdinalIgnoreCase);
                if (pos != -1)
                {
                    string prefijo = lista[i].Titulo.Length >= 4
                        ? lista[i].Titulo.Substring(0, 4).ToUpper()
                        : lista[i].Titulo.ToUpper();

                    resultados.Add($"[{prefijo}] {lista[i].Titulo} ({lista[i].Tipo}) - Pos: {pos}");
                }
            }
            return resultados;
        }

        // Reemplazo en títulos con Replace
        public static void ReemplazarEnTitulos(List<Libro> lista, string antigua, string nueva)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Titulo = lista[i].Titulo.Replace(antigua, nueva);
            }
        }

        // Conteo recursivo de libros Especializados
        public static int ContarEspecializadosRecursivo(List<Libro> lista, int indice)
        {
            if (indice >= lista.Count)
                return 0;

            int suma = lista[indice].Tipo.Equals("Especializado", StringComparison.OrdinalIgnoreCase) ? 1 : 0;
            return suma + ContarEspecializadosRecursivo(lista, indice + 1);
        }

        // Persistencia en archivo TXT y separación con Split
        public static void GuardarEnArchivo(string ruta, List<Libro> lista)
        {
            using (StreamWriter sw = new StreamWriter(ruta, false))
            {
                foreach (Libro l in lista)
                {
                    sw.WriteLine($"{l.Titulo};{l.Tipo};{l.Dias}");
                }
            }
        }

        public static List<Libro> CargarDesdeArchivo(string ruta)
        {
            List<Libro> cargados = new List<Libro>();
            if (!File.Exists(ruta)) return cargados;

            using (StreamReader sr = new StreamReader(ruta))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(';');
                    if (datos.Length == 3 && int.TryParse(datos[2], out int dias))
                    {
                        cargados.Add(new Libro(datos[0], datos[1], dias));
                    }
                }
            }
            return cargados;
        }
    }
}


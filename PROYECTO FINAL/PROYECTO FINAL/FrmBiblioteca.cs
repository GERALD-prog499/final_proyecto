using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FrmBiblioteca : Form
    {
        private List<Libro> listaLibros = new List<Libro>();
        private int cicloEstudiante;
        private int prestamosActivos = 0;
        private string rutaArchivo = "prestamos_upn.txt";

        public FrmBiblioteca(string codigo, int ciclo)
        {
            InitializeComponent();
            cicloEstudiante = ciclo;
            lblInfoUsuario.Text = $"Estudiante: N{codigo} | Ciclo: {ciclo}";
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = listaLibros;
            lblContador.Text = $"Préstamos Activos: {prestamosActivos} / {GestorPrestamos.max_prestamos}";
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (prestamosActivos >= GestorPrestamos.max_prestamos)
            {
                MessageBox.Show("Ha alcanzado el límite máximo de 5 préstamos.", "Límite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("Ingrese el título del libro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string titulo = txtTituloLibro.Text.Trim();
            string tipo = cboTipo.SelectedItem.ToString();
            int dias = GestorPrestamos.CalcularDiasPrestamo(cicloEstudiante, tipo);

            GestorPrestamos.SolicitarPrestamo(ref prestamosActivos);
            listaLibros.Add(new Libro(titulo, tipo, dias));

            txtTituloLibro.Clear();
            txtTituloLibro.Focus();
            ActualizarTabla();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            InventarioBiblioteca.OrdenarAlfabeticamente(listaLibros);
            ActualizarTabla();
        }

        private void btnContarEsp_Click(object sender, EventArgs e)
        {
            int total = InventarioBiblioteca.ContarEspecializadosRecursivo(listaLibros, 0);
            MessageBox.Show($"Cantidad de libros Especializados (recursivo): {total}", "Conteo Recursivo");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text)) return;
            List<string> encontrados = InventarioBiblioteca.BuscarPorPalabra(listaLibros, txtBuscar.Text.Trim());

            if (encontrados.Count == 0)
                MessageBox.Show("No se encontraron coincidencias.", "Búsqueda");
            else
                MessageBox.Show(string.Join("\n", encontrados), "Resultados (IndexOf + Substring)");
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVieja.Text)) return;
            InventarioBiblioteca.ReemplazarEnTitulos(listaLibros, txtVieja.Text, txtNueva.Text);
            ActualizarTabla();
        }

        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            InventarioBiblioteca.GuardarEnArchivo(rutaArchivo, listaLibros);
            MessageBox.Show("Préstamos guardados en prestamos_upn.txt", "Persistencia");
        }

        private void btnCargarTxt_Click(object sender, EventArgs e)
        {
            listaLibros = InventarioBiblioteca.CargarDesdeArchivo(rutaArchivo);
            prestamosActivos = listaLibros.Count;
            ActualizarTabla();
            MessageBox.Show("Datos recuperados desde prestamos_upn.txt", "Persistencia");
        }
    }
}

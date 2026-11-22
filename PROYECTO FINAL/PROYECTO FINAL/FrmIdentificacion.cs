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
    public partial class FrmIdentificacion : Form
    {
        public FrmIdentificacion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ControlAcademico.ValidarAcceso(txtCodigo.Text, txtCiclo.Text, out int cicloValidado, out string error))
            {
                MessageBox.Show("¡Acceso concedido! Bienvenido a la red UPN.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmBiblioteca frm = new FrmBiblioteca(txtCodigo.Text.Trim(), cicloValidado);
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

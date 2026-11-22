namespace PROYECTO_FINAL
{
    partial class FrmBiblioteca
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnContarEsp;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtVieja;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Button btnGuardarTxt;
        private System.Windows.Forms.Button btnCargarTxt;
        private System.Windows.Forms.DataGridView dgvLibros;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnContarEsp = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtVieja = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.btnGuardarTxt = new System.Windows.Forms.Button();
            this.btnCargarTxt = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();

            this.lblInfoUsuario.AutoSize = true;
            this.lblInfoUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblInfoUsuario.Location = new System.Drawing.Point(20, 15);
            this.lblInfoUsuario.Text = "Estudiante: N00000000 | Ciclo: 1";

            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblContador.Location = new System.Drawing.Point(430, 15);
            this.lblContador.Text = "Préstamos Activos: 0 / 5";

            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Location = new System.Drawing.Point(20, 55);
            this.lblTituloLibro.Text = "Título del Libro:";

            this.txtTituloLibro.Location = new System.Drawing.Point(120, 52);
            this.txtTituloLibro.Size = new System.Drawing.Size(220, 22);

            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(355, 55);
            this.lblTipo.Text = "Tipo:";

            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Items.AddRange(new object[] { "General", "Especializado" });
            this.cboTipo.Location = new System.Drawing.Point(395, 52);
            this.cboTipo.SelectedIndex = 0;
            this.cboTipo.Size = new System.Drawing.Size(115, 24);

            this.btnSolicitar.Location = new System.Drawing.Point(520, 50);
            this.btnSolicitar.Size = new System.Drawing.Size(110, 26);
            this.btnSolicitar.Text = "Registrar";
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);

            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(20, 90);
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.Size = new System.Drawing.Size(610, 170);

            this.btnOrdenar.Location = new System.Drawing.Point(20, 275);
            this.btnOrdenar.Size = new System.Drawing.Size(145, 28);
            this.btnOrdenar.Text = "Ordenar A-Z (Burbuja)";
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);

            this.btnContarEsp.Location = new System.Drawing.Point(175, 275);
            this.btnContarEsp.Size = new System.Drawing.Size(165, 28);
            this.btnContarEsp.Text = "Contar Esp. (Recursivo)";
            this.btnContarEsp.Click += new System.EventHandler(this.btnContarEsp_Click);

            this.btnGuardarTxt.Location = new System.Drawing.Point(380, 275);
            this.btnGuardarTxt.Size = new System.Drawing.Size(120, 28);
            this.btnGuardarTxt.Text = "Guardar TXT";
            this.btnGuardarTxt.Click += new System.EventHandler(this.btnGuardarTxt_Click);

            this.btnCargarTxt.Location = new System.Drawing.Point(510, 275);
            this.btnCargarTxt.Size = new System.Drawing.Size(120, 28);
            this.btnCargarTxt.Text = "Cargar TXT";
            this.btnCargarTxt.Click += new System.EventHandler(this.btnCargarTxt_Click);

            this.txtBuscar.Location = new System.Drawing.Point(20, 320);
            this.txtBuscar.Size = new System.Drawing.Size(180, 22);

            this.btnBuscar.Location = new System.Drawing.Point(210, 318);
            this.btnBuscar.Size = new System.Drawing.Size(130, 26);
            this.btnBuscar.Text = "Buscar (IndexOf)";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            this.txtVieja.Location = new System.Drawing.Point(20, 360);
            this.txtVieja.Size = new System.Drawing.Size(115, 22);

            this.txtNueva.Location = new System.Drawing.Point(145, 360);
            this.txtNueva.Size = new System.Drawing.Size(115, 22);

            this.btnReemplazar.Location = new System.Drawing.Point(270, 358);
            this.btnReemplazar.Size = new System.Drawing.Size(130, 26);
            this.btnReemplazar.Text = "Replace en Títulos";
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);

            this.ClientSize = new System.Drawing.Size(650, 405);
            this.Controls.Add(this.lblInfoUsuario);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblTituloLibro);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnContarEsp);
            this.Controls.Add(this.btnGuardarTxt);
            this.Controls.Add(this.btnCargarTxt);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtVieja);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.btnReemplazar);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Préstamos - Biblioteca UPN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
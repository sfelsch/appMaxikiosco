using CapaDominio;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosco
{
    public partial class frmUsuario : Form
    {

        Usuario usuario = null;
        public frmUsuario()
        {
            InitializeComponent();

        }

        public frmUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            cargarGrillaUsuarios();
            ocultarColumnas();
        }


        private void cargarGrillaUsuarios()
        {
            UsuarioNegocio negocio = new UsuarioNegocio();

            try
            {
                dgvUsuarios.DataSource = negocio.listaUsuario();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ocultarColumnas()
        {
            dgvUsuarios.Columns["Password"].Visible= false;
         

        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usuario.NomUsuario))
            {
                frmAltaUsuario ventana = new frmAltaUsuario(usuario);
                ventana.Show();
                this.Close();
            }
            else
            {
                frmAltaUsuario ventana = new frmAltaUsuario();
                ventana.Show();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal pantalla = new frmPrincipal();
            pantalla.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void brnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

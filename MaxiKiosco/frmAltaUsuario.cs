using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaNegocio;

namespace MaxiKiosco
{
    public partial class frmAltaUsuario : Form
    {
        Usuario usuario = null;
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        public frmAltaUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            RolNegocio negocio = new RolNegocio();
            try
            {
                cmbRol.DataSource = negocio.listaRoles();
                cmbRol.DisplayMember = "nombre";
                cmbRol.ValueMember = "id";
               
                    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                usuario = new Usuario();

                usuario.NomUsuario = txtNombreUsuario.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Password = txtPassword.Text;
                usuario.Rol = (Rol)cmbRol.SelectedItem;

                negocio.NuevoUsuario(usuario);

                MessageBox.Show("Usuario dado de alta");

                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmUsuario ventana = new frmUsuario();
            ventana.Show();
            this.Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosYLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosYLetras(e);
        }
    }
}

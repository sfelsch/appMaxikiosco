
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
    public partial class frmPrincipal : Form
    {
        private Usuario user = null;

        public frmPrincipal(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lblNombre.Text = user.Nombre + " " + user.Apellido;
            if (user.Rol.Id == 1)
            {
                lblUsuarioTipo.Text = "Administrador";
            }
            else
            {
                lblUsuarioTipo.Text = "Vendedor";
            }

            

        }
        public frmPrincipal()
        {
            InitializeComponent();
           
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            formProveedor pantalla = new formProveedor();
            pantalla.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            formProductos pantalla = new formProductos();
            pantalla.Show();
            this.Close();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            formClientes pantalla = new formClientes();
            pantalla.Show();
            this.Close();
            
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras pantalla = new frmCompras();
            pantalla.Show();
            this.Close();

        }
        int mx, my;
        bool m = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == true)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 0, MousePosition.Y - my);

            }
        }

        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin pantalla = new frmLogin();
            pantalla.Show();
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                frmUsuario ventana = new frmUsuario(user);
                ventana.Show();
                this.Close();
            }
            else
            {
                frmUsuario ventana = new frmUsuario();
                ventana.Show();
                this.Close();
            }
            
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            formSeleccionClienteFacturacion pantalla = new formSeleccionClienteFacturacion();
            pantalla.Show();
            this.Close();
        }

      

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (Helper.Login.Rol.Nombre == "Vendedor")
            {
                btnProducto.Enabled = false;
                btnProductos.Enabled = false;
                btnAgregarUsuario.Enabled = false;
                btnCompras.Enabled = false;
            }
        }

     

        private void btnContable_Click_1(object sender, EventArgs e)
        {
            FormContable pantalla = new FormContable();
            pantalla.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            formInventario pantalla = new formInventario();
            pantalla.Show();
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = false;
        }

       
    }
}

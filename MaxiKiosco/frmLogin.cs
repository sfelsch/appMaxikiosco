using CapaDominio;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosco
{
    public partial class frmLogin : Form
    {
        private List<Usuario> listaUsuarios = null;
        Helper helper = new Helper();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            dibujarLinea(e);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            dibujarLinea(e);
        }

        private void dibujarLinea(PaintEventArgs e)
        {
            // Obtén el objeto Graphics para dibujar en el PictureBox
            Graphics g = e.Graphics;

            // Dibuja una línea horizontal en el centro del PictureBox
            int y = pictureBox1.Height / 2;
            g.DrawLine(Pens.DimGray, 0, y, pictureBox1.Width, y);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            dibujarLinea(e);
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar= true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar= false;
            }
        }

        private void txtIniciar_Click(object sender, EventArgs e)
        {
            validarUsuario();


        }

        public void validarUsuario()
        {
            Usuario user = new Usuario();

            UsuarioNegocio negocio = new UsuarioNegocio();
            listaUsuarios = negocio.listaUsuario();
            foreach (Usuario usuario in listaUsuarios)
            {
                if (txtUsuario.Text.Equals(usuario.NomUsuario))
                {
                    if (txtPass.Text.Equals(usuario.Password))
                    {

                        helper.mostrarMensaje("Usuario y Contraseña Correctos", "Info", "Bienvenido");
                        frmPrincipal pantalla = new frmPrincipal(usuario);
                        Helper.Login = usuario;
                        pantalla.Show();
                        this.Close();
                        user = usuario;
                        break;
                    }
                    else
                    {
                        //user = usuario;
                        helper.mostrarMensaje("Contraseña incorrecta", "Error", "ERROR AL INICIAR SESION");
                        break;

                    }
                }
                else
                {
                    user = null;
                }
            }

            if(user == null)
            {
                helper.mostrarMensaje("Usuario incorrecto", "Error", "ERROR AL INICIAR SESION");
            }
        }
    }
}

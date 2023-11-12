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
    public partial class frmAltaProvedor : Form
    {

        private Provedor provedor = null;
        public frmAltaProvedor(Provedor provedor)
        {
            InitializeComponent();
            this.provedor = provedor;
            lblTitulo.Text = "Modificar Provedor";
        }

        public frmAltaProvedor()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo Provedor";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formProveedor ventana = new formProveedor();
            ventana.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ProvedorNegocio provedorNegocio = new ProvedorNegocio();

            string cuit = txtCuit.Text;
            bool validarEmpresa = Helper.CuilEmpresa(cuit);
            bool esValido = Helper.ValidarCUIL(cuit);

            if(esValido == true)
            {

            

            try
            {
                if (provedor == null)
                    provedor = new Provedor();

                

                provedor.Nombre = txtNombre.Text;
                provedor.Telefono = int.Parse(txtTelefono.Text);
                provedor.Mail = txtMail.Text;
                provedor.Direccion = txtDireccion.Text;
                provedor.Cuit = txtCuit.Text;
                provedor.Activo = true;

                TextBox[] arrayTextbox = new TextBox[] { txtNombre, txtTelefono, txtMail, txtDireccion, txtCuit };

                bool camposIncompletos = false;

                foreach (var item in arrayTextbox)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        camposIncompletos = true;
                        break;
                    }
                
                }

                if (camposIncompletos == false)
                {
                    if (provedor.Id != 0)
                    {
                        provedorNegocio.modificarProvedor(provedor);
                        DialogResult resultado = MessageBox.Show("Modificaste el provedor exitosamente!!!", "Modificacion Provedor", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            formProveedor ventana = new formProveedor();
                            ventana.Show();
                            this.Close();
                        }

                    }
                    else
                    {
                        provedorNegocio.agregarProvedor(provedor);
                        DialogResult resultado = MessageBox.Show("Agregaste el provedor exitosamente!!!", "Nuevo Provedor", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            formProveedor ventana = new formProveedor();
                            ventana.Show();
                            this.Close();
                        }

                    }
                }

                else
                {
                    MessageBox.Show("Debe Completar todos los campos para dar el alta o modificacion a un proveedor");
                }

               
                



            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.ToString());
                //MessageBox.Show("Debe Completar todos los campos para dar el alta o modificacion a un proveedor");

            }

            }
            else
            {
                MessageBox.Show("Cuit no es valido");
            }
        }

        private void frmAltaProvedor_Load(object sender, EventArgs e)
        {
            try
            {
                if(provedor != null)
                {
                    txtCuit.Text = provedor.Cuit.ToString();
                    txtDireccion.Text = provedor.Direccion;
                    txtMail.Text = provedor.Mail;
                    txtNombre.Text = provedor.Nombre;
                    txtTelefono.Text = provedor.Telefono.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mx, my;
        bool m = false;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == true)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 0, MousePosition.Y - my);

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumeros(e);
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (!Helper.validarEmail(txtMail.Text))
            {
                if (string.IsNullOrEmpty(txtMail.Text))
                {

                }

                else
                {
                    MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Correo electrónico inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMail.Focus();
                }

            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosYLetras(e);
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumerosYLetras(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }
    }
}

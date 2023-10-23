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
    public partial class frmAltaCliente : Form
    {

        private Cliente cliente = null;

        public frmAltaCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            lblTitulo.Text = "Modificar Cliente";
        }

        public frmAltaCliente()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo Cliente";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            try
            {
                cmbCondIva.DataSource = clienteNegocio.listaCliente();
                cmbCondIva.DisplayMember = "condicionIva";
                cmbCondIva.ValueMember = "Id";

                if(cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtTelefono.Text = cliente.Telefono;
                    txtMail.Text = cliente.Mail;
                    txtLocalidad.Text = cliente.Localidad;
                    txtFechaNac.Text = cliente.FechaNacimiento;
                    txtDni.Text = cliente.Dni;
                    txtDireccion.Text = cliente.Direccion;
                    txtCuilCuit.Text = cliente.CuilCuit;
                    txtApellido.Text = cliente.Apellido;
                }
              
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mx, my;
        bool m = false;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == true)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 0, MousePosition.Y - my);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = false;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            try
            {
                if (cliente == null)
                    cliente = new Cliente();


                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = txtDni.Text;
                cliente.CuilCuit = txtCuilCuit.Text;
                cliente.FechaNacimiento = txtFechaNac.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Localidad = txtLocalidad.Text;
                cliente.Mail = txtMail.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.CondicionIva = cmbCondIva.Text;
                cliente.Activo = true;

                TextBox[] arrayTxt = new TextBox[] { txtApellido, txtCuilCuit, txtDireccion, txtDni, txtFechaNac, txtLocalidad, txtMail, txtNombre, txtTelefono };

                bool camposIncompletos = false;

                foreach (var item in arrayTxt)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        camposIncompletos= true;
                        break;
                    }
                    else
                    {

                    }
                }

                if (camposIncompletos == false)
                {
                    if (cliente.Id != 0)
                    {
                        clienteNegocio.modificarCliente(cliente);
                        DialogResult resultado = MessageBox.Show("Modificaste el cliente exitosamente!!", "Modificacion de Cliente", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            formClientes ventana = new formClientes();
                            ventana.Show();
                            this.Close();
                        }

                    }
                    else
                    {
                        clienteNegocio.agregarCliente(cliente);
                        DialogResult resultado = MessageBox.Show("Agregaste el cliente exitosamente!!", "Modificacion de Cliente", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            formClientes ventana = new formClientes();
                            ventana.Show();
                            this.Close();
                        }

                    }
                }

                else
                {
                    MessageBox.Show("Debe Completar todos los campos para dar el alta o modificacion a un Cliente");
                }

               


            }
            catch (Exception)
            {

                MessageBox.Show("Debe Completar todos los campos para dar el alta o modificacion a un Cliente");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            formClientes ventana = new formClientes();
            ventana.Show();
            this.Close();
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumeros(e);
        }

        private void txtCuilCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumeros(e);
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }
    }
}

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
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            cargarTextBox();
        }
        public void cargarTextBox()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select nombre, apellido, dni, cuilCuit, fechaNacimiento, direccion, localidad, mail, telefono, condicionIva from CLIENTE WHERE id=1;");

                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Cliente auxiliar = new Cliente();
                    txtNombreCliente.Text = (string)datos.Lector["nombre"];
                    txtApellido.Text = (string)datos.Lector["apellido"];
                    txtDni.Text = (string)datos.Lector["dni"];
                    txtCuilCuit.Text = (string)datos.Lector["cuilCuit"];
                    txtFechaNac.Text = (string)datos.Lector["fechaNacimiento"];
                    txtDireccion.Text= (string)datos.Lector["direccion"];
                    txtLocalidad.Text = (string)datos.Lector["localidad"];
                    txtMail.Text= (string)datos.Lector["mail"];
                    txtTelefono.Text= (string)datos.Lector["telefono"];
                    cmbCondIva.Text= (string)datos.Lector["condicionIva"];
                   //cmbActivo.Text= (string)datos.Lector["activo"];


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;

namespace CapaNegocio
{
    public class Helper
    {
        public static Usuario Login { get; set; }

        public void mostrarMensaje(string mensaje, string tipo, string titulo)
        {
            if (tipo.Equals("Error"))
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tipo.Equals("Info"))
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void soloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter ingresado se muestre en el TextBox
            }
        }

        public static void soloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public static void soloNumerosYLetras(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public static void soloNumerosYLetrasYEspacios(KeyPressEventArgs e, TextBox textBox)
        {
            if (e.KeyChar == ' ' && (textBox.Text.Length == 0 || textBox.SelectionStart == 0 || textBox.Text[textBox.SelectionStart - 1] == ' '))
            {
                e.Handled = true; // Evita espacios al principio o más de 2 espacios seguidos
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; // Evita caracteres no permitidos
            }
        }


        public static bool validarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        public static void UnaComa(KeyPressEventArgs e, String cadena)
        {
            bool validar = true;
            int contador = 0;
            string caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if (caracter == ",")
                {
                    contador++;
                }
            }

            if (contador == 0)
            {
                validar = true;
                if (e.KeyChar == ',' && validar)
                {
                    validar = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            else
            {
                validar = false;
                e.Handled = true;


                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }


        }
        public static AutoCompleteStringCollection CargarDatosClientes()
        {

            ClienteNegocio negociocliente = new ClienteNegocio();
            List<Cliente> listaClientes = negociocliente.listaCliente();


            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            foreach (var cliente in listaClientes)
            {
                datos.Add(cliente.Apellido.ToString());
            }

            return datos;


        }

        public static AutoCompleteStringCollection CargarDatosProductos()
        {

            ProductoNegocio negocioProducto = new ProductoNegocio();
            List<Producto> listaProducto = negocioProducto.listarProducto();


            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            foreach (var producto in listaProducto)
            {
                datos.Add(producto.Categoria.ToString());
            }

            return datos;


        }

        public static AutoCompleteStringCollection CargarDatosProveedor()
        {

            ProvedorNegocio negocioProveedor = new ProvedorNegocio();
            List<Provedor> listaProveedor = negocioProveedor.listaProvedor();


            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            foreach (var proveedor in listaProveedor)
            {
                datos.Add(proveedor.Nombre.ToString());
            }

            return datos;


        }


        public static bool ValidarCUIL(string cuil)
        {
            if (cuil.Length != 11)
            {
                return false;
            }

            int[] pesos = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma += int.Parse(cuil[i].ToString()) * pesos[i];
            }

            int residuo = suma % 11;
            int verificadorCalculado = 11 - residuo;

            if (verificadorCalculado == 11)
            {
                verificadorCalculado = 0;
            }

            int verificador = int.Parse(cuil[10].ToString());
            return verificador == verificadorCalculado;
        }

        public static bool CuilPersona(string cuil)
        {
            string nuemrosValidadores = "";

            for (int i = 0; i < 2; i++)
            {
                nuemrosValidadores += cuil[i];
            }



            if (nuemrosValidadores.Contains("20") || nuemrosValidadores.Contains("27"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CuilEmpresa(string cuil)
        {
            string nuemrosValidadores = "";

            for (int i = 0; i < 2; i++)
            {
                nuemrosValidadores += cuil[i];
            }
            if (nuemrosValidadores.Contains("30"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CompararDniYCuit(string cuil, string dni)
        {
            string cuilAdni = "";

            for (int i = 0; i < 10; i++)
            {
                if (i > 1)
                    cuilAdni += cuil[i];
            }

            return dni == cuilAdni;
        }
    }
}

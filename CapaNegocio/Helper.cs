using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Helper
    {
        public void mostrarMensaje(string mensaje, string tipo, string titulo)
        {
            if (tipo.Equals("Error"))
            {
                MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

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
using System.Drawing.Imaging;

namespace MaxiKiosco
{
    public partial class formFacturaB : Form
    {
        private Cliente clienteSeleccionado;
        private DataGridViewRowCollection productosEnCarrito;

        public formFacturaB(Cliente clienteSel, DataGridViewRowCollection productosCarrito)
        {
            InitializeComponent();
            ////////////////////////////////7777
            clienteSeleccionado = clienteSel;
            productosEnCarrito = productosCarrito;
            dgvFactura.Columns.Add("Id", "Id");
            dgvFactura.Columns["Id"].Visible = false;
            dgvFactura.Columns.Add("Cantidad", "Cantidad");
            dgvFactura.Columns.Add("Marca", "Detalle");
            dgvFactura.Columns.Add("Precio", "Precio");
            dgvFactura.Columns[1].Width = 200;
            // Llena los controles con los datos del cliente y los productos
            // lblCondicionIva.Text = clienteSeleccionado.CondicionIva;
            lblNombre.Text = $"{clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";
            lblCuit.Text = $"{clienteSeleccionado.CuilCuit}";
            lblDomicilio.Text = $"{clienteSeleccionado.Direccion}";
            lblLocalidad.Text = $"{clienteSeleccionado.Localidad}";
            lblTelefono.Text = $"{clienteSeleccionado.Telefono}";
            lblCondicionIva.Text= $"{clienteSeleccionado.CondicionIva}";
            
           

            // Llena el DataGridView dgvFactura con los productos del carrito
            foreach (DataGridViewRow productoRow in productosEnCarrito)
            {
                dgvFactura.Rows.Add(
                    productoRow.Cells["Id"].Value,
                    productoRow.Cells["Cantidad"].Value,
                    productoRow.Cells["Marca"].Value,
                    productoRow.Cells["PrecioFactura"].Value
                    
                );
            }
            decimal totalFacturaB = CalcularTotalFacturaB();
            lblTotal.Text = totalFacturaB.ToString();

        }
        private decimal CalcularTotalFacturaB()
        {
            decimal totalFacturaB = 0;

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                if (decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out decimal subtotal))
                {
                    totalFacturaB += subtotal;
                }
            }

            return totalFacturaB;
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
           formFacturacion ventana = new formFacturacion(clienteSeleccionado);
           ventana.Show();
            this.Close();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            //pongo un textBox para ver con cuanto paga, si esta vacio avisar, si es menor al monto avisar y si esta
            //todo ok, seguir con el curso---->
            decimal totalFactura = CalcularTotalFacturaB();

            // Verificar si el txtAbonaCon está vacío
            if (string.IsNullOrWhiteSpace(txtAbonaCon.Text))
            {
                MessageBox.Show("Debes ingresar el monto con el que abona la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el monto abonado ingresado
            if (!decimal.TryParse(txtAbonaCon.Text, out decimal montoAbonado))
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el monto abonado es menor al total de la factura
            if (montoAbonado < totalFactura)
            {
                MessageBox.Show("El monto abonado es insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal vuelto = montoAbonado - totalFactura;
                MessageBox.Show($"El vuelto es: {vuelto:C2}", "Vuelto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    foreach (DataGridViewRow row in dgvFactura.Rows)
                    {

                        int idProducto = Convert.ToInt32(row.Cells["Id"].Value);
                        int cantidadComprada = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        AccesoDatos datos = new AccesoDatos();
                        datos.SetearConsulta("UPDATE PRODUCTO SET Cantidad = Cantidad - @cantidad WHERE Id =@Id");
                        datos.SetearParametro("@cantidad", cantidadComprada);
                        datos.SetearParametro("@Id", idProducto);
                        datos.EjecutarAccion();
                        datos.CerrarConexion();
                    }
                    DialogResult ventaRealizada = MessageBox.Show("Venta realizada exitosamente", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ventaRealizada == DialogResult.OK)
                    {
                        System.Threading.Thread.Sleep(1000);
                        CapturarFormulario();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Vender productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }
        private void CapturarFormulario()
        {
            // Obtener el tamaño del formulario
            Size tamanoFormulario = this.Size;

            // Crear un bitmap para almacenar la captura
            Bitmap captura = new Bitmap(tamanoFormulario.Width, tamanoFormulario.Height);

            // Crear un objeto Graphics para copiar la imagen del formulario en el bitmap
            using (Graphics graficos = Graphics.FromImage(captura))
            {
                // Capturar la imagen del formulario
                graficos.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, tamanoFormulario);
            }

            string nombreArchivo = $"factura_{clienteSeleccionado.CuilCuit}.png";

            // Guardar la captura en un archivo
            GuardarCaptura(captura, nombreArchivo);
        }
        private void GuardarCaptura(Bitmap captura, string nombreArchivo)
        {
            // Guardar la imagen en un formato específico (puedes cambiar el formato si lo deseas)
            captura.Save(nombreArchivo, ImageFormat.Png);
        }

    }
}

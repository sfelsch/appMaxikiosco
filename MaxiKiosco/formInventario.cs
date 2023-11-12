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
    public partial class formInventario : Form
    {
        private List<Producto> listaProductos;
        private decimal total = 0;
        public formInventario()
        {
            InitializeComponent();
            dgvInventario.CellFormatting += dgvInventario_CellFormatting;
            cargarLista();
            CalcularTotal();
        }
        private void cargarLista()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();
            listaProductos = productoNegocio.listarProducto();
            dgvInventario.DataSource = listaProductos;
            ocultarColumnas();

        }
        private void ocultarColumnas()
        {
            dgvInventario.Columns["Id"].Visible = false;
            dgvInventario.Columns["Activo"].Visible = false;
           dgvInventario.Columns["IdProvedor"].Visible = false;
        }

        private void MarcarFilasBajoStock()
        {
            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                // Obtener los valores de las columnas "Cantidad" y "StockMinimo"
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                int stockMinimo = Convert.ToInt32(row.Cells["StockMinimo"].Value);

                // Comparar y marcar la fila si Cantidad es menor a StockMinimo
                if (cantidad < stockMinimo)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void CalcularTotal()
        {
            total = 0;

            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (!row.IsNewRow)
                {
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioProveedor = Convert.ToDecimal(row.Cells["PrecioProveedor"].Value);

                    decimal subtotal = cantidad * precioProveedor;
                    total += subtotal;
                }
            }

            lblTotal.Text = $"Total: {total:C2}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Asegurarse de que sea una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener los valores de "Cantidad" y "StockMinimo" para la fila actual
                int cantidad = Convert.ToInt32(dgvInventario["Cantidad", e.RowIndex].Value);
                int stockMinimo = Convert.ToInt32(dgvInventario["StockMinimo", e.RowIndex].Value);

                // Comparar y cambiar el formato de toda la fila si Cantidad es menor a StockMinimo
                if (cantidad < stockMinimo)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras pantalla = new frmCompras();
            pantalla.Show();
            this.Close();
        }
    }
}

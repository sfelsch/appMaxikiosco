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
    public partial class formFacturacion : Form
    {
        private List<Producto> listaProductos;

        public Cliente ClienteSele { get; private set; }

        public formFacturacion(Cliente clienteSel)
        {
            ClienteSele = clienteSel;
            InitializeComponent();
            cargarLista();
            crearTitulosTabla();
            dgvCarrito2.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

        }

      

        private void cargarLista()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();
            listaProductos = productoNegocio.listarProducto();
            dgvProductos.DataSource = listaProductos;
            ocultarColumnas();

        }
        private void ocultarColumnas()
        {
            //dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["StockMinimo"].Visible = false;
            dgvProductos.Columns["Cantidad"].Visible = false;
            dgvProductos.Columns["PrecioProveedor"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["IdProvedor"].Visible = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();
        }
        private void crearTitulosTabla()
        {
            dgvCarrito2.Columns.Add("Id", "Id");
            dgvCarrito2.Columns["Id"].Visible = false;
            dgvCarrito2.Columns.Add("Categoria", "Categoria");
            dgvCarrito2.Columns.Add("Marca", "Marca");
            dgvCarrito2.Columns.Add("Precio", "Precio");
            dgvCarrito2.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito2.Columns.Add("SubTotal", "SubTotal");
            dgvCarrito2.Columns["SubTotal"].Visible = false;
            dgvCarrito2.Columns.Add("PrecioConIva", "I.V.A");
            dgvCarrito2.Columns.Add("PrecioFactura", "factura");
            // Agrega una columna de botones para eliminar filas
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Eliminar";
            deleteButtonColumn.HeaderText = "Eliminar";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvCarrito2.Columns.Add(deleteButtonColumn);
        }
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columna1 = dgvProductos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string columna2 = dgvProductos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                string columna3 = dgvProductos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                string columna4 = dgvProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString();

                dgvCarrito2.Rows.Add(columna1, columna2, columna3, columna4);

            }
        }

      

        private void dgvCarrito2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Verificamos que estemos en la columna "CantidadCompra"
            if (e.ColumnIndex == 3)
            {
                // Verificamos que el valor ingresado sea un número
                if (!int.TryParse(e.FormattedValue.ToString(), out int cantidad))
                {
                    // Si no es un número, cancelamos la edición solo para la celda "CantidadCompra"
                    dgvCarrito2.Rows[e.RowIndex].ErrorText = "Solo se permiten números en la columna 'CantidadCompra'";
                    e.Cancel = true;
                }
                else
                {
                    // Si es un número, limpiamos cualquier mensaje de error previo
                    dgvCarrito2.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private int ObtenerStockDisponible(string nombreProducto)
        {
            int stockDisponible = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                string nombre = row.Cells["Marca"].Value.ToString(); // Ajusta el nombre de la columna
                int stock = Convert.ToInt32(row.Cells["Cantidad"].Value); // Ajusta el nombre de la columna

                if (nombre == nombreProducto)
                {
                    stockDisponible = stock;
                    break; // Termina el ciclo al encontrar el producto
                }
            }

            return stockDisponible;
        }

        private void dgvCarrito2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvCarrito2.Columns[e.ColumnIndex].Name == "Cantidad")
                {
                    int nuevaCantidad = Convert.ToInt32(dgvCarrito2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    string nombreProducto = dgvCarrito2.Rows[e.RowIndex].Cells["Marca"].Value.ToString(); // Ajusta el nombre de la columna

                    int stockDisponible = ObtenerStockDisponible(nombreProducto);

                    if (nuevaCantidad > stockDisponible)
                    {
                        MessageBox.Show("No hay suficiente stock para vender esa cantidad.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            ////////////////
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCarrito2.Columns["Cantidad"].Index)
            {
                DataGridViewRow row = dgvCarrito2.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidad) &&
                    decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out decimal precio))
                {
                    decimal subtotal = cantidad * precio;
                   

                    decimal totalConIva = subtotal * 0.21m;
                    decimal precioFactura = subtotal + totalConIva;
                  row.Cells["SubTotal"].Value = subtotal;
                    row.Cells["PrecioConIva"].Value = totalConIva;
                    row.Cells["PrecioFactura"].Value = precioFactura;
                }
            }
        }

        private void dgvCarrito2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCarrito2.Columns["Eliminar"].Index)
            {
                // Obtén la fila que se ha hecho clic
                DataGridViewRow selectedRow = dgvCarrito2.Rows[e.RowIndex];

                // Elimina la fila del dgvCarrito
                dgvCarrito2.Rows.Remove(selectedRow);
            }
        }


        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (ClienteSele.CondicionIva=="monotributo" || ClienteSele.CondicionIva=="consFinal")
            {
                formFacturaB pantallaFactura = new formFacturaB(ClienteSele, dgvCarrito2.Rows);
                pantallaFactura.Show();
                this.Close();
            } else if (ClienteSele.CondicionIva == "respInscripto")
            {
                formFacturaA pantallaFactura = new formFacturaA(ClienteSele, dgvCarrito2.Rows);
                pantallaFactura.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("no fue seleccionado el cliente");
            }
            
            
        }
    }
}

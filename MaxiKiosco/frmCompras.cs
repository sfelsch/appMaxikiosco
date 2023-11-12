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
    public partial class frmCompras : Form
    {

        ProductoNegocio productoNe = null;

        private Provedor provedor;

        public frmCompras()
        {
            productoNe = new ProductoNegocio();
            InitializeComponent();
            
            cargarcmb();
            cargarGrilla(provedor.Id);
            crearTitulosTabla();


            // Agregamos el evento CellValidating para validar la entrada en la columna "CantidadCompra"
            dgvListaCompra.CellValidating += dgvListaCompra_CellValidating;
            // Agregamos el evento CellBeginEdit para deshabilitar la edición en las demás columnas
            dgvListaCompra.CellBeginEdit += dgvListaCompra_CellBeginEdit;

        }

        private void crearTitulosTabla()
        {
            dgvListaCompra.Columns.Add("Id", "Id");
            dgvListaCompra.Columns.Add("NombreProducto", "Categoria");
            dgvListaCompra.Columns.Add("PrecioProducto", "Precio");
            dgvListaCompra.Columns.Add("Porcentaje", "Porcentaje");
            dgvListaCompra.Columns.Add("PrecioFinal", "Precio Publico");
            dgvListaCompra.Columns.Add("Cantidad", "Cantidad");
            dgvListaCompra.Columns.Add("PrecioTotal", "Precio Total");
        }


        public void cargarcmb()
        {
            ProvedorNegocio provedorNegocio = new ProvedorNegocio();
            cmbCargarProvedor.DataSource = provedorNegocio.listaProvedor();
            cmbCargarProvedor.DisplayMember = "Nombre";
            cmbCargarProvedor.ValueMember = "Id";
        }

        public void cargarGrilla(int id)
        {

            dgvProductosProveedor.DataSource = productoNe.listaProductosProveedor(id);
            ocultarColumnas();
        }

        public void ocultarColumnas()
        {
            //dgvProductosProveedor.Columns["Id"].Visible = false;
            dgvProductosProveedor.Columns["StockMinimo"].Visible = false;
            dgvProductosProveedor.Columns["Activo"].Visible = false;
            dgvProductosProveedor.Columns["IdProvedor"].Visible = false;
            dgvProductosProveedor.Columns["Nombre_Proveedor"].Visible = false;
            dgvProductosProveedor.Columns["Precio"].Visible = false;
        }

        private void cmbCargarProvedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCargarProvedor.SelectedValue != null)
            {

                provedor = (Provedor)cmbCargarProvedor.SelectedItem;

                dgvProductosProveedor.DataSource = null;

                cargarGrilla(provedor.Id);

            }

        }

        private void dgvProductosProveedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columna1 = dgvProductosProveedor.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string columna2 = dgvProductosProveedor.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                string columna3 = dgvProductosProveedor.Rows[e.RowIndex].Cells["PrecioProveedor"].Value.ToString();
               

                dgvListaCompra.Rows.Add(columna1, columna2, columna3);

                if (dgvListaCompra.Rows.Count > 0)
                {
                    cmbCargarProvedor.Enabled = true;

                }
            }

        }


        private void dgvListaCompra_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Verificamos que estemos en la columna "CantidadCompra"
            if (e.ColumnIndex == 4)
            {
                // Verificamos que el valor ingresado sea un número
                if (!int.TryParse(e.FormattedValue.ToString(), out int cantidad))
                {
                    // Si no es un número, cancelamos la edición solo para la celda "CantidadCompra"
                    dgvListaCompra.Rows[e.RowIndex].ErrorText = "Solo se permiten números en la columna 'Cantidad'";
                    e.Cancel = true;
                }
                else
                {
                    // Si es un número, limpiamos cualquier mensaje de error previo
                    dgvListaCompra.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
            if (e.ColumnIndex == 3)
            {
                // Verificamos que el valor ingresado sea un número
                if (!int.TryParse(e.FormattedValue.ToString(), out int cantidad))
                {
                    // Si no es un número, cancelamos la edición solo para la celda "CantidadCompra"
                    dgvListaCompra.Rows[e.RowIndex].ErrorText = "Solo se permiten números en la columna 'Cantidad'";
                    e.Cancel = true;
                }
                else
                {
                    // Si es un número, limpiamos cualquier mensaje de error previo
                    dgvListaCompra.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private void dgvListaCompra_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 2 && e.ColumnIndex != 3 && e.ColumnIndex != 5)
            {
                // Cancelamos la edición para las demás columnas
                e.Cancel = true;
            }

        }

        private void dgvListaCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         
            // Verificamos que estemos en la columna "Porcentaje" y que la edición haya finalizado
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 5) && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda de Porcentaje
                if (decimal.TryParse(dgvListaCompra.Rows[e.RowIndex].Cells[3].Value?.ToString(), out decimal porcentaje))
                {
                    // Supongamos que tienes el precioProveedor en otra columna y la cantidad en otra columna
                    if (decimal.TryParse(dgvListaCompra.Rows[e.RowIndex].Cells[2].Value?.ToString(), out decimal precioProveedor) &&
                        int.TryParse(dgvListaCompra.Rows[e.RowIndex].Cells[5].Value?.ToString(), out int cantidad))
                    {
                        // Calcular el precio con el porcentaje aplicado
                        decimal precioConPorcentaje = precioProveedor + (precioProveedor * (porcentaje / 100));
                        dgvListaCompra.Rows[e.RowIndex].Cells[4].Value = precioConPorcentaje;
                        // Calcular el total para la fila multiplicando por la cantidad
                        decimal total = precioConPorcentaje * cantidad;
                        
                        // Actualizar la celda correspondiente con el nuevo total
                        dgvListaCompra.Rows[e.RowIndex].Cells[6].Value = total;
                       
                    }
                }
            }
        }

        private void btnAltaCompra_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvListaCompra.Rows)
                {
                   
                    int idProducto = Convert.ToInt32(row.Cells["Id"].Value);
                    decimal precioProveedor = Convert.ToDecimal(row.Cells["PrecioProducto"].Value);
                    int cantidadComprada = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioConPorcentaje=Convert.ToDecimal(row.Cells["PrecioFinal"].Value);
                    string gananciaProducto = row.Cells["Porcentaje"].Value.ToString();
                   
                    AccesoDatos datos = new AccesoDatos();
                    datos.SetearConsulta("UPDATE PRODUCTO SET Cantidad = Cantidad + @cantidad,PrecioProveedor=@precioProveedor ,Precio=@Precio, GananciaProducto = @gananciaProducto WHERE Id =@Id");
                    datos.SetearParametro("@cantidad", cantidadComprada);
                    datos.SetearParametro("@precioProveedor", precioProveedor);
                    datos.SetearParametro("@Precio", precioConPorcentaje);
                    datos.SetearParametro("@Id", idProducto);
                    datos.SetearParametro("@gananciaProducto", gananciaProducto);
                    datos.EjecutarAccion();
                    datos.CerrarConexion();
                    dgvListaCompra.Rows.Clear();

                }

                MessageBox.Show("Productos comprados exitosamente.", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarGrilla(provedor.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al comprar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();
        }
    }
}

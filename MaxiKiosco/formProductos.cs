using CapaDominio;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MaxiKiosco
{
    public partial class formProductos : Form
    {
        private List<Producto> listaProductos;

        public formProductos()
        {
            InitializeComponent();
            cargarLista();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto seleccionado;
                seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;

                try
                {
                    ProductoNegocio productoNegocio = new ProductoNegocio();
                    productoNegocio.eliminadoLogicoProducto(seleccionado.Id);
                    MessageBox.Show("Producto " + seleccionado.Categoria + " dado de baja", "Baja de producto", MessageBoxButtons.OK);
                    cargarLista();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void cargarLista()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();
            listaProductos = productoNegocio.listarProducto();
            dgvProductos.DataSource = listaProductos;
            dataGridView1.DataSource = listaProductos;
            ocultarColumnas();

        }
        private void ocultarColumnas()
        {
            dgvProductos.Columns["Id"].Visible = false;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto seleccionado;
                seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;


                frmAltaProducto modificarProducto = new frmAltaProducto(seleccionado);
                modificarProducto.Show();
                this.Close();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto altaProducto = new frmAltaProducto();
            altaProducto.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();
        }

        private void txtFiltroProducto_TextChanged(object sender, EventArgs e)
        {
            string filtroProducto = txtFiltroProducto.Text;
            List<Producto> listaProductosFiltrada = new List<Producto>();

            if (dgvProductos.DataSource != null)
            {
                listaProductosFiltrada = listaProductos.FindAll(x => x.Categoria.ToUpper().Contains(filtroProducto.ToUpper()));
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductosFiltrada;
                ocultarColumnas();
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

        private void formProductos_Load(object sender, EventArgs e)
        {
            txtFiltroProducto.AutoCompleteCustomSource = Helper.CargarDatosProductos();
            txtFiltroProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFiltroProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int stockMinimo = Convert.ToInt32(dataGridView1.Rows[i].Cells["StockMinimo"].Value);
                try
                {
                    if(e.Value.GetType() != typeof(System.DBNull))
                    {
                        if(this.dataGridView1.Columns[e.ColumnIndex].Name == "Cantidad")
                        {
                            if(Convert.ToInt32(e.Value) <= stockMinimo)
                            {
                                e.CellStyle.ForeColor = Color.Red;
                                e.CellStyle.BackColor = Color.Orange;
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }
    }
}

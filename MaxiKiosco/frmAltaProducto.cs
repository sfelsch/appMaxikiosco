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
    public partial class frmAltaProducto : Form
    {


        private Producto producto = null;
        public frmAltaProducto()
        {
            InitializeComponent();
            lblTitulo.Text = "Nuevo Producto";
        }

        public frmAltaProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            lblTitulo.Text = "Modificar Producto";
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formProductos ventana = new formProductos();
            ventana.Show();
            this.Close();
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            ProvedorNegocio provedorNegocio = new ProvedorNegocio();
            try
            {
                cmbProvedor.DataSource = provedorNegocio.listaProvedor();
                cmbProvedor.DisplayMember = "Nombre";
                cmbProvedor.ValueMember = "Id";
                if(producto != null)
                {
                    txtCantidad.Text = producto.Cantidad.ToString();
                    txtCategoria.Text = producto.Categoria;
                    txtMarca.Text = producto.Marca;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtStockMinimo.Text = producto.StockMinimo.ToString();
                    txtPrecioProveedor.Text = producto.PrecioProveedor.ToString();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();

            try
            {
                if (producto == null)
                    producto = new Producto();

                producto.Categoria = txtCategoria.Text;
                producto.Marca = txtMarca.Text;
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.StockMinimo = int.Parse(txtStockMinimo.Text);
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.PrecioProveedor = decimal.Parse(txtPrecioProveedor.Text);
                producto.Activo = true;
                producto.IdProvedor = (int)cmbProvedor.SelectedValue;

                TextBox[] arrayTxt = new TextBox[] { txtCantidad, txtCategoria, txtMarca, txtPrecio, txtPrecioProveedor, txtStockMinimo };

                bool camposIncompletos = false;

                foreach (var item in arrayTxt)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        camposIncompletos = true;
                    }
                }

                if (camposIncompletos == false)
                {
                    if (producto.Id != 0)
                    {
                        productoNegocio.modificarProducto(producto);
                        DialogResult resultado = MessageBox.Show("Modificaste el producto exitosamente!!!", "Modificacion Producto", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            formProductos ventana = new formProductos();
                            ventana.Show();
                            this.Close();
                        }

                    }
                    else
                    {
                        productoNegocio.agregarProducto(producto);
                        DialogResult resultado = MessageBox.Show("Agregaste el producto exitosamente!!", "Nuevo Producto", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            formProductos ventana = new formProductos();
                            ventana.Show();
                            this.Close();
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Debe Completar todos los campos para dar el alta o modificacion a un Producto");
                }

               
                
            }
            catch (Exception)
            {

                MessageBox.Show("Debe Completar todos los campos para dar el alta o modificacion a un Producto");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloLetras(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumeros(e);
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloNumeros(e);
        }

        private void txtPrecioProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.UnaComa(e, txtPrecioProveedor.Text);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.UnaComa(e, txtPrecio.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }
    }
}

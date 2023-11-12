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
    public partial class formProveedor : Form
    {
        private List<Provedor> listaProvedor;
        public formProveedor()
        {
            InitializeComponent();
            cargarLista();
        }

        private void btnModificarProvedor_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Provedor seleccionado;
                seleccionado = (Provedor)dgvClientes.CurrentRow.DataBoundItem;


                frmAltaProvedor modificarProvedor = new frmAltaProvedor(seleccionado);
                modificarProvedor.Show();
                this.Close();
                
            }
        }
        private void cargarLista()
        {
            ProvedorNegocio provedorNegocio = new ProvedorNegocio();
            listaProvedor = provedorNegocio.listaProvedor();
            dgvClientes.DataSource = listaProvedor;
            OcultarColumnasProvedor();
        }

        private void OcultarColumnasProvedor()
        {
            dgvClientes.Columns["id"].Visible = false;
        }

        private void txtFiltroProvedor_TextChanged(object sender, EventArgs e)
        {
            string filtroProvedor = txtFiltroProvedor.Text;
            List<Provedor> listaProvedorFiltrada = new List<Provedor>();

            if (dgvClientes.DataSource != null)
            {
                listaProvedorFiltrada = listaProvedor.FindAll(x => x.Nombre.ToUpper().Contains(filtroProvedor.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaProvedorFiltrada;
                OcultarColumnasProvedor();
            }
        }

        private void btnAgregarProvedor_Click(object sender, EventArgs e)
        {
            frmAltaProvedor altaProvedor = new frmAltaProvedor();
            altaProvedor.Show();
            this.Close();
            
        }

        private void btnElimiarProvedor_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Provedor seleccionado;
                seleccionado = (Provedor)dgvClientes.CurrentRow.DataBoundItem;

                try
                {
                    ProvedorNegocio provedorNegocio = new ProvedorNegocio();
                    provedorNegocio.eliminadoLogicoProvedor(seleccionado.Id);
                    MessageBox.Show("Producto " + seleccionado.Nombre + " dado de baja", "Baja de producto", MessageBoxButtons.OK);
                    cargarLista();
                }
                catch (Exception)
                {

                    throw;
                }



            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();
        }

        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void formProveedor_Load(object sender, EventArgs e)
        {
            txtFiltroProvedor.AutoCompleteCustomSource = Helper.CargarDatosProveedor();
            txtFiltroProvedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFiltroProvedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }
    }
}

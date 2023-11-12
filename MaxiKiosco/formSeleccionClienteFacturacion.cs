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
    public partial class formSeleccionClienteFacturacion : Form
    {
        private List<Cliente> listaClientes;
        public Cliente ClienteSel { get; private set; }
        public string CondicionIVA { get; private set; }
        public formSeleccionClienteFacturacion()
        {
            InitializeComponent();
            cargarLista();
        }
        private void cargarLista()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            listaClientes = negocio.listaCliente();
            dgvClientes.DataSource = listaClientes;
            ocultarColumnas();
            renombrarTitulosDgv();

        }
        private void ocultarColumnas()
        {
            dgvClientes.Columns["Id"].Visible = false;
            dgvClientes.Columns["activo"].Visible = false;
            dgvClientes.Columns["fechaNacimiento"].Visible = false;
            dgvClientes.Columns["mail"].Visible = false;
            dgvClientes.Columns["telefono"].Visible = false;

        }
        private void renombrarTitulosDgv()
        {
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["apellido"].HeaderText = "Apellido";
            dgvClientes.Columns["dni"].HeaderText = "DNI";
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["cuilCuit"].HeaderText = "Cuil/Cuit";
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["condicioniva"].HeaderText = "Condicion Iva";
            dgvClientes.Columns["fechaNacimiento"].HeaderText = "Fecha Nacimiento";
            dgvClientes.Columns["direccion"].HeaderText = "Direccion";
            dgvClientes.Columns["localidad"].HeaderText = "Localidad";
            dgvClientes.Columns["mail"].HeaderText = "Mail";
            dgvClientes.Columns["telefono"].HeaderText = "Telefono";

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            string filtroCliente = txtFiltroCliente.Text;
            List<Cliente> listaClienteFiltrada = new List<Cliente>();

            if (dgvClientes.DataSource != null)
            {
                listaClienteFiltrada = listaClientes.FindAll(x => x.Apellido.ToUpper().Contains(filtroCliente.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaClienteFiltrada;
                ocultarColumnas();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];
                ClienteSel = new Cliente
                {
                    Nombre = selectedRow.Cells[1].Value.ToString(),
                Apellido = selectedRow.Cells[2].Value.ToString(),
                    CuilCuit = selectedRow.Cells[4].Value.ToString(),
                    CondicionIva = selectedRow.Cells[5].Value.ToString(),
                    Telefono = selectedRow.Cells[10].Value.ToString(),
                    Direccion = selectedRow.Cells[7].Value.ToString(),
                    Localidad = selectedRow.Cells[8].Value.ToString()
                };
                CondicionIVA = selectedRow.Cells["condicioniva"].Value.ToString();
               // MessageBox.Show($"Cliente: {ClienteSel.Nombre}{ClienteSel.Apellido}{ClienteSel.CuilCuit}{ClienteSel.CondicionIva}{ClienteSel.Telefono}{ClienteSel.Direccion}{ClienteSel.Localidad}\nCondición IVA: {CondicionIVA}", "Cliente Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                formFacturacion pantalla = new formFacturacion(ClienteSel);
                pantalla.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void formSeleccionClienteFacturacion_Load(object sender, EventArgs e)
        {
            txtFiltroCliente.AutoCompleteCustomSource = Helper.CargarDatosClientes();
            txtFiltroCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFiltroCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}

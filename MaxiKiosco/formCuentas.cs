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
    public partial class formCuentas : Form
    {
        CuentaNegocio cuenta = null;
        public formCuentas()
        {
            cuenta = new CuentaNegocio();
            InitializeComponent();
            cargarGrilla();

        }
        private void crearTitulosTabla()
        {
            dgvCuentas.Columns.Add("IdCuenta", "IdCuenta");
            dgvCuentas.Columns.Add("NomCuenta", "NomCuenta");
        }
        public void cargarGrilla()
        {
            dgvCuentas.DataSource = cuenta.listarCuenta();

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCompras pantalla = new frmCompras();
            pantalla.Show();
            this.Close();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            AltaCuentas pantalla = new AltaCuentas();
            pantalla.Show();
            this.Close();
        }
    }
}

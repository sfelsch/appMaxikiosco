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
    public partial class AltaCuentas : Form
    {
        public AltaCuentas()
        {
            InitializeComponent();
            cargarcmbPlanCuenta();
            cargarcmbRubros();
        }
        public void cargarcmbPlanCuenta()
        {
            CuentaNegocio cuentaNegocio = new CuentaNegocio();
            cmbPlanCuenta.DataSource = cuentaNegocio.listaPlanCuentas();
            cmbPlanCuenta.DisplayMember = "TipoCuenta";
            cmbPlanCuenta.ValueMember = "IdPlanCuenta";
        }
        public void cargarcmbRubros()
        {
            CuentaNegocio cuentaNegocio = new CuentaNegocio();
            cmbRubro.DataSource = cuentaNegocio.listaRubros();
            cmbRubro.DisplayMember = "Rubro";
            cmbRubro.ValueMember = "IdRubro";
        }
        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CuentaNegocio cuentaNegocio = new CuentaNegocio();

            try
            {
                Cuenta cuenta = new Cuenta();

                cuenta.IdPlanCuenta = (int)cmbPlanCuenta.SelectedValue;
                cuenta.IdRubro = (int)cmbRubro.SelectedValue;
                cuenta.IdCuenta = txtNumero.Text;
                cuenta.NomCuenta = txtNombre.Text;
                cuentaNegocio.agregarCuenta(cuenta);
                DialogResult resultado = MessageBox.Show("Agregaste la cuenta exitosamente!!", "Nuevo Cuenta", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MessageBox.Show("Debe Completar todos los campos para dar el alta una Cuenta");
            }
        }
    }
}

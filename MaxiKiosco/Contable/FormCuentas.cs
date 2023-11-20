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

namespace MaxiKiosco.Contable
{
    public partial class FormCuentas : Form
    {
        CDB db = new CDB();
        static public string cuenta = "";
        public FormCuentas()
        {
            InitializeComponent();
        }
        public void filtrargrilla()
        {
            db.IniciarConexion();
            db.FiltrarGrilla("SELECT Cuenta.IdCuenta as [Nº CUENTA], PlanCuentas.TipoCuenta AS [TIPO CUENTA], Rubros.Rubro AS [RUBRO], Cuenta.NomCuenta [DETALLE CUENTA] FROM  Cuenta INNER JOIN PlanCuentas ON Cuenta.IdPlanCuenta = PlanCuentas.IdPlanCuenta INNER JOIN Rubros ON Cuenta.IdRubro = Rubros.IdRubro where PlanCuentas.TipoCuenta='" + cmb_TipoCuentaBuscar.Text + "'", dgv_Cuentas);
            dgv_Cuentas.Columns[0].FillWeight = 40;
            dgv_Cuentas.Columns[1].FillWeight = 60;
            dgv_Cuentas.Columns[2].FillWeight = 55;
            dgv_Cuentas.Columns[3].FillWeight = 150;
            db.CerrarConexion();
        }
        private void cmb_TipoCuentaBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrargrilla();
        }

        private void cmb_CuentaAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.IniciarConexion();
            db.CargarCB("Rubro", "SELECT Rubro FROM  PlanCuentas INNER JOIN PlanCuentaRubros ON PlanCuentas.IdPlanCuenta = PlanCuentaRubros.IdPlanCuenta INNER JOIN  Rubros ON PlanCuentaRubros.IdRubro = Rubros.IdRubro where PlanCuentas.TipoCuenta='" + cmb_CuentaAgregar.Text + "'", cmb_RubroAgregar);
            cmb_RubroAgregar.Items.Add("Sin rubro");
            db.CerrarConexion();
        }

        private void FormCuentas_Load(object sender, EventArgs e)
        {
            db.IniciarConexion();
            db.CargarCB("TipoCuenta", "Select TipoCuenta from PlanCuentas", cmb_CuentaAgregar);
            db.CargarCB("TipoCuenta", "Select TipoCuenta from PlanCuentas", cmb_TipoCuentaBuscar);
            db.CerrarConexion();
        }

        private void btn_AgregarCuenta_Click(object sender, EventArgs e)
        {
            if ((cmb_CuentaAgregar.Text == "") || (txt_nuevaCuenta.Text == ""))
            {
                MessageBox.Show("Complete todos los campos por favor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                db.IniciarConexion();
                int idRubro = 0;
                int cantidadCuentas = 0;
                int idTipoCuenta = int.Parse(db.LeerDato("IdPlanCuenta", "select IdPlanCuenta from PlanCuentas where TipoCuenta='" + cmb_CuentaAgregar.Text + "'"));

                if ((cmb_RubroAgregar.Text == "Sin rubro") || (cmb_RubroAgregar.Text == ""))
                {

                    idRubro = 0;
                    cantidadCuentas = int.Parse(db.LeerDato("cantidadcuentas", "select count(IdCuenta) as cantidadcuentas from Cuenta where IdPlanCuenta='" + idTipoCuenta + "' and IdRubro='" + idRubro + "'"));
                    db.NumCuentaString(idTipoCuenta, idRubro, cantidadCuentas);

                    string cuentaString = idTipoCuenta.ToString() + "." + db.NumCuentaString(idTipoCuenta, (cmb_RubroAgregar.SelectedIndex) + 1, cantidadCuentas);
                    db.Ejecutar("INSERT INTO Cuenta values (" + idTipoCuenta + ", " + 0 + ", '" + cuentaString + "', '" + txt_nuevaCuenta.Text.Trim() + "')");
                }

                if (cmb_RubroAgregar.Text != "")
                {
                    idRubro = int.Parse(db.LeerDato("IdRubro", "select IdRubro from Rubros where Rubro='" + cmb_RubroAgregar.Text + "'"));
                    cantidadCuentas = int.Parse(db.LeerDato("cantidadcuentas", "select count(IdCuenta) as cantidadcuentas from Cuenta where IdPlanCuenta='" + idTipoCuenta + "' and IdRubro='" + idRubro + "'"));

                    db.NumCuentaString(idTipoCuenta, (cmb_RubroAgregar.SelectedIndex) + 1, cantidadCuentas);

                    string cuentaString = idTipoCuenta.ToString() + "." + ((cmb_RubroAgregar.SelectedIndex) + 1).ToString() + "." + db.NumCuentaString(idTipoCuenta, (cmb_RubroAgregar.SelectedIndex) + 1, cantidadCuentas);
                    db.Ejecutar("INSERT INTO Cuenta values (" + idTipoCuenta + ", " + idRubro + ", '" + cuentaString + "', '" + txt_nuevaCuenta.Text.Trim() + "')");
                }

                db.CerrarConexion();

                txt_nuevaCuenta.Text = "";
                cmb_CuentaAgregar.Text = "";
                cmb_RubroAgregar.Text = "";

                filtrargrilla();
            }
        }

        private void dgv_Cuentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cuenta = dgv_Cuentas.CurrentRow.Cells[0].Value.ToString();
            txt_CuentaELiminar.Text = dgv_Cuentas.CurrentRow.Cells[3].Value.ToString();
            txt_cuentaSelec.Text = dgv_Cuentas.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro que desea modificar la cuenta:  " + txt_cuentaSelec.Text + "?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txt_CuentaMod.Text == "")
            {
                MessageBox.Show("Complete el campo  por favor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                db.IniciarConexion();
                db.Ejecutar("update Cuenta set NomCuenta='" + txt_CuentaMod.Text.Trim() + "' where IdCuenta='" + cuenta + "'");

                db.CerrarConexion();
                filtrargrilla();
            }
            txt_CuentaMod.Text = "";
            txt_cuentaSelec.Text = "";
            txt_CuentaELiminar.Text = "";
        }

        private void btn_ELiminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar la cuenta:  " + txt_cuentaSelec.Text + "?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            db.IniciarConexion();
            db.Ejecutar("DELETE from Cuenta where IdCuenta='" + cuenta + "'");

            db.CerrarConexion();
            filtrargrilla();
            txt_CuentaMod.Text = "";
            txt_cuentaSelec.Text = "";
            txt_CuentaELiminar.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormContable pantalla = new FormContable();
            pantalla.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

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
    public partial class FormLibroMayor : Form
    {
        CDB db = new CDB();
        public double total_Debe = 0, total_Haber = 0, saldoparcial = 0, total_deudor = 0, total_acreedor = 0;

        

        public FormLibroMayor()
        {
            InitializeComponent();
            db.IniciarConexion();
            db.CargarCB("TipoCuenta", "Select TipoCuenta from PlanCuentas", cbx_TipoCuentaMayor);

            if (txt_CuentaDMayor != null)
            {
                txt_CuentaDMayor.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_CuentaDMayor.AutoCompleteSource = AutoCompleteSource.CustomSource;
                db.AutoComplete(txt_CuentaDMayor, "SELECT NomCuenta FROM Cuenta;", "NomCuenta");
            }
            db.CerrarConexion();
        }

        private void checkBox_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_fecha.Checked == true)
            {
                gbx_fechas.Enabled = true;
            }
            else
                gbx_fechas.Enabled = false;
        }

        private void checkBox_cuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cuenta.Checked == true)
            {
                gbx_cuenta.Enabled = true;
            }
            else

                gbx_cuenta.Enabled = false;
        }

        private void cbx_TipoCuentaMayor_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.IniciarConexion();
            //db.CargarCB("Rubro", "SELECT Rubro FROM PlanCuentas INNER JOIN Rubros ON PlanCuentas.IdPlanCuenta = Rubros.IdPlanCuenta where PlanCuentas.TipoCuenta='" + cbx_TipoCuenta.Text + "'", cmb_rubro);

            db.CargarCB("NomCuenta", "SELECT NomCuenta FROM  Cuenta INNER JOIN PlanCuentas ON Cuenta.IdPlanCuenta = PlanCuentas.IdPlanCuenta where PlanCuentas.TipoCuenta='" + cbx_TipoCuentaMayor.Text + "'", cbx_cuentaMayor);

            db.CerrarConexion();
        }

        private void cbx_cuentaMayor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CuentaDMayor.Text = cbx_cuentaMayor.Text;
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
            FormContable pantalla = new FormContable();
            pantalla.Show();
            this.Close();
        }
        private void btn_buscarMayor_Click(object sender, EventArgs e)
        {
            dgv_Saldos.Rows.Clear();
            db.IniciarConexion();

            txt_CodCuentaMayor.Text = db.LeerDato("IdCuenta", "SELECT IdCuenta FROM Cuenta where NomCuenta='" + txt_CuentaDMayor.Text + "'");
            //db.FiltrarGrilla("SELECT fecha AS FECHA, id_asiento as ASIENTO, codigoCuenta as CUENTA, CuentaDetalle as DETALLE, Debe, Haber FROM LibroDiario  WHERE fecha>= CONVERT(date,'" + dttimep_inicialMayor.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalMayor.Text.Trim() + "')", dgv_libroMayor);
            if ((checkBox_cuenta.Checked == false) && (checkBox_fecha.Checked == false))
            {
                MessageBox.Show("Elija una opcion de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if ((checkBox_cuenta.Checked == true) && (checkBox_fecha.Checked == false))
            {
                gbx_cuenta.Enabled = true;
                gbx_fechas.Enabled = false;
                db.FiltrarGrilla("SELECT fecha AS FECHA, id_asiento as ASIENTO, Debe as DEBE, Haber as HABER FROM  LibroDiario  WHERE codigoCuenta='" + txt_CodCuentaMayor.Text.Trim() + "' order by CONVERT(date, fecha)", dgv_libroMayor);

            }
            if ((checkBox_cuenta.Checked == false) && (checkBox_fecha.Checked == true))
            {
                gbx_cuenta.Enabled = false;
                gbx_fechas.Enabled = true;
                db.FiltrarGrilla("SELECT fecha AS FECHA, id_asiento as ASIENTO, Debe as DEBE, Haber as HABER FROM  LibroDiario  WHERE fecha>= CONVERT(date,'" + dttimep_inicialMayor.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalMayor.Text.Trim() + "') order by CONVERT(date, fecha)", dgv_libroMayor);

            }
            if ((checkBox_cuenta.Checked == true) && (checkBox_fecha.Checked == true))
            {
                gbx_cuenta.Enabled = true;
                gbx_fechas.Enabled = true;
                db.FiltrarGrilla("SELECT fecha AS FECHA, id_asiento as ASIENTO, Debe as DEBE, Haber as HABER FROM  LibroDiario  WHERE codigoCuenta='" + txt_CodCuentaMayor.Text.Trim() + "' and  fecha>= CONVERT(date,'" + dttimep_inicialMayor.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalMayor.Text.Trim() + "') order by CONVERT(date, fecha)", dgv_libroMayor);

            }


            //AGREGO EN LA GRILLA SALDOS LA CANTIDAD DE FILAS DE LA OTRA GRILLA
            int filas = dgv_libroMayor.Rows.Count;
            if (filas > 0)
            {
                dgv_Saldos.Rows.Add(filas);
            }

            saldoparcial = 0;
            //RECORRO GRILLA, RESTO DEBE Y HABER (ACUMULANDO) SI ES POSITIVO VA A SALDO DEUDOR Y SI ES NEGATIVO (le saco el signo -) A ACREEDOR

            for (int i = 0; i < dgv_libroMayor.Rows.Count; i++)
            {
                if (cbx_TipoCuentaMayor.SelectedIndex + 1 == 1 || cbx_TipoCuentaMayor.SelectedIndex + 1 == 5)
                {
                    saldoparcial += Convert.ToDouble(dgv_libroMayor[2, i].Value) - Convert.ToDouble(dgv_libroMayor[3, i].Value);
                    if (saldoparcial < 0)
                    {
                        //le saco el signo menos
                        dgv_Saldos[1, i].Value = db.borroElnegativo(saldoparcial.ToString());
                    }
                    else
                        dgv_Saldos[0, i].Value = saldoparcial;

                }
                if (cbx_TipoCuentaMayor.SelectedIndex + 1 == 2 || cbx_TipoCuentaMayor.SelectedIndex + 1 == 3 || cbx_TipoCuentaMayor.SelectedIndex + 1 == 4)
                {
                    saldoparcial += Convert.ToDouble(dgv_libroMayor[3, i].Value) - Convert.ToDouble(dgv_libroMayor[2, i].Value);
                    if (saldoparcial < 0)
                    {
                        //le saco el signo menos
                        dgv_Saldos[0, i].Value = db.borroElnegativo(saldoparcial.ToString());
                    }
                    else

                        dgv_Saldos[1, i].Value = saldoparcial;
                }

            }
          
            txt_Sdeudor.Text = saldoparcial.ToString();
           

            total_Debe = 0;
            total_Haber = 0;

            total_deudor = 0;
            total_acreedor = 0;
            foreach (DataGridViewRow x in dgv_libroMayor.Rows)
            {
                total_Debe += Convert.ToDouble(x.Cells[2].Value);
                total_Haber += Convert.ToDouble(x.Cells[3].Value);

            }
            txt_subtotoalDebe.Text = total_Debe.ToString();
            txt_subtHaber.Text = total_Haber.ToString();

            db.CerrarConexion();

         //   dgv_libroMayor.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
         //   dgv_libroMayor.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
         //   dgv_Saldos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
         //   dgv_Saldos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}

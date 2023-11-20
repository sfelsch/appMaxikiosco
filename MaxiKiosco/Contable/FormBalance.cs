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
    public partial class FormBalance : Form
    {
        CDB db = new CDB();

        public static double Totalingresos = 0, TotalEgresos = 0;
        public FormBalance()
        {
            InitializeComponent();
        }
        private void dgv_Activo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesEstaticas.idRubro = int.Parse(dgv_Activo.CurrentRow.Cells[0].Value.ToString());
            VariablesEstaticas.rubro = dgv_Activo.CurrentRow.Cells[1].Value.ToString();
            VariablesEstaticas.idTipoCuenta = 1;
            VariablesEstaticas.fechaDesde = dttimep_inicialBalance.Text.Trim();
            VariablesEstaticas.fechaHasta = dttimep_finalBalance.Text.Trim();
            FormDetalleCuenta FODETCUENTA = new FormDetalleCuenta();
            FODETCUENTA.Show();
        }

        private void dgv_Pasivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesEstaticas.idRubro = int.Parse(dgv_Pasivo.CurrentRow.Cells[0].Value.ToString());
            VariablesEstaticas.rubro = dgv_Pasivo.CurrentRow.Cells[1].Value.ToString();
            VariablesEstaticas.idTipoCuenta = 2;
            VariablesEstaticas.fechaDesde = dttimep_inicialBalance.Text.Trim();
            VariablesEstaticas.fechaHasta = dttimep_finalBalance.Text.Trim();
            FormDetalleCuenta FODETCUENTA = new FormDetalleCuenta();
            FODETCUENTA.Show();
        }

        private void txt_EGRESOS_DoubleClick(object sender, EventArgs e)
        {
            VariablesEstaticas.idTipoCuenta = 5;
            VariablesEstaticas.fechaDesde = dttimep_inicialBalance.Text.Trim();
            VariablesEstaticas.fechaHasta = dttimep_finalBalance.Text.Trim();
            FormDetalleCuenta FODETCUENTA = new FormDetalleCuenta();
            FODETCUENTA.Show();
        }

        private void txt_INGRESOS_DoubleClick(object sender, EventArgs e)
        {
            VariablesEstaticas.idTipoCuenta = 4;
            VariablesEstaticas.fechaDesde = dttimep_inicialBalance.Text.Trim();
            VariablesEstaticas.fechaHasta = dttimep_finalBalance.Text.Trim();
            FormDetalleCuenta FODETCUENTA = new FormDetalleCuenta();
            FODETCUENTA.Show();
        }

        private void btn_verCompleto_Click(object sender, EventArgs e)
        {
            txt_resultadoEjercicio.Text = "";
            txt_IngreMenosVentas.Text = "";
            txt_EgreMenosCVM.Text = "";
            VariablesEstaticas.verCompleto = true;
            txt_resultadoEjercicio.Text = "";
            db.IniciarConexion();
            db.FiltrarGrilla("SELECT R.IdRubro, R.Rubro AS RUBRO, (sum(LD.Debe) - sum(LD.Haber)) as TOTAL FROM Rubros R INNER JOIN Cuenta C ON C.IdRubro = R.IdRubro left JOIN LibroDiario LD ON LD.codigoCuenta = C.IdCuenta WHERE C.IdPlanCuenta=1 group  by R.IdRubro, R.Rubro", dgv_Activo);
            dgv_Activo.Columns[0].Visible = false;
            db.FiltrarGrilla("SELECT R.IdRubro, R.Rubro AS RUBRO, sum(LD.Haber) - (sum(LD.Debe)) as TOTAL FROM Rubros R INNER JOIN Cuenta C ON C.IdRubro = R.IdRubro left JOIN LibroDiario LD ON LD.codigoCuenta = C.IdCuenta WHERE C.IdPlanCuenta=2 group  by R.IdRubro, R.Rubro", dgv_Pasivo);
            dgv_Pasivo.Columns[0].Visible = false;
            db.FiltrarGrilla("select IdCuenta, NomCuenta as CUENTAS from Cuenta where IdPlanCuenta=3", dgv_PNeto2);
            dgv_PNeto2.Columns[0].Visible = false;
            //db.FiltrarGrilla("SELECT  Cuenta.IdCuenta, Cuenta.NomCuenta AS CUENTA, (sum(LibroDiario.Haber) - sum(LibroDiario.Debe))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdPlanCuenta=3 GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_Pneto);

            double activo = 0;
            double pasivo = 0;
            for (int i = 0; i < dgv_Activo.Rows.Count; i++)
            {
                //si no obvio el null, no suma
                if (dgv_Activo[2, i].Value != DBNull.Value)
                {
                    activo += Convert.ToDouble(dgv_Activo[2, i].Value);
                }

            }

            for (int i = 0; i < dgv_Pasivo.Rows.Count; i++)
            {
                //si no obvio el null, no suma
                if (dgv_Pasivo[2, i].Value != DBNull.Value)
                {
                    pasivo += Convert.ToDouble(dgv_Pasivo[2, i].Value);
                }

            }

            txt_totalActivo.Text = activo.ToString();
            txt_totalPasivo.Text = pasivo.ToString();
            double PN = activo - pasivo;
            txt_totalPN.Text = PN.ToString();
            txt_PmasPN.Text = activo.ToString();

            dgv_PNtotales.Rows.Add(dgv_PNeto2.Rows.Count);
            //string Haycapital = db.LeerDato("totalCapital", "SELECT sum(Haber) - sum(Debe) as totalCapital from LibroDiario where codigoCuenta='3.001'"); 
            //if (Haycapital != "")
            //{
            double capital = Convert.ToDouble(dgv_PNtotales.Rows[0].Cells[0].Value = db.LeerDato("totalCapital", "SELECT isnull((sum(Haber) - sum(Debe)),0) as totalCapital from LibroDiario where codigoCuenta='3.001'"));
            double Rejercicio = PN - capital;
            dgv_PNtotales.Rows[0].Cells[0].Value = capital.ToString();
            dgv_PNtotales.Rows[1].Cells[0].Value = Rejercicio.ToString();
            //}

            //SACO TOTAL INGRESOS. TOTAL VENTAS. RESTO TOTAL MENOS VENTAS
            Totalingresos = double.Parse(db.LeerDato("TOTALINGRESOS", "SELECT isnull((sum(Haber) - sum(Debe)),0) AS TOTALINGRESOS FROM Cuenta INNER JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta where Cuenta.IdPlanCuenta=4"));
            txt_ventas.Text = db.LeerDato("totalVentas", "select isnull((sum(Haber) - sum(Debe)),0) as totalVentas from LibroDiario where codigoCuenta='4.001'");
            txt_IngreMenosVentas.Text = (Totalingresos - double.Parse(txt_ventas.Text)).ToString();

            //SACO TOAL EGRESOS. TOTAL COSTO DE MERCADERIAS VENDIDAS. Y RESTO
            TotalEgresos = double.Parse(db.LeerDato("TOTALEGRESOS", "SELECT isnull((sum(Debe) - sum(Haber)),0) as TOTALEGRESOS FROM Cuenta INNER JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta where Cuenta.IdPlanCuenta=5"));
            txt_CMV.Text = db.LeerDato("totalCMV", "select isnull((sum(Debe) - sum(Haber)),0) as totalCMV from LibroDiario where codigoCuenta='5.001'");
            txt_EgreMenosCVM.Text = (TotalEgresos - -double.Parse(txt_CMV.Text)).ToString();

            //VENTAS - CVM
            txt_ResBruto.Text = (double.Parse(txt_ventas.Text) - double.Parse(txt_CMV.Text)).ToString();
            //RESULTADO DEL EJERCICIO
            txt_resultadoEjercicio.Text = (double.Parse(txt_ResBruto.Text) + (double.Parse(txt_IngreMenosVentas.Text) - double.Parse(txt_EgreMenosCVM.Text))).ToString();

            db.CerrarConexion();
            dgv_Activo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_PNtotales.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_Pasivo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void btn_buscarBalance_Click(object sender, EventArgs e)
        {
            DateTime desde = dttimep_inicialBalance.Value;
            DateTime hasta = dttimep_finalBalance.Value;
            if (hasta < desde)
            {
                MessageBox.Show("La fecha Hasta no puede ser menor a Desde", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dttimep_inicialBalance.Value = DateTime.Now;
                dttimep_finalBalance.Value = DateTime.Now;
            }
            else
            {
                VariablesEstaticas.verCompleto = false;
                txt_resultadoEjercicio.Text = "";
                txt_IngreMenosVentas.Text = "";
                txt_EgreMenosCVM.Text = "";
                db.IniciarConexion();
                //PROBLEMAS: AL FILTRAR POR FECHAS NO APARECEN LAS CUENTAS QUE NO TENGAN RESULTADOS. ME CAGA EL RESULTADO DEL EJERCICIO
                //RESUELTO: SUPERCONSULTA
                //db.FiltrarGrilla("SELECT R.IdRubro, R.Rubro AS RUBRO, (sum(LD.Debe) - sum(LD.Haber)) as TOTAL FROM Rubros R left JOIN Cuenta C ON C.IdRubro = R.IdRubro left JOIN LibroDiario LD ON LD.codigoCuenta = C.IdCuenta WHERE C.IdPlanCuenta=1 and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "') group  by R.IdRubro, R.Rubro", dgv_Activo);
                db.FiltrarGrilla("SELECT RAux.IdRubro, RAux.Rubro AS RUBRO, isnull(AUX.TOTAL, 0) AS TOTAL FROM(SELECT R.IdRubro, R.Rubro AS RUBRO, isnull((sum(LD.Debe) - sum(LD.Haber)),0) as TOTAL FROM Rubros R  inner JOIN Cuenta C ON C.IdRubro = R.IdRubro  left JOIN LibroDiario LD ON LD.codigoCuenta = C.IdCuenta WHERE C.IdPlanCuenta=1  and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "')  AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')  group  by R.IdRubro, R.Rubro) AS AUX full JOIN Rubros RAux on RAux.IdRubro=AUX.IdRubro inner join PlanCuentaRubros PCR ON PCR.idRubro = RAux.idRubro where IdPlanCuenta=1", dgv_Activo);
                dgv_Activo.Columns[0].Visible = false;
                dgv_Activo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                db.FiltrarGrilla("SELECT RAux.IdRubro, RAux.Rubro AS RUBRO, isnull(AUX.TOTAL, 0) AS TOTAL FROM(SELECT R.IdRubro, R.Rubro AS RUBRO, isnull((sum(LD.Haber) - sum(LD.Debe)),0) as TOTAL FROM Rubros R  inner JOIN Cuenta C ON C.IdRubro = R.IdRubro  left JOIN LibroDiario LD ON LD.codigoCuenta = C.IdCuenta WHERE C.IdPlanCuenta=2  and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "')  AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')  group  by R.IdRubro, R.Rubro) AS AUX full JOIN Rubros RAux on RAux.IdRubro=AUX.IdRubro inner join PlanCuentaRubros PCR ON PCR.idRubro = RAux.idRubro where IdPlanCuenta=2", dgv_Pasivo);

                dgv_Pasivo.Columns[0].Visible = false;
                dgv_Pasivo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                double activo = 0;
                double pasivo = 0;
                for (int i = 0; i < dgv_Activo.Rows.Count; i++)
                {
                    //si no obvio el null, no suma
                    if (dgv_Activo[2, i].Value != DBNull.Value)
                    {
                        activo += Convert.ToDouble(dgv_Activo[2, i].Value);
                    }

                }

                for (int i = 0; i < dgv_Pasivo.Rows.Count; i++)
                {
                    //si no obvio el null, no suma
                    if (dgv_Pasivo[2, i].Value != DBNull.Value)
                    {
                        pasivo += Convert.ToDouble(dgv_Pasivo[2, i].Value);
                    }

                }

                //double activo = Convert.ToDouble(db.LeerDato("TOTALDEBE", "SELECT sum(Debe) - sum(Haber) AS TOTALDEBE FROM Cuenta INNER JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta where Cuenta.IdPlanCuenta=1"));
                txt_totalActivo.Text = activo.ToString();
                txt_totalPasivo.Text = pasivo.ToString();
                double PN = activo - pasivo;

                txt_totalPN.Text = PN.ToString();
                txt_PmasPN.Text = activo.ToString();

                //BUSTO TOTAL INGRESOS Y VENTAS
                Totalingresos = double.Parse(db.LeerDato("TOTALINGRESOS", "SELECT isnull((sum(Haber) - sum(Debe)),0) AS TOTALINGRESOS FROM Cuenta INNER JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta where Cuenta.IdPlanCuenta=4 and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')"));
                txt_ventas.Text = db.LeerDato("totalVentas", "select isnull((sum(Haber) - sum(Debe)),0) as totalVentas from LibroDiario where codigoCuenta='4.001' and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')");
                //TODO INGRESOS MENOS VENTAS
                txt_IngreMenosVentas.Text = (Totalingresos - double.Parse(txt_ventas.Text)).ToString();

                //BUSCO TOTAL EGRESOS Y COSTO DE MERCADERIAS VENDIDAS
                TotalEgresos = double.Parse(db.LeerDato("TOTALEGRESOS", "SELECT isnull((sum(Debe) - sum(Haber)),0) as TOTALEGRESOS FROM Cuenta INNER JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta where Cuenta.IdPlanCuenta=5 and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')"));
                txt_CMV.Text = db.LeerDato("totalCMV", "select isnull((sum(Debe) - sum(Haber)),0) as totalCMV from LibroDiario where codigoCuenta='5.001'and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')");
                //TODO EGRESOS MENOS COSTO DE MERCADERIAS VEDIDAS
                txt_EgreMenosCVM.Text = (TotalEgresos - double.Parse(txt_CMV.Text)).ToString();

                //RESULTADO BRUTO VENTAS MENOS CMV
                txt_ResBruto.Text = (double.Parse(txt_ventas.Text) - double.Parse(txt_CMV.Text)).ToString();

                //RESULTADO DEL EJERCICIO: VENTAS - CMV + INGRESOS(sin ventas) - EGRESOS(sin cmv) que coincide con PN menos CAPITAL 
                txt_resultadoEjercicio.Text = (double.Parse(txt_ResBruto.Text) + (double.Parse(txt_IngreMenosVentas.Text) - double.Parse(txt_EgreMenosCVM.Text))).ToString();



                // HAGO ESTA CHANCHADA HASTA ARREGLAR LA CONSULTA QUE ME TRAIGA TODO
                db.FiltrarGrilla("select IdCuenta, NomCuenta as CUENTAS from Cuenta where IdPlanCuenta=3", dgv_PNeto2);
                dgv_PNeto2.Columns[0].Visible = false;
                dgv_PNtotales.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                dgv_PNtotales.Rows.Add(dgv_PNeto2.Rows.Count);

                double capital = Convert.ToDouble(dgv_PNtotales.Rows[0].Cells[0].Value = db.LeerDato("totalCapital", "SELECT isnull((sum(Haber) - sum(Debe)),0) as totalCapital from LibroDiario where codigoCuenta='" + dgv_PNeto2.Rows[0].Cells[0].Value + "'and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')"));
                double Rejercicio = PN - capital;
                dgv_PNtotales.Rows[0].Cells[0].Value = capital.ToString();


                //CAPITAL
                dgv_PNtotales.Rows[0].Cells[0].Value = db.LeerDato("totalCapital", "SELECT isnull((sum(Haber) - sum(Debe)),0) as totalCapital from LibroDiario where codigoCuenta='" + dgv_PNeto2.Rows[0].Cells[0].Value + "'and  fecha>= CONVERT(date,'" + dttimep_inicialBalance.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalBalance.Text.Trim() + "')");
                dgv_PNtotales.Rows[1].Cells[0].Value = PN - double.Parse(dgv_PNtotales.Rows[0].Cells[0].Value.ToString());

                db.CerrarConexion();
            }
        }
       
    }
}

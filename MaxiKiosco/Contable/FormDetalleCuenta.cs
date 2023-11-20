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
    public partial class FormDetalleCuenta : Form
    {
        CDB db = new CDB();
        VariablesEstaticas var = new VariablesEstaticas();
        public FormDetalleCuenta()
        {
            InitializeComponent();
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

        private void FormDetalleCuenta_Load(object sender, EventArgs e)
        {
            db.IniciarConexion();
            if (VariablesEstaticas.verCompleto == true)
            {
                //db.FiltrarGrilla("SELECT Cuenta.IdCuenta as CUENTA, Cuenta.NomCuenta as DETALLE FROM  Cuenta where Cuenta.IdRubro=" + VariablesEstaticas.idRubro + "", dgv_detalleCuenta);
                if (VariablesEstaticas.idTipoCuenta == 1)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas del rubro " + VariablesEstaticas.rubro + "";
                    db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LibroDiario.Debe) - sum(LibroDiario.Haber))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdRubro=" + VariablesEstaticas.idRubro + " GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);
                }
                if (VariablesEstaticas.idTipoCuenta == 2)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas del rubro " + VariablesEstaticas.rubro + "";
                    db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LibroDiario.Haber) -sum(LibroDiario.Debe))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdRubro=" + VariablesEstaticas.idRubro + " GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);
                }


                //db.FiltrarGrilla("select IdCuenta as CUENTA, NomCuenta as DETALLE from Cuenta where IdCuenta='" + VariablesEstaticas.idTipoCuenta + "'", dgv_detalleCuenta);
                if (VariablesEstaticas.idTipoCuenta == 4)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas de INGRESOS";
                    db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LD.Haber) -sum(LD.Debe)) AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario LD ON Cuenta.IdCuenta = LD.codigoCuenta WHERE Cuenta.IdPlanCuenta=4 GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);

                }
                if (VariablesEstaticas.idTipoCuenta == 5)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas de EGRESOS";
                    db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LibroDiario.Debe) - sum(LibroDiario.Haber))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdPlanCuenta=5 GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);

                }

               // dgv_detalleCuenta.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }

            else
            {
                //db.FiltrarGrilla("SELECT Cuenta.IdCuenta as CUENTA, Cuenta.NomCuenta as DETALLE FROM  Cuenta where Cuenta.IdRubro=" + VariablesEstaticas.idRubro + "", dgv_detalleCuenta);
                if (VariablesEstaticas.idTipoCuenta == 1)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas del rubro " + VariablesEstaticas.rubro + "";
                    //db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LibroDiario.Debe) - sum(LibroDiario.Haber))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdRubro=" + VariablesEstaticas.idRubro + " and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "') GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);
                    db.FiltrarGrilla("SELECT  CAux.IdCuenta AS CUENTA, CAux.NomCuenta AS DETALLE, isnull(AUX.TOTAL, 0) AS TOTAL FROM (SELECT  C.IdCuenta AS CUENTA, C.NomCuenta AS DETALLE, (sum(LD.Debe) - sum(LD.Haber))  AS TOTAL FROM   Cuenta C LEFT JOIN LibroDiario LD ON C.IdCuenta = LD.codigoCuenta WHERE C.IdRubro=" + VariablesEstaticas.idRubro + " and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "') GROUP BY C.IdCuenta, C.NomCuenta) AS AUX full JOIN Cuenta CAux on CAux.IdCuenta=AUX.CUENTA where CAux.IdRubro=" + VariablesEstaticas.idRubro + "", dgv_detalleCuenta);

                }
                if (VariablesEstaticas.idTipoCuenta == 2)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas del rubro " + VariablesEstaticas.rubro + "";
                    //db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LibroDiario.Haber) -sum(LibroDiario.Debe))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdRubro=" + VariablesEstaticas.idRubro + " and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "')GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);
                    db.FiltrarGrilla("SELECT  CAux.IdCuenta AS CUENTA, CAux.NomCuenta AS DETALLE, isnull(AUX.TOTAL, 0) AS TOTAL FROM (SELECT  C.IdCuenta AS CUENTA, C.NomCuenta AS DETALLE, (sum(LD.Haber) - sum(LD.Debe))  AS TOTAL FROM   Cuenta C LEFT JOIN LibroDiario LD ON C.IdCuenta = LD.codigoCuenta WHERE C.IdRubro=" + VariablesEstaticas.idRubro + " and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "') GROUP BY C.IdCuenta, C.NomCuenta) AS AUX full JOIN Cuenta CAux on CAux.IdCuenta=AUX.CUENTA where CAux.IdRubro=" + VariablesEstaticas.idRubro + "", dgv_detalleCuenta);

                }


                //db.FiltrarGrilla("select IdCuenta as CUENTA, NomCuenta as DETALLE from Cuenta where IdCuenta='" + VariablesEstaticas.idTipoCuenta + "'", dgv_detalleCuenta);
                if (VariablesEstaticas.idTipoCuenta == 4)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas de INGRESOS";
                    //db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LibroDiario.Haber) -sum(LibroDiario.Debe))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdPlanCuenta=4 and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "') GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);
                    db.FiltrarGrilla("SELECT  CAux.IdCuenta AS CUENTA, CAux.NomCuenta AS DETALLE, isnull(AUX.TOTAL, 0) AS TOTAL FROM ( SELECT  C.IdCuenta AS CUENTA, C.NomCuenta AS DETALLE, (sum(LD.Haber) -sum(LD.Debe))  AS TOTAL FROM  Cuenta C LEFT JOIN LibroDiario LD ON C.IdCuenta = LD.codigoCuenta WHERE C.IdPlanCuenta=4  and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "') GROUP BY C.IdCuenta, C.NomCuenta) AS AUX full JOIN Cuenta CAux on CAux.IdCuenta=AUX.CUENTA where CAux.IdPlanCuenta=4", dgv_detalleCuenta);
                }
                if (VariablesEstaticas.idTipoCuenta == 5)
                {
                    lbl_DetalleCuenta.Text = "Detalle cuentas de EGRESOS";
                    //db.FiltrarGrilla("SELECT  Cuenta.IdCuenta AS CUENTA, Cuenta.NomCuenta AS DETALLE, (sum(LibroDiario.Debe) - sum(LibroDiario.Haber))  AS TOTAL FROM   Cuenta LEFT JOIN LibroDiario ON Cuenta.IdCuenta = LibroDiario.codigoCuenta WHERE Cuenta.IdPlanCuenta=5 and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "') GROUP BY Cuenta.IdCuenta, Cuenta.NomCuenta", dgv_detalleCuenta);
                    db.FiltrarGrilla("SELECT  CAux.IdCuenta AS CUENTA, CAux.NomCuenta AS DETALLE, isnull(AUX.TOTAL, 0) AS TOTAL FROM ( SELECT  C.IdCuenta AS CUENTA, C.NomCuenta AS DETALLE, (sum(LD.Debe) -sum(LD.Haber))  AS TOTAL FROM  Cuenta C LEFT JOIN LibroDiario LD ON C.IdCuenta = LD.codigoCuenta WHERE C.IdPlanCuenta=5  and  fecha>= CONVERT(date,'" + VariablesEstaticas.fechaDesde + "') AND fecha <= CONVERT(date,'" + VariablesEstaticas.fechaHasta + "') GROUP BY C.IdCuenta, C.NomCuenta) AS AUX full JOIN Cuenta CAux on CAux.IdCuenta=AUX.CUENTA where CAux.IdPlanCuenta=5", dgv_detalleCuenta);

                }
              //  dgv_detalleCuenta.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            double total = 0;
            for (int i = 0; i < dgv_detalleCuenta.Rows.Count; i++)
            {
                //si no obvio el null, no suma
                if (dgv_detalleCuenta[2, i].Value != DBNull.Value)
                {
                    total += Convert.ToDouble(dgv_detalleCuenta[2, i].Value);
                }

            }
            txt_totalDetalle.Text = total.ToString();


            db.CerrarConexion();
        }
    }
}

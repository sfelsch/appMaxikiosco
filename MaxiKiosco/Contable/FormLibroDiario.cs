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
    public partial class FormLibroDiario : Form
    {
        CDB db = new CDB();
        int columna = -1;
        public int NumAsiento = 0, existe = 0;
        public double total_Debe = 0, total_Haber = 0;
        public FormLibroDiario()
        {
            InitializeComponent();
        }

        private void dateTimePicker_libroDiario_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_libroDiario.Value > DateTime.Today)
            {
                MessageBox.Show("No se puede hacer un asiento en una fecha mayor a la actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_libroDiario.Value = DateTime.Today;
            }
            db.IniciarConexion();
            DateTime UltimaFechaLibroD = Convert.ToDateTime(db.LeerDato("dia", "select max(fecha) as dia from LibroDiario  "));
            db.CerrarConexion();
            if (dateTimePicker_libroDiario.Value < UltimaFechaLibroD)
            {
                MessageBox.Show("No se puede hacer un asiento en una fecha anterior a " + UltimaFechaLibroD.ToShortDateString() + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_libroDiario.Value = DateTime.Today;

            }

            db.IniciarConexion();
            int existe = int.Parse(db.LeerDato("existe", "select count(*) as existe from LibroDiario where fecha ='" + dateTimePicker_libroDiario.Text.Trim() + "'"));

            if (existe > 0)
            {
                NumAsiento = int.Parse(db.LeerDato("ultimoAsiento", "select max(id_asiento) as ultimoAsiento from LibroDiario where fecha='" + dateTimePicker_libroDiario.Text.Trim() + "'"));
                txt_N_asiento.Text = Convert.ToString(NumAsiento);
                NumAsiento = NumAsiento + 1;

            }
            else if (existe == 0)
            {
                NumAsiento = 1;
                txt_N_asiento.Text = existe.ToString();

            }
            db.CerrarConexion();
        }

        private void cbx_TipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.IniciarConexion();
            //db.CargarCB("Rubro", "SELECT Rubro FROM PlanCuentas INNER JOIN Rubros ON PlanCuentas.IdPlanCuenta = Rubros.IdPlanCuenta where PlanCuentas.TipoCuenta='" + cbx_TipoCuenta.Text + "'", cmb_rubro);

            db.CargarCB("NomCuenta", "SELECT NomCuenta FROM  Cuenta INNER JOIN PlanCuentas ON Cuenta.IdPlanCuenta = PlanCuentas.IdPlanCuenta where PlanCuentas.TipoCuenta='" + cbx_TipoCuenta.Text + "' and Cuenta.NomCuenta not in ('Resultado del ejercicio')", cmb_cuenta);
            txt_TipoCuenta.Text = cbx_TipoCuenta.Text;
            db.CerrarConexion();
        }

        private void cmb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.IniciarConexion();
            int id_rubro = int.Parse(db.LeerDato("IdRubro", "SELECT IdRubro FROM Cuenta  where NomCuenta='" + cmb_cuenta.Text + "'"));

            if (id_rubro == 0)
            {
                txt_RubroCuenta.Text = "SIN RUBRO";

            }
            else if (id_rubro != 0)
            {
                txt_RubroCuenta.Text = db.LeerDato("Rubro", "SELECT Rubro FROM Rubros where IdRubro='" + id_rubro + "'");
            }
            txt_CodigoCuenta.Text = db.LeerDato("IdCuenta", "SELECT IdCuenta FROM Cuenta where NomCuenta='" + cmb_cuenta.Text + "'");
            txt_detalleCuenta.Text = cmb_cuenta.Text;
            db.CerrarConexion();
        }

        private void dgv_LibroDiario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
        }

        private void dgv_LibroDiario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            total_Debe = 0;
            total_Haber = 0;

            foreach (DataGridViewRow x in dgv_LibroDiario.Rows)
            {
                total_Debe += Convert.ToDouble(x.Cells[3].Value);
                total_Haber += Convert.ToDouble(x.Cells[4].Value);

            }
            txt_totalDebe.Text = total_Debe.ToString();
            txt_totalHaber.Text = total_Haber.ToString();
        }

        private void btn_cerrarAsiento_Click(object sender, EventArgs e)
        {
            db.IniciarConexion();
            if (dgv_LibroDiario.Rows.Count == 0)
            {
                MessageBox.Show("No hay asientos que agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (total_Debe != total_Haber)
            {
                MessageBox.Show("No se verifica la igualdad entre Debe y Haber. Corrobore los valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    for (int i = 0; i < dgv_LibroDiario.Rows.Count; i++)
                    {
                        db.Ejecutar("INSERT INTO LibroDiario VALUES ('" + dateTimePicker_libroDiario.Text.Trim() + "', " + dgv_LibroDiario[0, i].Value + ",'" + dgv_LibroDiario[1, i].Value.ToString() + "','" + dgv_LibroDiario[2, i].Value.ToString() + "'," + dgv_LibroDiario[3, i].Value + "," + dgv_LibroDiario[4, i].Value + ")");

                    }

                    MessageBox.Show("Asiento ingresado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_LibroDiario.Rows.Clear();
                    txt_totalDebe.Text = "";
                    txt_totalHaber.Text = "";
                    txt_CodigoCuenta.Text = "";
                    cmb_cuenta.Text = "";
                    cbx_TipoCuenta.Text = "";
                    NumAsiento = int.Parse(db.LeerDato("ultimoAsiento", "select max(id_asiento) as ultimoAsiento from LibroDiario where fecha='" + dateTimePicker_libroDiario.Text.Trim() + "'"));
                    txt_N_asiento.Text = Convert.ToString(NumAsiento);
                    NumAsiento = NumAsiento + 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el proceso de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }

            db.CerrarConexion();
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void btn_LibroMayor_Click(object sender, EventArgs e)
        {
            FormLibroMayor pantalla = new FormLibroMayor();
            pantalla.Show();
        }

        private void btn_agregarAsiento_Click(object sender, EventArgs e)
        {
            double totalcuenta = 0;
            //si pide numero asiento, agregar en una campo el id a partir del numero diario podria ser. N diario 1.1, 1.2 etc
            if ((cmb_Transaccion.Text != "") && (txt_detalleCuenta.Text != "") && (txt_monto.Text != ""))
            {
                db.IniciarConexion();
                string cuenta = db.LeerDato("IdCuenta", "SELECT IdCuenta FROM Cuenta where NomCuenta='" + txt_detalleCuenta.Text.Trim() + "'");
                int idPlanCuenta = int.Parse(db.LeerDato("IdPlanCuenta", "select IdPlanCuenta from Cuenta where IdCuenta='" + cuenta + "'"));
                existe = int.Parse(db.LeerDato("existe", "select count(*) as existe from LibroDiario where codigoCuenta='" + cuenta + "'"));
                //si el saldo total de la cuenta es menor al monto ingresado y la cuenta pertenece a Activo o Egresos no permite
                if ((cmb_Transaccion.Text == "HABER") && (idPlanCuenta == 1 || idPlanCuenta == 5))
                {
                    if (existe > 0)
                    {
                        totalcuenta = int.Parse(db.LeerDato("totalcuenta", "select [dbo].[totalcuentaDebe] ('" + cuenta + "') as totalcuenta"));
                        if ((int.Parse(txt_monto.Text.Trim()) < totalcuenta))
                        {
                            dgv_LibroDiario.Rows.Add();
                            int fila = dgv_LibroDiario.Rows.Count - 1;
                            dgv_LibroDiario.Rows[fila].Cells[0].Value = NumAsiento;

                            dgv_LibroDiario.Rows[fila].Cells[1].Value = cuenta;
                            txt_CodigoCuenta.Text = cuenta;

                            txt_RubroCuenta.Text = db.LeerDato("Rubro", "SELECT Rubro FROM Cuenta INNER JOIN Rubros ON Cuenta.IdRubro = Rubros.IdRubro where NomCuenta='" + txt_detalleCuenta.Text + "'");
                            txt_TipoCuenta.Text = db.LeerDato("TipoCuenta", "SELECT TipoCuenta FROM Cuenta INNER JOIN PlanCuentas ON Cuenta.IdPlanCuenta = PlanCuentas.IdPlanCuenta where NomCuenta='" + txt_detalleCuenta.Text + "'");

                            dgv_LibroDiario.Rows[fila].Cells[2].Value = "     " + txt_detalleCuenta.Text.Trim();

                            dgv_LibroDiario.Rows[fila].Cells[3].Value = 0;
                            dgv_LibroDiario.Rows[fila].Cells[4].Value = txt_monto.Text;
                        }
                        else
                        {
                            MessageBox.Show("Saldo DEUDOR insuficiente en la cuenta " + cuenta + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("La cuenta " + cuenta + " no tiene movimientos deudor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else if ((cmb_Transaccion.Text == "DEBE") && (idPlanCuenta == 2 || idPlanCuenta == 3 || idPlanCuenta == 4))
                {
                    //VEO SI EXISTE, si existe, hace
                    existe = int.Parse(db.LeerDato("existe", "select count(*) as existe from LibroDiario where codigoCuenta='" + cuenta + "'"));
                    if (existe > 0)
                    {

                        totalcuenta = double.Parse(db.LeerDato("totalcuenta", "select [dbo].[totalcuentaHaber] ('" + cuenta + "') as totalcuenta"));
                        //SI TIENE SALDO SUFICIENTE
                        if ((double.Parse(txt_monto.Text.Trim()) < totalcuenta))
                        {
                            dgv_LibroDiario.Rows.Add();
                            int fila = dgv_LibroDiario.Rows.Count - 1;
                            dgv_LibroDiario.Rows[fila].Cells[0].Value = NumAsiento;

                            dgv_LibroDiario.Rows[fila].Cells[1].Value = cuenta;
                            txt_CodigoCuenta.Text = cuenta;

                            txt_RubroCuenta.Text = db.LeerDato("Rubro", "SELECT Rubro FROM Cuenta INNER JOIN Rubros ON Cuenta.IdRubro = Rubros.IdRubro where NomCuenta='" + txt_detalleCuenta.Text + "'");
                            txt_TipoCuenta.Text = db.LeerDato("TipoCuenta", "SELECT TipoCuenta FROM Cuenta INNER JOIN PlanCuentas ON Cuenta.IdPlanCuenta = PlanCuentas.IdPlanCuenta where NomCuenta='" + txt_detalleCuenta.Text + "'");

                            dgv_LibroDiario.Rows[fila].Cells[2].Value = txt_detalleCuenta.Text;

                            dgv_LibroDiario.Rows[fila].Cells[3].Value = txt_monto.Text;
                            dgv_LibroDiario.Rows[fila].Cells[4].Value = 0;
                        }

                        else
                        {
                            MessageBox.Show("Saldo ACREEDOR insuficiente en la cuenta " + txt_detalleCuenta.Text + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                    else
                    {
                        MessageBox.Show("La cuenta " + txt_detalleCuenta.Text + "  no tiene movimiento acreedor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    dgv_LibroDiario.Rows.Add();
                    int fila = dgv_LibroDiario.Rows.Count - 1;
                    dgv_LibroDiario.Rows[fila].Cells[0].Value = NumAsiento;

                    dgv_LibroDiario.Rows[fila].Cells[1].Value = cuenta;
                    txt_CodigoCuenta.Text = cuenta;

                    txt_RubroCuenta.Text = db.LeerDato("Rubro", "SELECT Rubro FROM Cuenta INNER JOIN Rubros ON Cuenta.IdRubro = Rubros.IdRubro where NomCuenta='" + txt_detalleCuenta.Text + "'");
                    txt_TipoCuenta.Text = db.LeerDato("TipoCuenta", "SELECT TipoCuenta FROM Cuenta INNER JOIN PlanCuentas ON Cuenta.IdPlanCuenta = PlanCuentas.IdPlanCuenta where NomCuenta='" + txt_detalleCuenta.Text + "'");



                    if (cmb_Transaccion.Text == "DEBE")
                    {
                        dgv_LibroDiario.Rows[fila].Cells[2].Value = txt_detalleCuenta.Text;
                        dgv_LibroDiario.Rows[fila].Cells[3].Value = txt_monto.Text;
                        dgv_LibroDiario.Rows[fila].Cells[4].Value = 0;
                    }
                    else
                    {
                        dgv_LibroDiario.Rows[fila].Cells[2].Value = "     " + txt_detalleCuenta.Text.Trim();
                        dgv_LibroDiario.Rows[fila].Cells[3].Value = 0;
                        dgv_LibroDiario.Rows[fila].Cells[4].Value = txt_monto.Text;
                    }
                }
                db.CerrarConexion();
                dgv_LibroDiario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_LibroDiario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            else if ((cmb_Transaccion.Text == "") || (txt_detalleCuenta.Text == "") || (txt_monto.Text == ""))
            {
                MessageBox.Show("Complete todos los campos por favor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            total_Debe = 0;
            total_Haber = 0;

            foreach (DataGridViewRow x in dgv_LibroDiario.Rows)
            {
                total_Debe += Convert.ToDouble(x.Cells[3].Value);
                total_Haber += Convert.ToDouble(x.Cells[4].Value);

            }
            txt_totalDebe.Text = total_Debe.ToString();
            txt_totalHaber.Text = total_Haber.ToString();

            txt_monto.Text = "";
            txt_detalleCuenta.Text = "";
            txt_RubroCuenta.Text = "";
            txt_TipoCuenta.Text = "";
            cmb_Transaccion.Text = "";
        }

       
        private void FormLibroDiario_Load(object sender, EventArgs e)
        {
            cmb_Transaccion.Items.Add("DEBE");
            cmb_Transaccion.Items.Add("HABER");

            db.IniciarConexion();
            db.CargarCB("TipoCuenta", "select TipoCuenta from PlanCuentas", cbx_TipoCuenta);
            int existe = int.Parse(db.LeerDato("existe", "select count(*) as existe from LibroDiario where fecha ='" + dateTimePicker_libroDiario.Text.Trim() + "'"));

            if (existe > 0)
            {
                NumAsiento = int.Parse(db.LeerDato("ultimoAsiento", "select max(id_asiento) as ultimoAsiento from LibroDiario where fecha='" + dateTimePicker_libroDiario.Text.Trim() + "'"));
                txt_N_asiento.Text = Convert.ToString(NumAsiento);
                NumAsiento = NumAsiento + 1;

            }
            else if (existe == 0)
            {
                NumAsiento = 1;
                txt_N_asiento.Text = existe.ToString();

            }
            if (txt_detalleCuenta != null)
            {
                txt_detalleCuenta.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_detalleCuenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
                db.AutoComplete(txt_detalleCuenta, "SELECT NomCuenta FROM Cuenta;", "NomCuenta");
            }
            db.CerrarConexion();
        }

       
    }
}

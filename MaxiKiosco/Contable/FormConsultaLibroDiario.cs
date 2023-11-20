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
    public partial class FormConsultaLibroDiario : Form
    {
        CDB db = new CDB();
        public FormConsultaLibroDiario()
        {
            InitializeComponent();
        }

        private void btn_verCompletoLdiario_Click(object sender, EventArgs e)
        {
            db.IniciarConexion();
            db.FiltrarGrilla("Select * from LibroDiario order by CONVERT(date, fecha)", dgv_LibroDIario);
            db.CerrarConexion();
            dgv_LibroDIario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_LibroDIario.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btn_buscarLibroDiario_Click(object sender, EventArgs e)
        {
            DateTime desde = dttimep_inicialLibroDiario.Value;
            DateTime hasta = dttimep_finalLibroDiario.Value;
            if (hasta < desde)
            {
                MessageBox.Show("La fecha Hasta no puede ser menor a Desde", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dttimep_inicialLibroDiario.Value = DateTime.Now;
                dttimep_finalLibroDiario.Value = DateTime.Now;
            }
            else
            {
                db.IniciarConexion();
                db.FiltrarGrilla("Select * from LibroDiario where fecha>= CONVERT(date,'" + dttimep_inicialLibroDiario.Text.Trim() + "') AND fecha <= CONVERT(date,'" + dttimep_finalLibroDiario.Text.Trim() + "') order by CONVERT(date, fecha)", dgv_LibroDIario);
                db.CerrarConexion();
                dgv_LibroDIario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_LibroDIario.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
    }
}

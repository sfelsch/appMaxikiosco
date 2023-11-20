using MaxiKiosco.Contable;
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
    public partial class FormContable : Form
    {
        public FormContable()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FormCuentas pantalla = new FormCuentas();
            pantalla.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLibroDiario pantalla = new FormLibroDiario();
            pantalla.Show();
            this.Close();
        }

        private void btn_ConsultaLibroDiario_Click(object sender, EventArgs e)
        {
            FormConsultaLibroDiario pantalla = new FormConsultaLibroDiario();
            pantalla.Show();
            this.Close();
        }

        private void btn_detalleCuentas_Click(object sender, EventArgs e)
        {
            FormDetalleCuenta pantalla = new FormDetalleCuenta();
            pantalla.Show();
            this.Close();
        }

        private void btn_libroMayor_Click(object sender, EventArgs e)
        {
            FormLibroMayor pantalla = new FormLibroMayor();
            pantalla.Show();
            this.Close();
        }

        private void btn_Balance_Click(object sender, EventArgs e)
        {
            FormBalance pantalla = new FormBalance();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal pantalla = new frmPrincipal();
            pantalla.Show();
            this.Close();
        }
    }
}

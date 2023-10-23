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
            formCuentas pantalla = new formCuentas();
            pantalla.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formLibroDiario formLibroDiario = new formLibroDiario();
            formLibroDiario.Show();
            this.Close();
        }
    }
}

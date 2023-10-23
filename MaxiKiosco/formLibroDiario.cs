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
    public partial class formLibroDiario : Form
    {

        private List<Cuenta> cuentas;
        private decimal totalDebe = 0;
        private decimal totalHaber = 0;
        private int numeroAsientoActual = 1;
        public formLibroDiario()
        {
            InitializeComponent();

            dgvLibroDiario.AutoGenerateColumns = false;
            

            dgvLibroDiario.CellDoubleClick += dgvLibroDiario_CellDoubleClick;

            dgvLibroDiario.Columns["CodCuenta"].ReadOnly = true;

            dgvLibroDiario.Columns["TipoCuentaColumn"].ReadOnly = true;

            CuentaNegocio cuentaNegocio = new CuentaNegocio();
            cuentas = cuentaNegocio.listarCuenta();
        }


        private void dgvLibroDiario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvLibroDiario.CurrentCell.ColumnIndex == dgvLibroDiario.Columns["Detalle"].Index)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    // Configura el autocompletado
                    textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    // Crea y llena la colección de autocompletado
                    AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                    foreach (var cuenta in cuentas)
                    {
                        autoCompleteCollection.Add(cuenta.NomCuenta); // Añade los detalles de las cuentas a la colección
                    }
                    textBox.AutoCompleteCustomSource = autoCompleteCollection;
                }
            }
        }

        private void dgvLibroDiario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLibroDiario.Columns["Detalle"].Index)
            {
                string detalle = dgvLibroDiario.Rows[e.RowIndex].Cells["Detalle"].Value.ToString();
                var cuenta = cuentas.FirstOrDefault(c => c.NomCuenta == detalle);
                dgvLibroDiario.AllowUserToAddRows = false;
                if (cuenta != null)
                {
                    dgvLibroDiario.Rows[e.RowIndex].Cells["CodCuenta"].Value = cuenta.IdCuenta;

                    // Obtén el primer carácter del código de cuenta
                    if (!string.IsNullOrEmpty(cuenta.IdCuenta))
                    {
                        char primerCaracter = cuenta.IdCuenta[0];
                        string tipoCuenta = string.Empty;

                        // Configura el tipo de cuenta según el primer carácter
                        switch (primerCaracter)
                        {
                            case '1':
                                tipoCuenta = "Activos";
                                break;
                            case '2':
                                tipoCuenta = "Pasivos";
                                break;
                            case '3':
                                tipoCuenta = "Patrimonio";
                                break;
                            case '4':
                                tipoCuenta = "Ingresos";
                                break;
                            case '5':
                                tipoCuenta = "Egresos";
                                break;
                            default:
                                tipoCuenta = "Desconocido";
                                break;
                        }

                        // Establece el valor en la columna "Tipo de Cuenta"
                        dgvLibroDiario.Rows[e.RowIndex].Cells["TipoCuentaColumn"].Value = tipoCuenta;
                    }
                }
                else
                {
                    MessageBox.Show("Cuenta no encontrada");
                }
            }

        }

        private void btnAsiento_Click(object sender, EventArgs e)
        {
            HashSet<string> cuentasAgregadas = new HashSet<string>(); // Usaremos un HashSet para rastrear las cuentas

            foreach (DataGridViewRow row in dgvLibroDiario.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal debe = Convert.ToDecimal(row.Cells["Debe"].Value);
                    decimal haber = Convert.ToDecimal(row.Cells["Haber"].Value);
                    string codCuenta = row.Cells["CodCuenta"].Value.ToString(); // Supongamos que la columna se llama "CodCuenta"

                    // Verifica si la cuenta ya se ha agregado
                    if (cuentasAgregadas.Contains(codCuenta))
                    {
                        MessageBox.Show($"La cuenta {codCuenta} ya ha sido agregada al asiento.", "Error de asiento contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // No se registra el asiento
                    }
                    cuentasAgregadas.Add(codCuenta); // Agrega la cuenta al HashSet
                    // Obtiene la categoría a partir del primer dígito del número de cuenta
                    string categoria = codCuenta[0].ToString();

                    // Valida según la categoría de la cuenta
                    switch (categoria)
                    {
                        case "1": // Activos
                            if (debe <= 0 || haber != 0)
                            {
                                MessageBox.Show("La cuenta de Activos debe tener un saldo deudor (Debe mayor que cero y Haber igual a cero).", "Error de asiento contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // No se registra el asiento
                            }
                            break;

                        case "2": // Pasivos
                            if (debe != 0 || haber <= 0)
                            {
                                MessageBox.Show("La cuenta de Pasivos debe tener un saldo acreedor (Haber mayor que cero y Debe igual a cero).", "Error de asiento contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // No se registra el asiento
                            }
                            break;

                        case "3": // Patrimonio
                                  // Puedes agregar aquí la lógica específica para cuentas de patrimonio si es necesario
                            break;

                        case "4": // Ingresos
                            if (debe <= 0 || haber != 0)
                            {
                                MessageBox.Show("La cuenta de Ingresos debe tener un saldo acreedor (Haber mayor que cero y Debe igual a cero).", "Error de asiento contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // No se registra el asiento
                            }
                            break;

                        case "5": // Egresos
                            if (debe != 0 || haber <= 0)
                            {
                                MessageBox.Show("La cuenta de Egresos debe tener un saldo deudor (Debe mayor que cero y Haber igual a cero).", "Error de asiento contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // No se registra el asiento
                            }
                            break;
                    }

                    totalDebe += debe;
                    totalHaber += haber;
                }
            }

            // Valida que la suma de débito sea igual a la suma de crédito
            if (totalDebe == totalHaber)
            {

                // Crear una fila para el DataGridView de resumen
                DataGridViewRow nuevaFila = new DataGridViewRow();

                // Crear una celda para el número de asiento y asignarle el valor
                DataGridViewTextBoxCell cellNumAsiento = new DataGridViewTextBoxCell();
                cellNumAsiento.Value = numeroAsientoActual;

                // Obtén la fecha y hora actual
                DateTime fechaActual = DateTime.Now;

                // Convierte la fecha en un formato legible para mostrarla en la celda
                string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm:ss");

                // Crear una celda para la fecha y asignarle el valor
                DataGridViewTextBoxCell cellFecha = new DataGridViewTextBoxCell();
                cellFecha.Value = fechaFormateada;

                // Calcula el total del asiento
                decimal totalAsiento = totalDebe + totalHaber;

                // Crear una celda para el total del asiento y asignarle el valor
                DataGridViewTextBoxCell cellTotalAsiento = new DataGridViewTextBoxCell();
                cellTotalAsiento.Value = totalAsiento;

                // Agregar las celdas a la misma fila
                nuevaFila.Cells.Add(cellNumAsiento);
                nuevaFila.Cells.Add(cellFecha);
                nuevaFila.Cells.Add(cellTotalAsiento);

                // Agregar la fila al DataGridView de resumen
                dgvResumenAsientos.Rows.Add(nuevaFila);

                // Incrementar el número de asiento actual para el próximo asiento
                numeroAsientoActual++;

                //////////////////////////////////////////////////7
                MessageBox.Show("El asiento contable se registró correctamente.", "Asiento Contable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            else
            {
                MessageBox.Show("La suma de débito debe ser igual a la suma de crédito.", "Error de asiento contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            dgvLibroDiario.AllowUserToAddRows = true;
        }

        private void dgvLibroDiario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLibroDiario.Rows.Count)
            {
                // Asegúrate de que el índice sea válido
                dgvLibroDiario.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CapaNegocio
{
    class CDB
    {
        public SqlConnection ConexionDB = new SqlConnection("server=DESKTOP-JTDKPUQ; database=Contable_db; integrated security=true;");
        public SqlCommand Orden;
        public SqlDataReader Lector;

        public void IniciarConexion()
        {
            try
            {
                if (ConexionDB.State == ConnectionState.Closed)
                    ConexionDB.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void CerrarConexion()
        {
            try
            {
                if (ConexionDB.State == ConnectionState.Open)
                    ConexionDB.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //metodo para cargar la coleccion de datos para el autocomplete
        public AutoCompleteStringCollection Autocomplete(string Consulta, string campo, ComboBox cmbBuscar)
        {
            DataTable dt = new DataTable();
            Orden = new SqlCommand(Consulta, ConexionDB);
            SqlDataAdapter adap = new SqlDataAdapter(Orden);
            adap.Fill(dt);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo]));
            }
            cmbBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbBuscar.AutoCompleteCustomSource = coleccion;
            return coleccion;
        }

        public void CargarCB(string campo, string Consulta, ComboBox cb)
        {
            cb.Items.Clear();
            Orden = new SqlCommand(Consulta, ConexionDB);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                cb.Items.Add(Lector[campo].ToString());
            }
            Lector.Close();
        }

        public string LeerDato(string campo, string Consulta)
        {

            string dato;
            Orden = new SqlCommand(Consulta, ConexionDB);
            Lector = Orden.ExecuteReader();
            Lector.Read();
            try
            {
                dato = Lector[campo].ToString();
                Lector.Close();
                return (dato);
            }
            catch (Exception e)
            {
                Lector.Close();
                return (e.Message);
            }
        }
        //Carga del data grid view
        public void CargaDGV(DataGridView dgv, string Consulta, string tabla, string origen)
        {
            switch (origen)
            {
                case "CargarTel":
                    {
                        Orden = new SqlCommand(Consulta, ConexionDB);
                        Lector = Orden.ExecuteReader();
                        dgv.Columns.Add("TipoTel", "Tipo");
                        dgv.Columns[0].Width = 70;
                        dgv.Columns.Add("NumTel", "Número");
                        dgv.Columns[1].Width = 130;
                        dgv.Columns[1].ReadOnly = false;
                        dgv.Columns[0].ReadOnly = true;

                        while (Lector.Read())
                        {
                            dgv.Rows.Add();
                            dgv[0, dgv.Rows.Count - 1].Value = Lector["Descripcion"];
                            dgv[1, dgv.Rows.Count - 1].Value = Lector["numero"];
                        }
                        break;
                    }
                default:
                    {
                        SqlDataAdapter dstabla = new SqlDataAdapter(Consulta, ConexionDB);
                        DataSet dtabla = new DataSet();
                        dstabla.Fill(dtabla, tabla);
                        dgv.DataSource = dtabla;
                        dgv.DataMember = tabla;
                        break;
                    }
            }

        }

        public void Ejecutar(string Consulta)
        {
            try
            {
                Orden = new SqlCommand(Consulta, ConexionDB);
                Orden.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void FiltrarGrilla(string ConsultaBusqueda, DataGridView dgv)
        {
            try
            {
                Orden = ConexionDB.CreateCommand();
                Orden.CommandType = CommandType.Text;
                Orden.CommandText = ConsultaBusqueda;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Orden);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearFormTxtOCombo(GroupBox Groupbox)
        {
            foreach (Control ComboOTxt in Groupbox.Controls)
            {
                if ((ComboOTxt is TextBox) || (ComboOTxt is ComboBox))
                {
                    ComboOTxt.Text = "";
                }
            }
        }
        public void ClearFormDGV(DataGridView DGV)
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                DGV.Rows.Remove(DGV.Rows[i]);
            }
        }


        public void AutoComplete(TextBox cajaTexto, string consulta, string campo)
        {
            Orden = new SqlCommand(consulta, ConexionDB);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                cajaTexto.AutoCompleteCustomSource.Add(Lector[campo].ToString());
            }
            Lector.Close();
            ConexionDB.Close();
            cajaTexto.Text = "";
        }
        public string NumCuentaString(int idTipoCuenta, int idRubro, int cantidadDeCuentas)
        {
            cantidadDeCuentas = cantidadDeCuentas + 1;
            string numeroDecuenta = "";
            if (cantidadDeCuentas < 10)
            {
                numeroDecuenta = "00" + cantidadDeCuentas.ToString();
                return (numeroDecuenta);
            }
            else
            {
                numeroDecuenta = "0" + cantidadDeCuentas.ToString();
                return (numeroDecuenta);
            }

        }

        public string borroElnegativo(string saldo)
        {
            // Convert.ToString(saldo);
            int posicionChar = 0;
            posicionChar = Convert.ToInt16(saldo.IndexOf("-"));
            saldo = saldo.Remove(0, posicionChar + 1);
            saldo.Trim();
            return (saldo);
        }
    }
}

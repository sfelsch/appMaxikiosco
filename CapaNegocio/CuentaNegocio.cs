using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaNegocio
{
    public class CuentaNegocio
    {
        public List<Cuenta> listarCuenta()
        {
            List<Cuenta> lista = new List<Cuenta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select IdCuenta, NomCuenta from Cuenta");

                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Cuenta auxiliar = new Cuenta();
                    auxiliar.IdCuenta = (string)datos.Lector["IdCuenta"];
                    auxiliar.NomCuenta = (string)datos.Lector["NomCuenta"];

                    lista.Add(auxiliar);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public List<PlanCuentas> listaPlanCuentas()
        {
            List<PlanCuentas> lista = new List<PlanCuentas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select * from PlanCuentas");
                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    PlanCuentas auxiliar = new PlanCuentas();
                    auxiliar.IdPlanCuenta = (int)datos.Lector["IdPlanCuenta"];
                    auxiliar.TipoCuenta = (string)datos.Lector["TipoCuenta"];
                    lista.Add(auxiliar);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public List<Rubros> listaRubros()
        {
            List<Rubros> lista = new List<Rubros>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select * from Rubros");
                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Rubros auxiliar = new Rubros();
                    auxiliar.IdRubro = (int)datos.Lector["IdRubro"];
                    auxiliar.Rubro = (string)datos.Lector["Rubro"];
                    lista.Add(auxiliar);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void agregarCuenta(Cuenta nuevo)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("insert into Cuenta (IdPlanCuenta, IdRubro, IdCuenta, NomCuenta) values (@IdPlanCuenta, @IdRubro, @IdCuenta, @NomCuenta)");
                datos.SetearParametro("@IdPlanCuenta", nuevo.IdPlanCuenta);
                datos.SetearParametro("@IdRubro", nuevo.IdRubro);
                datos.SetearParametro("@IdCuenta", nuevo.IdCuenta);
                datos.SetearParametro("@NomCuenta", nuevo.NomCuenta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}

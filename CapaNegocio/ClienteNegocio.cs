using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaNegocio;

namespace CapaNegocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listaCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select id, nombre, apellido , dni, " +
                                     "cuilCuit, condicionIva , fechaNacimiento, direccion, localidad, mail, telefono, activo " +
                                     "from CLIENTE where activo = 1");

                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Cliente auxiliar = new Cliente();
                    auxiliar.Id = (int)datos.Lector["id"];
                    auxiliar.Nombre = (string)datos.Lector["nombre"];
                    auxiliar.Apellido = (string)datos.Lector["apellido"];
                    auxiliar.Dni = (string)datos.Lector["dni"];
                    auxiliar.CuilCuit = (string)datos.Lector["cuilCuit"];
                    auxiliar.CondicionIva = (string)datos.Lector["condicionIva"];
                    auxiliar.FechaNacimiento = (string)datos.Lector["fechaNacimiento"];
                    auxiliar.Direccion = (string)datos.Lector["direccion"];
                    auxiliar.Localidad = (string)datos.Lector["localidad"];
                    auxiliar.Mail = (string)datos.Lector["mail"];
                    auxiliar.Telefono = (string)datos.Lector["telefono"];
                    auxiliar.Activo = (bool)datos.Lector["activo"];

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
        public void agregarCliente(Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into CLIENTE values(@nombre, @apellido, @dni, @cuilCuit, @condicionIva, @fechaNacimiento, @direccion, @localidad, @mail, @telefono ,@activo)");
               
                datos.SetearParametro("@nombre", nuevo.Nombre);
                datos.SetearParametro("@apellido", nuevo.Apellido);
                datos.SetearParametro("@dni", nuevo.Dni);
                datos.SetearParametro("@cuilCuit", nuevo.CuilCuit);
                datos.SetearParametro("@condicionIva", nuevo.CondicionIva);
                datos.SetearParametro("@fechaNacimiento", nuevo.FechaNacimiento);
                datos.SetearParametro("@direccion", nuevo.Direccion);
                datos.SetearParametro("@localidad", nuevo.Localidad);
                datos.SetearParametro("@mail", nuevo.Mail);
                datos.SetearParametro("@telefono", nuevo.Telefono);
                datos.SetearParametro("@activo", nuevo.Activo);

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
        public void modificarCliente(Cliente clienteSeleccionado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("update CLIENTE set nombre = @Nombre, apellido = @Apellido, dni = @Dni, cuilCuit = @CuilCuit, condicionIva = @CondicionIva, fechaNacimiento = @FechaNacimiento, direccion = @Direccion, localidad = @Localidad, mail = @Mail, telefono = @Telefono, activo = 1 WHERE id = @Id");

                datos.SetearParametro("@Nombre", clienteSeleccionado.Nombre);
                datos.SetearParametro("@Apellido", clienteSeleccionado.Apellido);
                datos.SetearParametro("@Dni" , clienteSeleccionado.Dni);
                datos.SetearParametro("@CuilCuit", clienteSeleccionado.CuilCuit);
                datos.SetearParametro("@CondicionIva", clienteSeleccionado.CondicionIva);
                datos.SetearParametro("@FechaNacimiento", clienteSeleccionado.FechaNacimiento);
                datos.SetearParametro("@Direccion", clienteSeleccionado.Direccion);
                datos.SetearParametro("@Localidad", clienteSeleccionado.Localidad);
                datos.SetearParametro("@Mail", clienteSeleccionado.Mail);
                datos.SetearParametro("@Telefono", clienteSeleccionado.Telefono);
                datos.SetearParametro("Id", clienteSeleccionado.Id);

                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminadoLogicoCliente(int identificacion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE CLIENTE SET Activo = 0 WHERE id = @Id");
                datos.SetearParametro("@Id", identificacion);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

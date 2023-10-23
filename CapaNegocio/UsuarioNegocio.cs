using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        public List<Usuario> listaUsuario()
        {
            List<Usuario> lista= new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT nombreUsuario, contrasenia, U.nombre as nombreReal, apellido, U.idRol, R.nombre as nombreRol FROM Usuario U inner join Rol R on U.idRol = R.id");
                datos.EjectuarLectura();

                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.NomUsuario = (string)datos.Lector["nombreUsuario"];
                    aux.Password = (string)datos.Lector["contrasenia"];
                    aux.Nombre = (string)datos.Lector["nombreReal"];
                    aux.Apellido = (string)datos.Lector["apellido"];
                    aux.Rol = new Rol();
                    aux.Rol.Id = (int)datos.Lector["idRol"];
                    aux.Rol.Nombre = (string)datos.Lector["nombreRol"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
            
        }

        public void NuevoUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into USUARIO Values(@usuario, @nombre, @apellido, @password, @idRol)");
                datos.SetearParametro("@usuario", usuario.NomUsuario);
                datos.SetearParametro("@nombre", usuario.Nombre);
                datos.SetearParametro("@apellido", usuario.Apellido);
                datos.SetearParametro("@password", usuario.Password);
                datos.SetearParametro("@idRol", usuario.Rol.Id);

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

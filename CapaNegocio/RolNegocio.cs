using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaNegocio
{
    public class RolNegocio
    {
        public List<Rol> listaRoles()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Rol> listaRoles = new List<Rol>();
            
            try
            {
                datos.SetearConsulta("select id, nombre, descripcion from Rol");
                datos.EjectuarLectura();
                while (datos.Lector.Read())
                {
                    Rol auxiliar = new Rol();
                    auxiliar.Id = (int)datos.Lector["id"];
                    auxiliar.Nombre = (string)datos.Lector["nombre"];
                    auxiliar.Descripcion = (string)datos.Lector["descripcion"];

                    listaRoles.Add(auxiliar);
                    
                }

                return listaRoles;


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

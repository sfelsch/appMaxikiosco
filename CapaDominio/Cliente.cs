using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string CuilCuit { get; set; }
        public string CondicionIva { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }

        public bool Activo { get; set; }

    }
}

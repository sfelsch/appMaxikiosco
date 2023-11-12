using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Provedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public string Cuit { get; set; }
        public bool Activo { get; set; }

    }

   
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public int StockMinimo { get; set; }
        public decimal Precio { get; set; }

        [DisplayName("Precio.P")]
        public decimal PrecioProveedor { get; set; }
        [DisplayName("Ganancia")]
        public string PorcentajeGanancia { get; set; }
        public bool Activo { get; set; }
        public int IdProvedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        


    }

    
}

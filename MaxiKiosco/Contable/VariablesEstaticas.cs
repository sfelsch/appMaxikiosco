using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiKiosco.Contable
{
    class VariablesEstaticas
    {
        //Variables 
        public static string NombreTipoArt = "";
        public static string idArticulo = "";
        public static double total = 0;
        public static int NumFactura = 0;
        public static bool aux = false;
        public static char Factura;
        public static string idCliente = "";

        //Usuario
        public static string nickname = "";
        public static string pass = "";

        //DETALLES CUENTAS
        public static bool verCompleto = false;
        public static int idRubro = 0;
        public static string IdCuenta = "";
        public static string rubro = "";
        public static int idTipoCuenta = 0;
        public static string fechaDesde = "";
        public static string fechaHasta = "";
    }
}

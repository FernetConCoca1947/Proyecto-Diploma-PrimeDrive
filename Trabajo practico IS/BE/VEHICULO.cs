using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VEHICULO
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int KmActual { get; set; }
        public string Estado { get; set; }
        public CATEGORIA Categoria { get; set; }
        public SUCURSAL Sucursal { get; set; }
    }
}

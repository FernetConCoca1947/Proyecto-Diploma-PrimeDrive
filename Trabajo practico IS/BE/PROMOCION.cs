using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PROMOCION
    {
        public int IdPromocion { get; set; }
        public string Nombre { get; set; }
        public string TipoPromocion { get; set; }
        public SUCURSAL Sucursal { get; set; }
        public CATEGORIA CategoriaObjetivo { get; set; }
        public CATEGORIA CategoriaOrigenUpgrade { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string Motivo { get; set; }
        public bool Activa { get; set; }
        public int ReservasCaptadas { get; set; }
    }
}

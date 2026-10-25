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
        public string Nombre { get; set; } // Ej: "Upgrade Económico a Intermedio" o "Promo Vans Fin de Semana"
        public string TipoPromocion { get; set; } // "Baja Demanda" o "Upgrade Estratégico"
        public SUCURSAL Sucursal { get; set; } // Sucursal donde aplica la promoción
        public CATEGORIA CategoriaObjetivo { get; set; } // Categoría que recibe el descuento (ej. SUV / Intermedio / Van)
        public CATEGORIA CategoriaOrigenUpgrade { get; set; } // Opcional (null si es Baja Demanda; ej. Económico si es Upgrade)
        public decimal PorcentajeDescuento { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string Motivo { get; set; } // Justificación arrojada por el algoritmo estadístico
        public bool Activa { get; set; } // Estado de vigencia comercial
    }
}

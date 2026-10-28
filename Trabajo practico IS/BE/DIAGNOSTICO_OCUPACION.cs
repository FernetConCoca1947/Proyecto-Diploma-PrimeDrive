using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DIAGNOSTICO_OCUPACION
    {
        public CATEGORIA Categoria { get; set; }
        public int TotalFlota { get; set; }
        public int VehiculosReservados { get; set; }
        public decimal PorcentajeOcupacion { get; set; }

        // Propiedades resueltas por el motor algorítmico de la BLL
        public string DiagnosticoCorto { get; set; } // Ej: "🟢 Upgrade desde Econ." o "⚠️ Baja Demanda Pura"
        public string TipoAccionSugerida { get; set; } // "Upgrade Estratégico", "Baja Demanda" o "Ninguna"
        public CATEGORIA CategoriaOrigenSaturada { get; set; } // Solo se llena si es Upgrade
        public decimal DescuentoSugerido { get; set; }
        public decimal TarifaFinalSugerida { get; set; }
        public string ExplicacionDetallada { get; set; }
        public int UnidadesOciosas { get; set; }
        public decimal LucroCesante { get; set; }
    }
}

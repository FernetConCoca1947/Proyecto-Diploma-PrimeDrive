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
        public string DiagnosticoCorto { get; set; }
        public string TipoAccionSugerida { get; set; }
        public CATEGORIA CategoriaOrigenSaturada { get; set; }
        public decimal DescuentoSugerido { get; set; }
        public decimal TarifaFinalSugerida { get; set; }
        public string ExplicacionDetallada { get; set; }
        public int UnidadesOciosas { get; set; }
        public decimal LucroCesante { get; set; }
    }
}

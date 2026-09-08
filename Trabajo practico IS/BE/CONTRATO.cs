using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CONTRATO
    {
        public int Id { get; set; }
        public DateTime FechaHoraRetiro { get; set; }
        public DateTime? FechaHoraDevolucion { get; set; } // Anulable (?) porque se completa en el Check-in
        public int KmSalida { get; set; }
        public int? KmEntrada { get; set; } // Anulable (?) porque se completa en el Check-in[cite: 2]
        public decimal GarantiaRetenida { get; set; }
        public decimal? MontoFinal { get; set; } // Anulable (?) porque se completa en el Check-in[cite: 2]
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public RESERVA Reserva { get; set; }
        public VEHICULO Vehiculo { get; set; }

    }
}

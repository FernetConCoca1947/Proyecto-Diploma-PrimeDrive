using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class MANTENIMIENTO
    {
        public int Id { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int KmService { get; set; }
        public string Motivo { get; set; }
        public VEHICULO Vehiculo { get; set; }
    }
}

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
        public VEHICULO Vehiculo { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int KmService { get; set; }
        public decimal Costo { get; set; }
        public string TareasRealizadas { get; set; }
    }
}

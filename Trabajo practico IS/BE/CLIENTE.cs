using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CLIENTE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public string Telefono {  get; set; }
        public DateTime FechaVencimientoLicencia { get; set; }
        public string NumeroLicenciaConducir { get; set; }

    }
}

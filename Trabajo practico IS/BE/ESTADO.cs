using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ESTADO
    {
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public string Ambito { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

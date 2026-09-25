using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SUCURSAL
    {
        private MP_SUCURSAL mapper = new MP_SUCURSAL();

        public List<BE.SUCURSAL> Listar()
        {
            return mapper.Listar();
        }
    }
}

using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ESTADO
    {
        private MP_ESTADO mapper = new MP_ESTADO();

        public List<BE.ESTADO> Listar()
        {
            return mapper.Listar();
        }

        public List<BE.ESTADO> ListarPorAmbito(string ambito)
        {
            return mapper.ListarPorAmbito(ambito);
        }
    }
}

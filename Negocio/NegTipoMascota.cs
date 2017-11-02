using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegTipoMascota
    {
        private DaoTipoMascota daoTipoMas;

        public NegTipoMascota()
        {
            daoTipoMas = new DaoTipoMascota();
        }

        public List<EntTipoMascota> findAll()
        {
            return daoTipoMas.findAll();
        }

        public DataSet fillSelect()
        {
            return daoTipoMas.fillSelect();
        }
    }
}

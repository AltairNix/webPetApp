using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class NegMascota
    {
        private DaoMascota daoMascota;

        public NegMascota()
        {
            daoMascota = new DaoMascota();
        }

        public void create(EntMascota entMascota)
        {

            //validar id_Usuario
            daoMascota.crearMascota(entMascota);

            //validar nombre usuario


            //
        }

    }
}

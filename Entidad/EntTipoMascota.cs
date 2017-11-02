using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EntTipoMascota
    {
        private int id_tipo_masc;
        private string nom_masc;
        private DateTime fec_creacion;
        private DateTime fec_actualizacion;
        private string creado_por;
        private string actualizado_por;

        public int Id_tipo_masc { get => id_tipo_masc; set => id_tipo_masc = value; }
        public string Nom_masc { get => nom_masc; set => nom_masc = value; }
        public DateTime Fec_creacion { get => fec_creacion; set => fec_creacion = value; }
        public DateTime Fec_actualizacion { get => fec_actualizacion; set => fec_actualizacion = value; }
        public string Creado_por { get => creado_por; set => creado_por = value; }
        public string Actualizado_por { get => actualizado_por; set => actualizado_por = value; }
    }
}

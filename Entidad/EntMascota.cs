using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EntMascota
    {

        private int id_masc;
        private string nom_mascota;
        private string sexo;
        private string peso;
        private DateTime fec_nacimiento;
        private string com_general;
        private int dificultad;
        private string altura;
        private string color;
        private string textura;
        private bool flag_piel_sensible;
        private bool flag_facil_quemado;
        private bool flag_secadora_pelo;
        private bool flag_agresivo_ani;
        private bool flag_ladrador;
        private bool flag_mordelon;
        private bool flag_masticador;
        private bool flag_timido;
        private bool flag_movedizo;
        private bool flag_correa_puesta;
        private bool flag_diabetico;
        private bool flag_corazon;
        private bool flag_sordo;
        private bool flag_epileptico;
        private bool flag_antirrabico;
        private bool flag_ciego;
        private bool flag_fallecido;
        private string com_grooming;
        private string com_personalidad;
        private string com_medico;
        private DateTime fec_creacion;
        private DateTime fec_actualizacion;
        private int id_raza;
        private int id_usuario;

        public int Id_masc { get => id_masc; set => id_masc = value; }
        public string Nom_mascota { get => nom_mascota; set => nom_mascota = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Peso { get => peso; set => peso = value; }
        public DateTime Fec_nacimiento { get => fec_nacimiento; set => fec_nacimiento = value; }
        public string Com_general { get => com_general; set => com_general = value; }
        public int Dificultad { get => dificultad; set => dificultad = value; }
        public string Altura { get => altura; set => altura = value; }
        public string Color { get => color; set => color = value; }
        public string Textura { get => textura; set => textura = value; }
        public bool Flag_piel_sensible { get => flag_piel_sensible; set => flag_piel_sensible = value; }
        public bool Flag_facil_quemado { get => flag_facil_quemado; set => flag_facil_quemado = value; }
        public bool Flag_secadora_pelo { get => flag_secadora_pelo; set => flag_secadora_pelo = value; }
        public bool Flag_agresivo_ani { get => flag_agresivo_ani; set => flag_agresivo_ani = value; }
        public bool Flag_ladrador { get => flag_ladrador; set => flag_ladrador = value; }
        public bool Flag_mordelon { get => flag_mordelon; set => flag_mordelon = value; }
        public bool Flag_masticador { get => flag_masticador; set => flag_masticador = value; }
        public bool Flag_timido { get => flag_timido; set => flag_timido = value; }
        public bool Flag_movedizo { get => flag_movedizo; set => flag_movedizo = value; }
        public bool Flag_correa_puesta { get => flag_correa_puesta; set => flag_correa_puesta = value; }
        public bool Flag_diabetico { get => flag_diabetico; set => flag_diabetico = value; }
        public bool Flag_corazon { get => flag_corazon; set => flag_corazon = value; }
        public bool Flag_sordo { get => flag_sordo; set => flag_sordo = value; }
        public bool Flag_epileptico { get => flag_epileptico; set => flag_epileptico = value; }
        public bool Flag_antirrabico { get => flag_antirrabico; set => flag_antirrabico = value; }
        public bool Flag_ciego { get => flag_ciego; set => flag_ciego = value; }
        public bool Flag_fallecido { get => flag_fallecido; set => flag_fallecido = value; }
        public string Com_grooming { get => com_grooming; set => com_grooming = value; }
        public string Com_personalidad { get => com_personalidad; set => com_personalidad = value; }
        public string Com_medico { get => com_medico; set => com_medico = value; }
        public DateTime Fec_creacion { get => fec_creacion; set => fec_creacion = value; }
        public DateTime Fec_actualizacion { get => fec_actualizacion; set => fec_actualizacion = value; }
        public int Id_raza { get => id_raza; set => id_raza = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }

    }
}

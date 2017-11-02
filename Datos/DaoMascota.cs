using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class DaoMascota
    {

        private Conexion objConexion;
        private SqlCommand comando;

        public DaoMascota()
        {
            objConexion = Conexion.EstadoConexion();
        }

        public void crearMascota(EntMascota entMascota)
        {
            try
            {
                StringBuilder querySb = new StringBuilder();

                querySb.Append("INSERT INTO");
                querySb.Append(" ");
                querySb.Append("Mascota");
                querySb.Append(" ");
                querySb.Append("(nom_mascota, peso, fec_nacimiento, com_general, dificultad, altura, color, textura, flag_piel_sensible, flag_facil_quemado, flag_secadora_pelo, flag_agresivo_ani, flag_ladrador, flag_mordelon, flag_masticador, flag_timido, flag_movedizo, flag_correa_puesta, flag_diabetico, flag_corazon, flag_sordo, flag_epileptico, flag_antirrabico, flag_ciego, flag_fallecido, com_grooming, com_personalidad, com_medico, fec_creacion, fec_actualizacion, id_raza, id_usuario)");
                querySb.Append(" ");
                querySb.Append("VALUES");
                querySb.Append(" ");
                querySb.Append("@nom_mascota, @peso, @fec_nacimiento, @com_general, @dificultad, @altura, @color, @textura, @flag_piel_sensible, @flag_facil_quemado, @flag_secadora_pelo, @flag_agresivo_ani, @flag_ladrador, @flag_mordelon, @flag_masticador, @flag_timido, @flag_movedizo, @flag_correa_puesta, @flag_diabetico, @flag_corazon, @flag_sordo, @flag_epileptico, @flag_antirrabico, @flag_ciego, @flag_fallecido, @com_grooming, @com_personalidad, @com_medico, @fec_creacion, @fec_actualizacion, @id_raza, @id_usuario");

                comando = new SqlCommand(querySb.ToString(), objConexion.GetCon());
                comando.Parameters.AddWithValue("@nom_mascota", entMascota.Nom_mascota);
                comando.Parameters.AddWithValue("@peso", entMascota.Peso);
                comando.Parameters.AddWithValue("@fec_nacimiento", entMascota.Fec_nacimiento);
                comando.Parameters.AddWithValue("@com_general", entMascota.Com_general);
                comando.Parameters.AddWithValue("@dificultad", entMascota.Dificultad);
                comando.Parameters.AddWithValue("@altura", entMascota.Altura);
                comando.Parameters.AddWithValue("@color", entMascota.Color);
                comando.Parameters.AddWithValue("@textura", entMascota.Textura);
                comando.Parameters.AddWithValue("@flag_piel_sensible", entMascota.Flag_piel_sensible);
                comando.Parameters.AddWithValue("@flag_facil_quemado", entMascota.Flag_facil_quemado);
                comando.Parameters.AddWithValue("@flag_secadora_pelo", entMascota.Flag_secadora_pelo);
                comando.Parameters.AddWithValue("@flag_agresivo_ani", entMascota.Flag_agresivo_ani);
                comando.Parameters.AddWithValue("@flag_ladrador", entMascota.Flag_ladrador);
                comando.Parameters.AddWithValue("@flag_mordelon", entMascota.Flag_mordelon);
                comando.Parameters.AddWithValue("@flag_masticador", entMascota.Flag_masticador);
                comando.Parameters.AddWithValue("@flag_timido", entMascota.Flag_timido);
                comando.Parameters.AddWithValue("@flag_movedizo", entMascota.Flag_movedizo);
                comando.Parameters.AddWithValue("@flag_correa_puesta", entMascota.Flag_correa_puesta);
                comando.Parameters.AddWithValue("@flag_diabetico", entMascota.Flag_diabetico);
                comando.Parameters.AddWithValue("@flag_corazon", entMascota.Flag_corazon);
                comando.Parameters.AddWithValue("@flag_sordo", entMascota.Flag_sordo);
                comando.Parameters.AddWithValue("@flag_epileptico", entMascota.Flag_epileptico);
                comando.Parameters.AddWithValue("@flag_antirrabico", entMascota.Flag_antirrabico);
                comando.Parameters.AddWithValue("@flag_ciego", entMascota.Flag_ciego);
                comando.Parameters.AddWithValue("@flag_fallecido", entMascota.Flag_fallecido);
                comando.Parameters.AddWithValue("@com_grooming", entMascota.Com_grooming);
                comando.Parameters.AddWithValue("@com_personalidad", entMascota.Com_personalidad);
                comando.Parameters.AddWithValue("@com_medico", entMascota.Com_medico);
                comando.Parameters.AddWithValue("@fec_creacion", entMascota.Fec_creacion);
                comando.Parameters.AddWithValue("@fec_actualizacion", entMascota.Fec_actualizacion);
                comando.Parameters.AddWithValue("@id_raza", entMascota.Id_raza);
                comando.Parameters.AddWithValue("@id_usuario", entMascota.Id_usuario);

                objConexion.GetCon().Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                // Always call Close when done reading.
                objConexion.GetCon().Close();
                objConexion.CerrarCon();
            }


        }
    }
}

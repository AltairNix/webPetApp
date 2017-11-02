using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DaoTipoMascota
    {
        private Conexion objConexion;
        private SqlCommand comando;

        public DaoTipoMascota()
        {
            objConexion = Conexion.EstadoConexion();
        }

        public List<EntTipoMascota> findAll()
        {
            List<EntTipoMascota> listMascota = new List<EntTipoMascota>();
            
            try
            {
                StringBuilder querySb = new StringBuilder();

                querySb.Append("SELECT");
                querySb.Append(" ");
                querySb.Append("id_tipo_masc, nom_masc");
                querySb.Append(" ");
                querySb.Append("FROM");
                querySb.Append(" ");
                querySb.Append("TipoMascota");

                comando = new SqlCommand(querySb.ToString(), objConexion.GetCon());
                objConexion.GetCon().Open();
                SqlDataReader read = comando.ExecuteReader();

                while (read.Read())
                {
                    EntTipoMascota entTipoMasc = new EntTipoMascota();
                    entTipoMasc.Id_tipo_masc = Convert.ToInt32(read[0].ToString());
                    entTipoMasc.Nom_masc = read[1].ToString();
                    listMascota.Add(entTipoMasc);
                }


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

            return listMascota;
        }


        public DataSet fillSelect()
        {
            DataSet ds = new DataSet();

            try
            {
                StringBuilder querySb = new StringBuilder();

                querySb.Append("SELECT");
                querySb.Append(" ");
                querySb.Append("id_tipo_masc, nom_masc");
                querySb.Append(" ");
                querySb.Append("FROM");
                querySb.Append(" ");
                querySb.Append("TipoMascota");

                comando = new SqlCommand(querySb.ToString(), objConexion.GetCon());
                objConexion.GetCon().Open();
                
                DataTable table = new DataTable();
                table.Load(comando.ExecuteReader());
                ds.Tables.Add(table);
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

            return ds;
        }
    }
}

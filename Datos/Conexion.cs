using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {

        //singleton
        private static Conexion objConexion = null;
        private SqlConnection con;

        private Conexion()
        {
            con = new SqlConnection("Data Source=ASUS-PC;Initial Catalog=dbpettab;Integrated Security=True");
        }

        public static Conexion EstadoConexion()
        {
            return objConexion ?? (objConexion = new Conexion());
        }

        public SqlConnection GetCon()
        {
            return con;
        }

        public void CerrarCon()
        {
            objConexion = null;
        }

    }
}

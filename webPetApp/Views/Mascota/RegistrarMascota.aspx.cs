using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Negocio;

namespace webPetApp.Views.Mascota
{
    public partial class RegistrarMascota : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            NegTipoMascota negTipoMasc = new NegTipoMascota();
            List<EntTipoMascota> listTipoMasc = new List<EntTipoMascota>();

            //EntTipoMascota entTipoMasc = new EntTipoMascota();
            
            id_tipo_masc.DataSource = negTipoMasc.fillSelect().Tables[0];
            id_tipo_masc.DataTextField = "nom_masc";
            id_tipo_masc.DataValueField = "id_tipo_masc";
            id_tipo_masc.DataBind();


        }






    }
}
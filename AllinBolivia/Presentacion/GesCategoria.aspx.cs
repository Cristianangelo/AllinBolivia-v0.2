using AllinBolivia.Datos;
using AllinBolivia.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllinBolivia.Presentacion
{
    public partial class GesCategoria : System.Web.UI.Page
    {
        NCategoria ncategoria;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.Identity.Name == "")//si no esta logueado
            {
                Redireccion("Presentacion/Login.aspx");
            }

            if (HttpContext.Current.User.Identity.Name == "")//si no es adm
            {
                Redireccion("Presentacion/Lobby.aspx");
            }
            CargarCategorias();

            
        }

        void CargarCategorias()
        {
            ncategoria = new NCategoria();
            List<DCategoria> l = ncategoria.ObtenerCategorias();
            String comilla = "\"";
            String s = "";
            String bg = "fcfcfc";
            foreach (DCategoria element in  l)
            {
                if (bg == "fcfcfc")
                {
                    bg = "eaeaea";
                }
                else
                {
                    bg = "fcfcfc";
                }
                s = s + "<tr> 	<td valign= height="+comilla+"100px "+comilla+"top" + comilla + " bgcolor=" + comilla + bg + comilla + " class=" + comilla + "Bodycelda" + comilla + "><a href=" + comilla + "Categoria.aspx?id="+element.Id1.ToString() + comilla + ">" + element.Nombre1 + "</a></td> 	<td valign=" + comilla + "top" + comilla + " bgcolor=" + comilla + bg + comilla + " class=" + comilla + "Bodycelda" + comilla + ">"+element.Descripcion1+"</td> 	<td valign=" + comilla + "top" + comilla + " bgcolor=" + comilla + bg + comilla + " class=" + comilla + "Bodycelda" + comilla + ">185</td> 	</tr>";

            }
            //nuevo
            s = s + "<tr> 	<td   valign= height=" + comilla + "100px " + comilla + "top" + comilla + " bgcolor=" + comilla + bg + comilla + " class=" + comilla + "Bodycelda" + comilla + "><a href=" + comilla + "#" + comilla + "></a></td> 	<td valign=" + comilla + "top" + comilla + " bgcolor=" + comilla + bg + comilla + " class=" + comilla + "Bodycelda" + comilla + "></td> 	<td  align=" + comilla + "right" + comilla + " valign=" + comilla + "top" + comilla + " bgcolor=" + comilla + bg + comilla + " class=" + comilla + "Bodycelda" + comilla + "><a href="+comilla+"Categoria.aspx"+comilla+"><IMG SRC = " + comilla + "../images/NUEVO.png" + comilla + "></a></td> 	</tr>";
            Categorias.Text = s;
        }

        public void Redireccion(string pagina)
        {
            if (true)
            {
                Response.Write("<script language='javascript'>window.location='" + pagina + "';</script>");

            }
        }
    }
}
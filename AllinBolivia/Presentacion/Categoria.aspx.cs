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
    public partial class Categoria : System.Web.UI.Page
    {
        NCategoria ncategoria;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.Identity.Name != "")//si esta logueado
            {
                ncategoria = new NCategoria();
                if (Request.QueryString["Id"] != null) //si esta con parametros
                {
                    if (!IsPostBack)
                    {
                        int i = System.Convert.ToInt32(Request.QueryString["Id"]);
                        DCategoria c = ncategoria.ObtenerCategoria(i);
                        TextBox3.Text = c.Id1.ToString();
                        TextBox1.Text = c.Nombre1;
                        TextBox2.Text = c.Descripcion1;
                        ImageButton2.Visible = true;
                    }
                }
                else {
                    ide.Visible = false;
                }
                
                

            }   
            else
            {
                Redireccion("Login.aspx");
            }
         
        }





        public void Redireccion(string pagina)
        {
            if (true)
            {
                Response.Write("<script language='javascript'>window.location='" + pagina + "';</script>");

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Request.QueryString["Id"] != null) //si esta con parametros
            {
                ncategoria.Id1 = System.Convert.ToInt32(Request.QueryString["Id"]);
                ncategoria.Nombre1 = TextBox1.Text;
                ncategoria.Descripcion1 = TextBox2.Text;
                ncategoria.Modificar();
                Redireccion("GesCategoria.aspx");
            }
            else
            {
                ncategoria.Nombre1 = TextBox1.Text;
                ncategoria.Descripcion1  = TextBox2.Text;
                ncategoria.Guardar();
                Redireccion("GesCategoria.aspx");

            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Request.QueryString["Id"] != null) //si esta con parametros
            {
                ncategoria.Id1 = System.Convert.ToInt32(Request.QueryString["Id"]);
                ncategoria.Eliminar();
                Redireccion("GesCategoria.aspx");
            }
        }

    }
}
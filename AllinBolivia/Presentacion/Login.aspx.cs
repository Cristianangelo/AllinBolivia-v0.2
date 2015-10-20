using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllinBolivia.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Datos.Conexion.Autenticar(Login1.UserName, Login1.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
                //Redireccion("Default.aspx");

            }   
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
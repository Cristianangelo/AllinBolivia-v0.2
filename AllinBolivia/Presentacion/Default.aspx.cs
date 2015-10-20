using AllinBolivia.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllinBolivia
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NCategoria categoria = new NCategoria();
            categoria.Nombre1 = TextBox1.Text;
            categoria.Descripcion1 = TextBox2.Text;
            categoria.Guardar();
        }
    }
}
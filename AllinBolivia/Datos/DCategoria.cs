using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace AllinBolivia.Datos
{
    public class DCategoria
    {
        int Id;
        String Nombre;
        String Descripcion;

        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySql"].ToString()); 


        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }


        public String Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public String Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }



        

        public Boolean Guardar()
        {
            int rowcount;
            ConnectionState PreviousConecctionState;
            PreviousConecctionState = con.State;
            //String fechaa = Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            //2015-05-12 06:36:46
            string coma = "','";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MySqlCommand comando = new MySqlCommand("insert into Categoria (Nombre, Descripcion) values('"+Nombre +coma + Descripcion + "')", con);
                rowcount = comando.ExecuteNonQuery();

                if (rowcount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                Exception e = new Exception();
            }
            finally
            {
                if (PreviousConecctionState == ConnectionState.Closed)
                {
                    con.Close();
                }
            }

            return false;
        }
    }
}
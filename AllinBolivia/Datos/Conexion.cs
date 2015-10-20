using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AllinBolivia.Datos
{
    public class Conexion
    {

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySql"].ToString()); 

        public static Boolean Autenticar(string login, string pass)
        {
            //consulta a la base de datos (administrador)
            string sql = @"SELECT COUNT(*) 
                          FROM Persona
                          WHERE Login = @login AND password = @pass";
            //cadena conexion 
            //using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySql"].ToString()))
            {
                conn.Open();//abrimos conexion 

                //SqlCommand cmd = new SqlCommand(sql, conn); //ejecutamos la instruccion 
                MySqlCommand cmd = new MySqlCommand(sql, conn); //ejecutamos la instruccion 
                cmd.Parameters.AddWithValue("@login", login); //enviamos los parametros 
                cmd.Parameters.AddWithValue("@pass", pass);

                int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada 



                if (count > 0)
                    return true;
                return false;


            }

        }




    }
}
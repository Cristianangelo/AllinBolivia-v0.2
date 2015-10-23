
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AllinBolivia.Datos
{
    public class DCategoria
    {
        int Id;
        String Nombre;
        String Descripcion;

       

        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["somee"].ToString());


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
                SqlCommand comando = new SqlCommand("insert into Categoria values('" + Nombre + coma + Descripcion1 + "')", con);
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
        public List<DCategoria> ObtenerCategorias()
        {
            List<String[]> l = Consulta("select categoria.id,categoria.nombre,categoria.descripcion from categoria");
            List<DCategoria> l2 = new List<DCategoria>();
            for (int i = 0; i < l.Count; i++)
            {
                DCategoria a = new DCategoria();
                a.Id1 = System.Convert.ToInt32(l[i][0]);
                a.Nombre1 = l[i][1];
                a.Descripcion1 = l[i][2];
                l2.Add(a);
            }
            return l2;
        }
        public DCategoria ObtenerCategoria(int id)
        {
            List<String[]> l = Consulta("select categoria.id,categoria.nombre,categoria.descripcion from categoria where id = " + id);
            DCategoria a = new DCategoria();
            a.Id1 = System.Convert.ToInt32(l[0][0]);
            a.Nombre1 = l[0][1];
            a.Descripcion1 = l[0][2];
            return a;
        }
        public Boolean Modificar()
        {
            //FechaNacimiento = Convert.ToDateTime("YYYY/MM/DD");
            int rowcount;
            ConnectionState PreviousConecctionState;
            PreviousConecctionState = con.State;
            string coma = "','";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand comando = new SqlCommand("Update categoria set nombre = '" + Nombre + "',descripcion = '" + Descripcion1+ "' where id = '" + Id + "'", con);
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
        public List<String[]> Consulta(String query) //devuelve la consulta con el formato lista de vectores
        {
            List<String[]> l = new List<String[]>();
            String[] v;

            ConnectionState previousConnectionState = new ConnectionState();
            previousConnectionState = con.State;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter cmd = new SqlDataAdapter(query, con);
                //MySqlDataAdapter cmd = new MySqlDataAdapter(query, con);
                DataTable tablas = new DataTable();
                cmd.Fill(tablas);
                for (int a = 0; a <= tablas.Rows.Count - 1; a++)
                {
                    v = new String[tablas.Columns.Count];
                    for (int i = 0; i <= tablas.Columns.Count - 1; i++)
                    {
                        v[i] = tablas.Rows[a].ItemArray[i].ToString();
                    }
                    l.Add(v);
                }
            }
            finally
            {
                if (previousConnectionState == ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return l;
        }
        public Boolean Eliminar()
        {
            //FechaNacimiento = Convert.ToDateTime("YYYY/MM/DD");
            int rowcount;
            ConnectionState PreviousConecctionState;
            PreviousConecctionState = con.State;
            string coma = "','";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand comando = new SqlCommand("Delete from categoria where id = '" + Id + "'", con);
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
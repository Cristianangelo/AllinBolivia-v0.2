using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllinBolivia.Datos
{
    public class DPersona
    {
        int Id;
        String Nombres;
        String Apellidos;
        String Login;
        String Password;


        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
       
        public String Nombres1
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
       

        public String Apellidos1
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
      

        public String Login1
        {
            get { return Login; }
            set { Login = value; }
        }
        

        public String Password1
        {
            get { return Password; }
            set { Password = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllinBolivia.Datos
{
    public class DSesion
    {
        int Id;
        DateTime Fecha;
        String Estado;
        int IdPersona;


        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        
        public DateTime Fecha1
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        
        public String Estado1
        {
            get { return Estado; }
            set { Estado = value; }
        }
        

        public int IdPersona1
        {
            get { return IdPersona; }
            set { IdPersona = value; }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllinBolivia.Datos
{
    public class DApuesta
    {
        int Id;
        int Monto;
        DateTime Fecha;
        int IdPersona;
        int IdEvento;
        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        
        public int Monto1
        {
            get { return Monto; }
            set { Monto = value; }
        }
       
        public DateTime Fecha1
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        
        public int IdPersona1
        {
            get { return IdPersona; }
            set { IdPersona = value; }
        }
        

        public int IdEvento1
        {
            get { return IdEvento; }
            set { IdEvento = value; }
        }
    }
}
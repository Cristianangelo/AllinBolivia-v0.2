using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllinBolivia.Datos
{
    public class DEvento
    {
        int Id;
        String Descripcion;
        DateTime Fecha;
        String Estado;
        int ResultadoA;
        int ResultadoB;
        int IdPersona;
        int IdCategoria;
        int IdEquipoA;
        int IdEquipoB;


        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        

        public String Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
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
        
        public int ResultadoA1
        {
            get { return ResultadoA; }
            set { ResultadoA = value; }
        }
        
        public int ResultadoB1
        {
            get { return ResultadoB; }
            set { ResultadoB = value; }
        }
        
        public int IdPersona1
        {
            get { return IdPersona; }
            set { IdPersona = value; }
        }
        
        public int IdCategoria1
        {
            get { return IdCategoria; }
            set { IdCategoria = value; }
        }
       
        public int IdEquipoA1
        {
            get { return IdEquipoA; }
            set { IdEquipoA = value; }
        }
        

        public int IdEquipoB1
        {
            get { return IdEquipoB; }
            set { IdEquipoB = value; }
        }
    }
}
using AllinBolivia.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllinBolivia.Negocio
{
    public class NCategoria
    {
        DCategoria dcategoria;
        int Id;
        String Nombre;
        String Descripcion;

        public NCategoria()
        {
            dcategoria = new DCategoria();
        }

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


        public void Guardar()
        {
            dcategoria.Nombre1 = Nombre;
            dcategoria.Descripcion1 = Descripcion;
            dcategoria.Guardar();
        }
    }
}
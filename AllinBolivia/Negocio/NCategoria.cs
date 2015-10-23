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

        public void Modificar()
        {
            dcategoria.Id1 = Id;
            dcategoria.Nombre1 = Nombre;
            dcategoria.Descripcion1 = Descripcion;
            dcategoria.Modificar();
        }
        public void Eliminar()
        {
            dcategoria.Id1 = Id;
            dcategoria.Eliminar();
        }

        public List<DCategoria> ObtenerCategorias()
        {
            return dcategoria.ObtenerCategorias();
        }
        public DCategoria ObtenerCategoria(int i)
        {
            return dcategoria.ObtenerCategoria(i);
        }
    }
}
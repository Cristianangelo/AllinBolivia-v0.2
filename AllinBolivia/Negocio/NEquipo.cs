using AllinBolivia.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllinBolivia.Negocio
{
    public class NEquipo
    {
        DEquipo dequipo;
        int Id;
        String Nombre;
        public NEquipo()
        {
            dequipo = new DEquipo();
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


        public void Guardar()
        {
            dequipo.Nombre1 = Nombre;
            dequipo.Guardar();
        }

        public void Modificar()
        {
            dequipo.Id1 = Id;
            dequipo.Nombre1 = Nombre;

            dequipo.Modificar();
        }
        public void Eliminar()
        {
            dequipo.Id1 = Id;
            dequipo.Eliminar();
        }

        public List<DEquipo> ObtenerCategorias()
        {
            return dequipo.ObtenerEquipos();
        }
        public DEquipo ObtenerEquipo(int i)
        {
            return dequipo.ObtenerEquipo(i);
        }
    }
}
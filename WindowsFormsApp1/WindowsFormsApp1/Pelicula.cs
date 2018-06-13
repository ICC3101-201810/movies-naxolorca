using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pelicula
    {
        public string nombre, descripcion;
        public Director director;
        public DateTime fechaEstreno;
        public int presupuesto;
        public Estudio estudio;

public Pelicula(string nombre, Director director, string descripcion, DateTime fechaEstreno, int presupuesto,Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.descripcion = descripcion;
            this.fechaEstreno = fechaEstreno;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
    }
}

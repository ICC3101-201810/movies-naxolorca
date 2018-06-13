using System;

namespace WindowsFormsApp1
{
    public class Estudio
    {
        public string nombre, direccion;
        public DateTime fechaApertura;

        public Estudio(string nombre,string direccion,DateTime fechaApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApertura = fechaApertura;

        }
        
        
    }
}
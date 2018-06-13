using System;

namespace WindowsFormsApp1
{
    public abstract class Persona
    {
        public string nombre, apellido, biografia;
        public DateTime fechaNacimiento;

        public Persona(string nombre,string apellido,DateTime fechaNacimiento,string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.biografia = biografia;
        }
    }
}
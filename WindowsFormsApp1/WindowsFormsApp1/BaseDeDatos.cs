using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BaseDeDatos
    {
        public List<Pelicula> peliculas;
        public List<Persona> personas;
        public List<Estudio> estudios;
        public List<PeliculaActor> peliculasactor;
        public List<PeliculaProductor> peliculasproductor;
        
        public BaseDeDatos()
        {
            peliculas = new List<Pelicula>();
            personas = new List<Persona>();
            estudios = new List<Estudio>();
            peliculasactor = new List<PeliculaActor>();
            peliculasproductor = new List<PeliculaProductor>();
     
        }

        public BindingList<string> busqueda(string b)
        {
            BindingList<Object> lista = new BindingList<Object>();
            BindingList<string> nombres = new BindingList<string>();

            foreach (Pelicula peli in peliculas)
            {
                if (peli.nombre == b || peli.descripcion == b || Convert.ToString(peli.fechaEstreno.Date) == b || peli.presupuesto.ToString() == b || peli.director.apellido == b || peli.director.biografia == b || Convert.ToString(peli.director.fechaNacimiento.Date) == b || peli.director.nombre == b)
                {
                    if (lista.Count <= 50)
                    {
                        lista.Add(peli);
                    }

                }
                foreach (Estudio estu in estudios)
                {
                    if (estu.direccion == b || Convert.ToString(estu.fechaApertura.Date) == b || estu.nombre == b)
                    {
                        if (lista.Count <= 50)
                        {
                            lista.Add(peli);
                        }
                    }
                }
                foreach (Persona per in personas)
                {
                    if (per.apellido == b || per.biografia == b || Convert.ToString(per.fechaNacimiento.Date) == b || per.nombre == b)
                    {
                        if (lista.Count <= 50)
                        {
                            lista.Add(per);
                        }
                    }
                }
                foreach (PeliculaActor pe in peliculasactor)
                {
                    if (pe.actor.apellido == b || pe.actor.biografia == b || Convert.ToString(pe.actor.fechaNacimiento.Date) == b || pe.actor.nombre == b || pe.pelicula.descripcion == b || pe.pelicula.director.apellido == b || pe.pelicula.director.biografia == b || Convert.ToString(pe.pelicula.director.fechaNacimiento.Date) == b || pe.pelicula.director.nombre == b || Convert.ToString(pe.pelicula.fechaEstreno.Date) == b || pe.pelicula.nombre == b || Convert.ToString(pe.pelicula.presupuesto) == b)
                    {
                        if (lista.Count <= 50)
                        {
                            lista.Add(pe);
                        }
                    }
                }
                foreach (PeliculaProductor pee in peliculasproductor)
                {
                    if (pee.productor.apellido == b || pee.productor.biografia == b || Convert.ToString(pee.productor.fechaNacimiento.Date) == b || pee.productor.nombre == b || pee.pelicula.descripcion == b || pee.pelicula.director.apellido == b || pee.pelicula.director.biografia == b || Convert.ToString(pee.pelicula.director.fechaNacimiento.Date) == b || pee.pelicula.director.nombre == b || Convert.ToString(pee.pelicula.fechaEstreno.Date) == b || pee.pelicula.nombre == b || Convert.ToString(pee.pelicula.presupuesto) == b)
                    {
                        if (lista.Count <= 50)
                        {
                            lista.Add(pee);
                        }
                    }
                }
            }
            foreach(object o in lista)
            {
                if (o is Pelicula)
                {
                    Pelicula pelicula = (Pelicula)o;
                    nombres.Add(pelicula.nombre + " Pelicula");
                }
                else if (o is Actor)
                {
                    Actor actor = (Actor)o;
                    nombres.Add(actor.nombre + " Actor");
                }
                else if (o is Director)
                {
                    Director actor = (Director)o;
                    nombres.Add(actor.nombre + " Director");
                }
                else if (o is Productor)
                {
                    Productor actor = (Productor)o;
                    nombres.Add(actor.nombre + " Productor");
                }
                else if (o is Estudio)
                {
                    Estudio actor = (Estudio)o;
                    nombres.Add(actor.nombre + " Estudio");
                }
                else if (o is PeliculaActor)
                {
                    PeliculaActor actor = (PeliculaActor)o;
                    nombres.Add(actor.pelicula.nombre + " Pelicula");
                }
                else if (o is PeliculaProductor)
                {
                    PeliculaProductor actor = (PeliculaProductor)o;
                    nombres.Add(actor.pelicula.nombre + " Pelicula");
                }
            }
            return nombres;
        }

    }
}

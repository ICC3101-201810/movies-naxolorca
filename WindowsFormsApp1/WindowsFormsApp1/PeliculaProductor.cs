namespace WindowsFormsApp1
{
    public class PeliculaProductor
    {
        public Pelicula pelicula;
        public Productor productor;

        public PeliculaProductor(Pelicula pelicula, Productor productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}
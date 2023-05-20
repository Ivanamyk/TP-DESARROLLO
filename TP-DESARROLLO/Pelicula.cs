using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DESARROLLO
{
    public class Pelicula
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string sinopsis { get; set; }
        private string poster { get; set; }
        private int duracion { get; set; }

        private List<Funcion> misFunciones;

        public Pelicula(int ID, string Nombre, string Sinopsis, string Poster, int Duracion)
        {
            this.id = ID;
            this.nombre = Nombre;
            this.sinopsis = Sinopsis;
            this.poster = Poster;
            this.duracion = Duracion;
        }
    }
}

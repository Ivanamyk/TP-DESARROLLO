using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DESARROLLO
{
    public class Sala
    {
        private int id { get; set; }
        private string ubicacion { get; set; }
        private int capacidad { get; set; }
        
        private List<Funcion> misFunciones;

        private Sala(int ID, string Ubicacion, int Capacidad) { 
            this.id = ID;
            this.ubicacion = Ubicacion;
            this.capacidad = Capacidad;
        }
    }
}

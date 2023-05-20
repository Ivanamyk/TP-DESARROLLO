using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DESARROLLO
{
    public class Funcion
    {
        private int id { get; set; }
        private Sala miSala { get; set; }
        private Pelicula miPelicula { get; set; }
        private DateTime fecha { get; set; }
        private int cantClientes { get; set; }
        private double Costo { get; set; }
        private List<Usuario> misClientes { get; set; }

        private Funcion(int ID, Sala MiSala, Pelicula MiPelicula, DateTime Fecha, int CantClientes, double Costo) { 
        
            this.id = ID;
            this.miSala = MiSala;   
            this.fecha = Fecha;
            this.miPelicula = MiPelicula;
            this.cantClientes = CantClientes;
            this.Costo = Costo;
        }
    }
}

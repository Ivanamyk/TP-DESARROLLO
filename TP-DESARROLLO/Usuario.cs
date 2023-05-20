using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP_DESARROLLO
{
    public class Usuario
    {
        public int id{ get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string pass { get; set; }
        public bool esAdmin { get; set; }
        public double credito { get; set; }
        public bool bloqueado { get; set; }
        public int intentosFallidos { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public List<Funcion> misFunciones;


        public Usuario(string Mail, string Pass) { 
        this.mail = Mail;
        this.pass = Pass;
        }

        public Usuario(int ID, int DNI, string Nombre, string Apellido, DateTime FechaNacimiemto, string Mail, string Pass, double Credito, bool EsAdmin
          )
        {
        
            this.id = ID;
            this.dni = DNI;
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.fechaNacimiento = FechaNacimiemto;
            this.mail = Mail;
            this.pass = Pass;
            this.credito = Credito;
            this.esAdmin = EsAdmin;
        }



    }
}

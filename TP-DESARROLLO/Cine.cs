using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace TP_DESARROLLO
{
    public class Cine
    {
       private List<Usuario> misUsuarios;
       private List<Funcion> misFunciones;
       private List<Sala> misSalas;
       private List<Pelicula> misPeliculas;
       private Usuario usuarioActual;
       private Usuario bloqueado;
       private int idUsuarios;
       private int idFunciones;
       private int idPeliculas;
       private int idSalas;

        public Cine()
        {
            misUsuarios = new List<Usuario>();
            misFunciones = new List<Funcion>();
            misSalas = new List<Sala>();
            misPeliculas = new List<Pelicula>();
        }

        public bool iniciarSesion(string mail, string pass) {
            int intentos = 0;
            foreach (Usuario usu in misUsuarios)
            {
                if (usu.mail == mail && usu.pass == pass && !usu.bloqueado)
                {
                    string message2 = String.Format("Bienvenido ", usu.nombre);
                    const string caption2 = "CinemaCity";
                    var result2 = MessageBox.Show(message2, caption2);
                    usu.intentosFallidos = 0;
                    usuarioActual = usu;

                    if (usu.mail == mail && usu.pass == pass && !usu.bloqueado && usu.esAdmin == true) { 
                        
                    }

                    return true;
                }

                if(usu.mail == mail && usu.pass !=pass) {

                    usu.intentosFallidos++;
                    string message = String.Format("Usuario o password incorrectos. " + usu.intentosFallidos + "° intento.");
                    const string caption = "CinemaCity";
                    var result = MessageBox.Show(message, caption);

                    if (usu.intentosFallidos == 3)
                    {
                        usu.bloqueado = true;
                        string message3 = String.Format("Usuario bloqueado!. Intente con otra cuenta.");
                        const string caption3 = "CinemaCity";
                        var result3 = MessageBox.Show(message3, caption3);
                    }
                    return false;
                }
                
                }

            return false;
        }

        #region METODOS PARA MOSTRAR    

        public List<Usuario> verListaUsuario() { 
        return misUsuarios.ToList();
        }

        #endregion

        #region METODOS PARA AGREGAR
        public bool agregarUsuario(int id, int dni, string nombre, string apellido, DateTime fecha ,string mail, string pass, double credito, bool esAdmin) {

            if (misUsuarios.Count == 0)
            { 
                misUsuarios.Add(new Usuario(idUsuarios, dni, nombre, apellido, fecha, mail, pass, credito, esAdmin));

                idUsuarios++;
                return true;
            }
            //si count = 0, crea uno nuevo; si no recorro la lista y veo que no hayan usuarios con mail dupli
            else
            {
                foreach (Usuario usu in misUsuarios)
                {
                    if (usu.dni != dni && usu.id != id)
                    {
                        misUsuarios.Add(new Usuario(idUsuarios, dni, nombre, apellido, fecha, mail, pass, credito, esAdmin));

                        idUsuarios++;
                        return true;
                    }
                    else {
                        return false;
                    }
                }

                return false;
            }
            
           

        }
        #endregion

    }

}

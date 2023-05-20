using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DESARROLLO
{
    public partial class Usuarios : Form
    {
        private Cine miCine;
        private int selectedUser;

        public Usuarios(Cine cine)
        {
            InitializeComponent();

            miCine = cine;
        }


        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Usuario u in miCine.verListaUsuario())
            {
                dataGridView1.Rows.Add(new string[] { u.id.ToString(), u.dni.ToString(), u.nombre, u.apellido, u.fechaNacimiento.ToString(), u.mail, u.pass, u.esAdmin.ToString() });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}

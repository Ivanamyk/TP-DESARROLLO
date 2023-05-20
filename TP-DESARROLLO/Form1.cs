namespace TP_DESARROLLO
{
    public partial class Form1 : Form
    {
        private Cine miCine;
        public Form1()
        {
            InitializeComponent();

            miCine = new Cine();

            DateTime fecha = new DateTime(2023, 1, 1, 5, 12, 55);
            miCine.agregarUsuario(0, 33433456, "ivana", "yegros", fecha, "mail", "123", 120.00, true);
            miCine.agregarUsuario(0, 33433456, "pedro", "calvo", fecha, "mail3", "123", 120.00, false);
            miCine.agregarUsuario(0, 33433456, "maria", "sanchez", fecha, "mail2", "123", 120.00, false);

        }

        private void iniciar_sesion_Click(object sender, EventArgs e)
        {
            miCine.iniciarSesion(textBox1.Text, textBox2.Text);

        }
    }
}
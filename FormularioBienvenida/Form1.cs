using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormularioBienvenida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce tu nombre.");
                return;
            }
            if (!int.TryParse(textoEdad, out int edad) || edad < 0)
            {
                MessageBox.Show("Introduce una edad válida.");
                return;
            }
            lblResultado.Text =
            $"Hola, {nombre}. Tienes {edad} años.";
        }
    }
}

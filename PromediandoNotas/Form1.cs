namespace PromediandoNotas
{
    public partial class PormedioNotas : Form
    {
        string nEstudiante = "";
        double n1, n2, n3, Resultado = 0.0;
        double suma = 0;
        public PormedioNotas()
        {
            InitializeComponent();
        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            nEstudiante = txtNombre.Text;
            n1 = double.Parse(txtNota1.Text);
            n2 = double.Parse(txtNota2.Text);
            n3 = double.Parse(txtNota3.Text);
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            suma = n1 + n2 + n3;
            Resultado = suma / 3;
            label1.Text = ("Promedio del Estudiante: " + nEstudiante + "\n" + "Nota 1: " + n1 + "\n" + "Nota 2: " + n2 + "\n" + "Nota 3: " + n3 + "\n" + "Promedio de las 3 notas: : " + Resultado).ToString();
        }

        private void Limpieza_Click(object sender, EventArgs e)
        {
            nEstudiante = "";
            n1 = 0;
            n2 = 0;
            n3 = 0;
            suma = 0;
            Resultado = 0.0;
            label1.Text = "";
        }
    }
}
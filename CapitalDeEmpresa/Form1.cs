namespace CapitalDeEmpresa
{
    public partial class CapitalTotal : Form
    {
        double m1, m2, m3;
        double resultado = 0;
        Boolean b = false;
        public CapitalTotal()
        {
            InitializeComponent();
        }

        private void Aplicar1_Click(object sender, EventArgs e)
        {
            m1 = double.Parse(txtMonto1.Text);
            m2 = double.Parse(txtMonto2.Text);
            m3 = double.Parse(txtMonto3.Text);
            b = true;
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (b = true)
            {
                resultado = m1 + m2 + m3;
                Mostrar.Text = ("Monto 1: " + m1 + "\n" + "Monto 2: " + m2 + "\n" + "Monto 3: " + m3 + "\n" + "Monto Total: " + resultado).ToString();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            m1 = 0;
            m2 = 0;
            m3 = 0;
            txtMonto1.Text = "";
            txtMonto2.Text = "";
            txtMonto3.Text = "";
            resultado = 0;
            Mostrar.Text= " ";
            resultado = 0;
            b = false;
        }
    }
}
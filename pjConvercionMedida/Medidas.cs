using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjConvercionMedida
{
    public partial class Medidas : Form
    {
        double centimetros = 0;
        double pulgadas = 0;
        double pie = 0;
        double yardas = 0; 
        double metros;
        public Medidas()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Calculando el valor en metros
              metros = double.Parse(txtMetros.Text);
            //Realizando conversiones 

            centimetros = metros * 100;
            pulgadas = metros * 39.3701;
            pie = metros * 3.280841666667;
            yardas = metros * 1.0936138888889999077;
            Mostrar.Text = ("_*Converciones*_" + "\n" + "Centimetros: " + centimetros + "\n" + "Pulgadas: " + pulgadas + "\n" + "Pie: " + pie + "\n" + "Yardas: " + yardas).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            centimetros = 0;
            pulgadas = 0;
            pie = 0;
            yardas =0;
            Mostrar.Text = " ";
            txtMetros.Text = " ";
            txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Desea salir?","Medidas",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

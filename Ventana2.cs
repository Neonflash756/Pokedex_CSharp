using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_CSharp
{
    public partial class Ventana2 : Form
    {
        String descripcion = "";
        String altura = "";
        String peso = "";
        String especie = "";
       
        public Ventana2()
        {
            InitializeComponent();

            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.BackColor = Color.Transparent;

            label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label4.BackColor = Color.Transparent;

            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.BackColor = Color.Transparent;
        }

        private void cajaDescripcion_Click(object sender, EventArgs e)
        {

        }

        public void cambiaDescripcionPokemon(String descripcion) {
            cajaDescripcion.Text = descripcion;
        }

        public void cambiaAlturaPokemon(String altura){
            label3.Text = altura;
        }

        public void cambiaPesoPokemon(String peso){
            label4.Text = peso;
        }

        public void cambiaEspeciePokemon(String especie)
        {
            label6.Text = especie;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

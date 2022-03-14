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
        public Ventana2()
        {
            InitializeComponent();
            
        }

        private void cajaDescripcion_Click(object sender, EventArgs e)
        {

        }

        public void cambiaDescripcionPokemon(String descripcion) {
            cajaDescripcion.Text = descripcion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_CSharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //Guarda el id del pokemon que se está viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            imagenPokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            imagenPokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nombrePokemon_Click(object sender, EventArgs e)
        {

        }

        private void masInfo_Click(object sender, EventArgs e)
        {

            Ventana2 v = new Ventana2();

            v.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString());
            v.Show();

        }
    }
}

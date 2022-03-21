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
            izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            izquierda.FlatAppearance.BorderSize = 0;
            izquierda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            izquierda.FlatAppearance.MouseOverBackColor = Color.Transparent;
            izquierda.BackColor = Color.Transparent;

            derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            derecha.FlatAppearance.BorderSize = 0;
            derecha.FlatAppearance.MouseDownBackColor = Color.Transparent;
            derecha.FlatAppearance.MouseOverBackColor = Color.Transparent;
            derecha.BackColor = Color.Transparent;

            masInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            masInfo.FlatAppearance.BorderSize = 0;
            masInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            masInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            masInfo.BackColor = Color.Transparent;

            nombrePokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nombrePokemon.BackColor = Color.Transparent;
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
            v.cambiaAlturaPokemon(misPokemons.Rows[0]["altura"].ToString());
            v.cambiaPesoPokemon(misPokemons.Rows[0]["peso"].ToString());
            v.cambiaEspeciePokemon(misPokemons.Rows[0]["especie"].ToString());
            v.Show();

        }
    }
}

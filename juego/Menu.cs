using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class MenuInstrucciones : Form
    {
        System.Media.SoundPlayer Player = new System.Media.SoundPlayer();
        public bool Musica = true;

        public MenuInstrucciones()
        {
            InitializeComponent();
            Player.SoundLocation = "Musica menu.wav";
            Player.Play();
        }
        
        //Botones de inicio segun la dificultad
        private void button2_Click_1(object sender, EventArgs e)
        {
            Player.Stop();
            Player.SoundLocation = "Musica juego.wav";
            Player.Play();
            Acciones Acc = new Acciones();
            Acc.IniciarFacil();
            this.Hide();
            Juego juego = new Juego();
            juego.Show();
        }//Facil
        private void button4_Click(object sender, EventArgs e)
        {
            Player.Stop();
            Player.SoundLocation = "Musica juego.wav";
            Player.Play();
            Acciones Acc = new Acciones();
            Acc.IniciarMedio();
            Juego juego = new Juego();
            juego.Show();
            this.Hide();
        }//Medio
        private void button3_Click(object sender, EventArgs e)
        {
            Player.Stop();
            Player.SoundLocation = "Musica juego.wav";
            Player.Play();
            Acciones Acc = new Acciones();
            Acc.IniciarDificil();
            Juego juego = new Juego();
            juego.Show();
            this.Hide();
        }//Dificil


        //Boton de control de musica
        private void button5_Click(object sender, EventArgs e)
        {
            if (Musica == true)
                Musica = false;
            else Musica = true;

            if (Musica == false)
            {
                Player.Stop();
            }
            else
            {
                Player.SoundLocation = "Musica menu.wav";
                Player.Play();
            }
        }


        //Boton de cerrado del juego
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }












        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

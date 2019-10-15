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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer Player = new System.Media.SoundPlayer();


        public Form1()
        {
            InitializeComponent();
            Player.SoundLocation = "Musica1.wav";
            Player.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuInstrucciones menu = new MenuInstrucciones();
            menu.Show();
            this.Hide();
        }
    }
}

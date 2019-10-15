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
    public partial class Juego : Form
    {
        Acciones Acc = new Acciones();
        System.Media.SoundPlayer Player = new System.Media.SoundPlayer();
        public bool Musica = true;
        public Juego()
        {
            InitializeComponent();
        }

        //Carga del fomulario y contenido
        private void Juego_Load(object sender, EventArgs e)
        {
            Acc.SelecciondePalabra(PBImagenes, LBOportunidades, FLPPalabra,LBMensage);
            LBMensage.Visible = false;
        }


        //Boton para cerrar el juego
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Reinicio de palabra
        private void button2_Click(object sender, EventArgs e)
        {
            Acc.SelecciondePalabra(PBImagenes, LBOportunidades, FLPPalabra, LBMensage);
            Desbloqueo();
        }


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
                Player.SoundLocation = "Musica juego.wav";
                Player.Play();
            }
        }
        //Boton para volver al menu
        private void button2_Click_1(object sender, EventArgs e)
        {
            MenuInstrucciones menu = new MenuInstrucciones();
            menu.Show();
            this.Close();
        }
    

    //Bloqueo y desbloqueo de los controles del juego
    void Desbloqueo()
        {
            PTeclado.Enabled = true;
            BTTeclaA.Enabled = true;
            BTTeclaB.Enabled = true;
            BTTeclaC.Enabled = true;
            BTTeclaD.Enabled = true;
            BTTeclaE.Enabled = true;
            BTTeclaF.Enabled = true;
            BTTeclaG.Enabled = true;
            BTTeclaH.Enabled = true;
            BTTeclaI.Enabled = true;
            BTTeclaJ.Enabled = true;
            BTTeclaK.Enabled = true;
            BTTeclaL.Enabled = true;
            BTTeclaM.Enabled = true;
            BTTeclaN.Enabled = true;
            BTTeclaÑ.Enabled = true;
            BTTeclaO.Enabled = true;
            BTTeclaP.Enabled = true;
            Q.Enabled = true;
            BTTeclaR.Enabled = true;
            BTTeclaS.Enabled = true;
            BTTeclaT.Enabled = true;
            BTTeclaU.Enabled = true;
            BTTeclaV.Enabled = true;
            BTTeclaX.Enabled = true;
            BTTeclaY.Enabled = true;
            BTTeclaZ.Enabled = true;
        }



        //Envio de letras mediante botones alojados en un Pannel
        private void BTTeclaA_Click(object sender, EventArgs e)
        {
            char L = 'A';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaA.Enabled = false;
        }
        private void BTTeclaE_Click(object sender, EventArgs e)
        {
            char L = 'E';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaE.Enabled = false;
        }
        private void BTTeclaF_Click(object sender, EventArgs e)
        {
            char L = 'F';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaF.Enabled = false;
        }
        private void BTTeclaB_Click(object sender, EventArgs e)
        {
            char L = 'B';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaB.Enabled = false;
        }
        private void BTTeclaC_Click(object sender, EventArgs e)
        {
            char L = 'C';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaC.Enabled = false;
        }
        private void BTTeclaD_Click(object sender, EventArgs e)
        {
            char L = 'D';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaD.Enabled = false;
        }
        private void BTTeclaG_Click(object sender, EventArgs e)
        {
            char L = 'G';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaG.Enabled = false;
        }
        private void BTTeclaH_Click(object sender, EventArgs e)
        {
            char L = 'H';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaH.Enabled = false;
        }
        private void BTTeclaI_Click(object sender, EventArgs e)
        {
            char L = 'I';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaI.Enabled = false;
        }
        private void BTTeclaJ_Click(object sender, EventArgs e)
        {
            char L = 'J';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaJ.Enabled = false;
        }
        private void BTTeclaK_Click(object sender, EventArgs e)
        {
            char L = 'K';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaK.Enabled = false;
        }
        private void BTTeclaL_Click(object sender, EventArgs e)
        {
            char L = 'L';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaL.Enabled = false;
        }
        private void BTTeclaM_Click(object sender, EventArgs e)
        {
            char L = 'M';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaM.Enabled = false;
        }
        private void BTTeclaN_Click(object sender, EventArgs e)
        {
            char L = 'N';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaN.Enabled = false;
        }
        private void BTTeclaÑ_Click(object sender, EventArgs e)
        {
            char L = 'Ñ';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaÑ.Enabled = false;
        }
        private void BTTeclaO_Click(object sender, EventArgs e)
        {
            char L = 'O';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaO.Enabled = false;
        }
        private void BTTeclaP_Click(object sender, EventArgs e)
        {
            char L = 'P';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaP.Enabled = false;
        }
        private void Q_Click(object sender, EventArgs e)
        {
            char L = 'Q';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            Q.Enabled = false;
        }
        private void BTTeclaR_Click(object sender, EventArgs e)
        {
            char L = 'R';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaR.Enabled = false;
        }
        private void BTTeclaS_Click(object sender, EventArgs e)
        {
            char L = 'S';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaS.Enabled = false;
        }
        private void BTTeclaT_Click(object sender, EventArgs e)
        {
            char L = 'T';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaT.Enabled = false;
        }
        private void BTTeclaV_Click(object sender, EventArgs e)
        {
            char L = 'V';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaV.Enabled = false;
        }
        private void BTTeclaW_Click(object sender, EventArgs e)
        {
            char L = 'W';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaW.Enabled = false;
        }
        private void BTTeclaX_Click(object sender, EventArgs e)
        {
            char L = 'X';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaX.Enabled = false;
        }
        private void BTTeclaY_Click(object sender, EventArgs e)
        {
            char L = 'Y';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaY.Enabled = false;
        }
        private void BTTeclaZ_Click(object sender, EventArgs e)
        {
            char L = 'Z';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaZ.Enabled = false;
        }
        private void BTTeclaU_Click(object sender, EventArgs e)
        {
            char L = 'U';
            Acciones Acc = new Acciones();
            Acc.Evaluar(L, PBImagenes, LBMensage, FLPPalabra, LBOportunidades, PTeclado);
            BTTeclaU.Enabled = false;
        }





        //Malos Clicks
        private void button14_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }     
        private void FLPPalabra_Paint(object sender, PaintEventArgs e)
        {
        }
        private void PBImagenes_Click(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace Juego
{
    class Acciones : ClaseInicio
    {
        public static int control = 0;
        public static char[] palabra;
        public Button LetraAdivinada = new Button();



        public void IniciarFacil()
        {
            Palabras1 = new string[] { "Perro", "Gato", "Caballo", "Cohete", "Barco", "Casa", "Arbitro", "Portero", "Albañil", "Guardia", "Carro", "Bosque" };
        }
        public void IniciarMedio()
        {
            Palabras1 = new string[14] { "Evaluacion", "Agudo", "Circulo", "Cuadrado", "Triangulo", "Conducta", "Finalidad", "Imitar", "Evadir", "Tronco", "Vacuna", "Avicola", "Infantil", "Funcional" };
        }
        public void IniciarDificil()
        {
            Palabras1 = new string[15] { "Distrofia", "Arteria", "Atrofia", "Herencia", "Postura", "Terapia", "Virus", "Paralisis", "Pantorrilla", "Plaguicida", "Miembro", "Medieval", "Medida", "Traductor", "Trasladar" };
        }



        public void SelecciondePalabra(PictureBox PBImagenes, Label LBOportunidades, FlowLayoutPanel FLPPalabra,Label LBMensage)
        {
            Juego juego = new Juego();
            //Ocultar el mensaje de Victoria/Derrota
            LBMensage.Visible = false;
            //Borrar letras existentes
            FLPPalabra.Controls.Clear();
            // Iniciar el contador de oportunidades
            Oportunidades1 = 8;
            LBOportunidades.Text = (Oportunidades1-1).ToString();
            PBImagenes.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Ahorcado" + (Oportunidades1));
            //Generar un numero aleatorio para la seleccion de la palabra
            Random random = new Random();
            int NumeroPalabra = random.Next(0,Palabras1.Length);
            //Convertir la palabra en una cadena de caracteres
            palabra = Palabras1[NumeroPalabra].ToUpper().ToCharArray();
            Palabra1 = palabra;
            //Creacion de letras mediante un ciclo
            for (int IndicesLetras = 0; IndicesLetras < Palabra1.Length; IndicesLetras++)
            {
                Button Letra = new Button();
                Letra.Tag = Palabra1[IndicesLetras].ToString();
                Letra.Height = 75;
                Letra.Width = 46;
                Letra.ForeColor = Color.Black;
                Letra.Text = "-";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.Transparent;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "LetraAdivinada" + IndicesLetras.ToString();
                FLPPalabra.Controls.Add(Letra);
            }

        }

        public void Evaluar(char Letra, PictureBox PBImagenes, Label LBMensage, FlowLayoutPanel FLPPalabra, Label LBOportunidades, Panel PTeclado)
        {
            //Comprobar coincidencia
            bool Encontrado=false;
            for (int NumLetra = 0; NumLetra < Palabra1.Length; NumLetra++)
            {
                if (Palabra1[NumLetra].Equals(Letra))
                { 
                    LetraAdivinada = FLPPalabra.Controls.Find("LetraAdivinada" + NumLetra, true).FirstOrDefault() as Button;
                    LetraAdivinada.Text = Palabra1[NumLetra].ToString();
                    Palabra1[NumLetra] = '-';
                    control = control +1;
                    Encontrado = true;
                } 
            }

            //Comprobar si no se ha encontrado coincidencia
            if (Encontrado==false)
            {
                Oportunidades1--;
                LBOportunidades.Text = (Oportunidades1-1).ToString();
                PBImagenes.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Ahorcado" + Oportunidades1);

                if (Oportunidades1 == 1)
                {
                    PTeclado.Enabled = false;
                    LBMensage.Text = "Has Perdido";
                    LBMensage.ForeColor = Color.Red;
                    LBMensage.Visible = true;
                    control = 0;
                }
            }

            //Comprobar si se han adivinado todas las palabras
            if (control == Palabra1.Length)
            {
                PTeclado.Enabled = false;
                LBMensage.Text = "¡Has Ganado!";
                LBMensage.ForeColor = Color.Green;
                LBMensage.Visible = true;
                control = 0;
            }
            
        }

    }
}

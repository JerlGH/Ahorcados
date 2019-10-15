using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Juego
{
    class ClaseInicio
    {
        private static char[] PalabraAdivinada;
        private static char[] Palabra;
        private static char[] Alfabeto;
        private static int Oportunidades;
        private static string[] Palabras;

        public char[] PalabraAdivinada1
        {
            get
            {
                return PalabraAdivinada;
            }

            set
            {
                PalabraAdivinada = value;
            }
        }
        public char[] Palabra1
        {
            get
            {
                return Palabra;
            }

            set
            {
                Palabra = value;
            }
        }
        public char[] Alfabeto1
        {
            get
            {
                return Alfabeto;
            }

            set
            {
                Alfabeto = value;
            }
        }
        public int Oportunidades1
        {
            get
            {
                return Oportunidades;
            }

            set
            {
                Oportunidades = value;
            }
        }
        public string[] Palabras1
        {
            get
            {
                return Palabras;
            }

            set
            {
                Palabras = value;
            }
        }


        
    }
}

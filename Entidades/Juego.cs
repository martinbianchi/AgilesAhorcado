using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego
    {
        #region Fields

        private string _palabraAAdivinar;

        public string PalabraAAdivinar
        {
            get { return _palabraAAdivinar; }
            set { _palabraAAdivinar = value; }
        }

        private char[] _palabraEscondida;

        public char[] PalabraEscondida
        {
            get { return _palabraEscondida; }
            set { _palabraEscondida = value; }
        }

        #endregion

        #region Methods
        public string IniciarJuego()
        {
            return "Juego Iniciado";
        }

        public string DevolverPalabraParcial()
        {
            return new string(PalabraEscondida);
        }

        public bool IngresarLetra(char letra)
        {
            int posicion = PalabraAAdivinar.IndexOf(letra);

            if (posicion != -1)
            {
                PalabraEscondida[posicion] = letra;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AdivinoPalabra()
        {
            string pal2 = new string (PalabraEscondida);
            return pal2.Equals(PalabraAAdivinar);
        }

        public void IngresarPalabraAAdivinar(string palabra)
        {
            PalabraAAdivinar = palabra;

            PalabraEscondida = new char[PalabraAAdivinar.Length];
            for (int i = 0; i < PalabraEscondida.Length; i++)
            {
                PalabraEscondida[i] = '-';
            }
        }

        #endregion
    }
}

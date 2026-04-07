using System;
using System.Collections.Generic;
using System.Text;

namespace juego1
{
    internal class Ventana
    {
        public int Ancho { get; set; }
        public int Alto { get; set;}

        public Ventana(int ancho, int alto)
        {
            Ancho = ancho;
            Alto = alto;
            Init();
        }
    private void Init()
        {
            Console.SetWindowSize(Ancho,Alto);
        }
    }
}

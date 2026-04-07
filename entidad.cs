using System;
using System.Collections.Generic;
using System.Text;

namespace juego1
{
    internal class Entidad
    {
        public string Nombre { get; set; }
        public int Vida { get; set;}
        public int Dano { get; set;}

        public Entidad(string nombre, int vida, int dano)
        {
            Nombre = nombre;
            Vida = vida;
            Dano = dano;
        }
        public void RecibirDano(int dano)
        {
            Vida -= dano;
            Console.WriteLine($"{Nombre} recibe {dano} de daño. Vida restante: {Vida}");
            if (Vida <= 0)
            {
                Console.WriteLine($"{Nombre} ha sido derrotado.");
            }
        }

        public void Atacar(Entidad objetivo)
        {
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} causando {Dano} de daño.");
            objetivo.RecibirDano(Dano);
        }

        public void MostrarVida()
        {
            Console.WriteLine($"{Nombre} - Vida: {Vida}");
        }

        public void Curar()
        {
            Vida += 50;
            Console.WriteLine($"{Nombre} se ah curado 50 de vida, vida actual:{Vida}");

        }
    }
}

using juego1;
int Opcion,Derrotados=0;

Ventana ventana = new(120, 40);
Console.WriteLine("Bienvenido a la mazmorra");
Console.WriteLine("ingrese su nombre");
string NombreJugador = Console.ReadLine();

Entidad Jugador = new(NombreJugador, 100, 20);
Entidad Enemigo1 = new("Ogro", 80, 15);
Entidad Enemigo2= new("Esqueleto",50, 25);
Entidad Enemigo3= new("Rey Duende",100, 50);

//nivel 1
Console.WriteLine("Ha aparecido un enemigo");
do 
{
    if (Jugador.Vida <= 0) { break; }
    Console.WriteLine("1. Atacar");
    Console.WriteLine("2. Curarse");
    Console.Write("Selecciona una opción: ");
    Opcion = int.Parse(Console.ReadLine());
    switch (Opcion)
    {
        case 1:
            Jugador.Atacar(Enemigo1);
            if (Enemigo1.Vida > 0)
            {
                Enemigo1.Atacar(Jugador);
            }
            break;
        case 2:
            Jugador.Curar();
            break;
        default:
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;
    }
    Console.WriteLine();
} while (Enemigo1.Vida >0);
Derrotados += 1;


//nivel 2
Console.WriteLine("Ha aparecido un enemigo");
do
{
    if (Jugador.Vida <= 0) { break; }
    Console.WriteLine("1. Atacar");
    Console.WriteLine("2. Curarse");
    Console.Write("Selecciona una opción: ");
    Opcion = int.Parse(Console.ReadLine());
    switch (Opcion)
    {
        case 1:
            Jugador.Atacar(Enemigo2);
            if (Enemigo2.Vida > 0)
            {
                Enemigo2.Atacar(Jugador);
            }
            break;
        case 2:
            Jugador.Curar();
            break;
        default:
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;
    }
    Console.WriteLine();
} while (Enemigo2.Vida > 0);
Derrotados +=1;

Console.WriteLine("te encontraste un cofre deseas abrirlo");
Console.WriteLine("1.Abrir");
Console.WriteLine("2.No Abrir");
Opcion = int.Parse(Console.ReadLine());
switch (Opcion)
{
    case 1:
        Jugador.Dano = 30;
        Console.WriteLine("el ataque ha aumentado");
        break;
    case 2:
        break;
    default:
        Console.WriteLine("opcion invalida");
        break;
}

//nivel 3
Console.WriteLine("Ha aparecido un enemigo");
do
{
    if (Jugador.Vida <= 0) { break; }
    Console.WriteLine("1. Atacar");
    Console.WriteLine("2. Curarse");
    Console.Write("Selecciona una opción: ");
    Opcion = int.Parse(Console.ReadLine());
    switch (Opcion)
    {
        case 1:
            Jugador.Atacar(Enemigo3);
            if (Enemigo3.Vida > 0)
            {
                Enemigo3.Atacar(Jugador);
            }
            break;
        case 2:
            Jugador.Curar();
            break;
        default:
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;
    }
    Console.WriteLine();
} while (Enemigo3.Vida > 0);
if (Enemigo3.Vida <= 0) { Derrotados += 1; }

Console.WriteLine($"se ha completado la mazmorra con exito derrotando a {Derrotados} enemigos ");






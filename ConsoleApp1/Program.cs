using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego de piedra, papel o tijera!");
        Console.WriteLine("Por favor, seleccione su jugada: piedra (r), papel (p), o tijera (s).");

        Random random = new Random();
        string[] jugadas = { "r", "p", "s" };
        int jugadorPuntuacion = 0;
        int computadoraPuntuacion = 0;

        while (true)
        {
            Console.Write("Jugada del jugador: ");
            string jugadorJugada = Console.ReadLine().ToLower();
            if (jugadorJugada != "r" && jugadorJugada != "p" && jugadorJugada != "s")
            {
                Console.WriteLine("Jugada inválida. Por favor, seleccione piedra (r), papel (p), o tijera (s).");
                continue;
            }

            string computadoraJugada = jugadas[random.Next(jugadas.Length)];
            Console.WriteLine($"Jugada de la computadora: {computadoraJugada}");

            if (jugadorJugada == computadoraJugada)
            {
                Console.WriteLine("Empate.");
            }
            else if ((jugadorJugada == "r" && computadoraJugada == "s") ||
                     (jugadorJugada == "p" && computadoraJugada == "r") ||
                     (jugadorJugada == "s" && computadoraJugada == "p"))
            {
                Console.WriteLine("¡El jugador gana esta ronda!");
                jugadorPuntuacion++;
            }
            else
            {
                Console.WriteLine("¡La computadora gana esta ronda!");
                computadoraPuntuacion++;
            }

            Console.WriteLine($"Puntuación: Jugador - {jugadorPuntuacion}, Computadora - {computadoraPuntuacion}");
            Console.WriteLine("Presione cualquier tecla para continuar, o presione 'q' para salir.");
            if (Console.ReadKey().KeyChar == 'q')
            {
                break;
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Puntuación final: Jugador - {jugadorPuntuacion}, Computadora - {computadoraPuntuacion}");
        Console.WriteLine("¡Gracias por jugar!");
    }
}

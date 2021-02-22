using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedra_papel_tijera
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Piedra_Papel_Tijera

                Desarrollar una aplicación de consola que me permita simular una partida de Piedra , Papel o tijera

                Reglas de Negocio
                -La partida se desarrolla entre el Usuario vs La Aplicación
                -El usuario hace una selección y se informa cual es el resultado
                -La aplicación debe permitir jugar mas de una partida
                -Al no querer continuar se tiene que mostrar las estadisticas
            */

            int piedra =1;
            int papel =2;
            int tijera =3;
            int ElementoCpu;
            int ElementoUsuario;
            int partidas = 0;
            int VictoriaCpu = 0;
            int VictoriaUsuario = 0;
            int Empates = 0;
            bool ficha = true;
            Random rnd = new Random();

            Console.WriteLine("Bienvenido a Piedra, Pepel o Tijera");
            Console.WriteLine("Presione una tecla para comenzar");
            Console.ReadKey();

            do
            {
                Console.WriteLine("Tus opciones son: ");
                Console.WriteLine("1 - Piedra");
                Console.WriteLine("2 - Papel");
                Console.WriteLine("3 - Tijera");
                Console.Write("Escribi el número del elemento elegido: ");
                ElementoUsuario = int.Parse(Console.ReadLine());
          
                   while (ElementoUsuario != piedra && ElementoUsuario != papel && ElementoUsuario != tijera)
                    {
                    Console.WriteLine();
                    Console.WriteLine("Esa opción no es válida.");
                    Console.WriteLine("Tus opciones son: ");
                    Console.WriteLine("1 - Piedra");
                    Console.WriteLine("2 - Papel");
                    Console.WriteLine("3 - Tijera");
                    Console.Write("Escribi el número del elemento elegido: ");
                    ElementoUsuario = Convert.ToInt32(Console.ReadLine());
                    }

                if (ElementoUsuario == piedra)
                {
                    Console.WriteLine("Elegiste piedra");
                }
                else if (ElementoUsuario == papel)
                {
                    Console.WriteLine("Elegiste papel");
                }
                else
                {
                    Console.WriteLine("Elegiste tijera");
                }

                ElementoCpu = rnd.Next(1, 4);

                if (ElementoCpu == piedra)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu competidor eligió piedra");
                }
                else if (ElementoCpu == papel)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu competidor eligió papel");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu competidor eligió tijera");
                }

                if (ElementoUsuario == piedra && ElementoCpu == tijera || ElementoUsuario == papel && ElementoCpu == piedra
                    || ElementoUsuario == tijera && ElementoCpu == papel)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ganaste!");
                    VictoriaUsuario++;
                }
                else if (ElementoUsuario == piedra && ElementoCpu == papel || ElementoUsuario == papel && ElementoCpu == tijera
                    || ElementoUsuario == tijera && ElementoCpu == piedra)
                {
                    Console.WriteLine();
                    Console.WriteLine("Perdiste!");
                    VictoriaCpu++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Empataron");
                    Empates++;
                }

                Console.WriteLine();
                Console.Write("volver a Jugar? S/N: ");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                ConsoleKey tecla = cki.Key;
                if (tecla == ConsoleKey.S)
                {
                    ficha = true;
                }
                else if (tecla == ConsoleKey.N)
                {
                    ficha = false;
                }

            partidas++;
                
                Console.Clear();
            } while (ficha == true);

            Console.WriteLine();
            Console.WriteLine($"Total de partidas jugadas: {partidas}");
            Console.WriteLine($"Partidas Ganadas: {VictoriaUsuario}");
            Console.WriteLine($"Partidas perdidas: {VictoriaCpu}");
            Console.WriteLine($"Empates: {Empates}");
            Console.WriteLine();
            Console.WriteLine("Gracias por jugar!");

            Console.ReadKey();
        }
           

        
    }
}

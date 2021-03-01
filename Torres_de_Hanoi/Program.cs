using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;

            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            Console.WriteLine("==▒▓ Este es el juego de las Torres de Hanoi ▓▒==");
            Console.WriteLine("");

            Console.WriteLine("    ┌┐        ╔╗        ┌┐");
            Console.WriteLine("   ▓▓▓▓       ║║        ││");
            Console.WriteLine("  ▓▓▓▓▓▓      ║║        ││");
            Console.WriteLine(" ▓▓▓▓▓▓▓▓     ║║        ││");
            Console.WriteLine("██████████    ║║        ││");
            Console.WriteLine("────┴┴────────╨╨────────┴┴────");
            Console.WriteLine("   INI        AUX       FIN");

            Console.WriteLine("");
            Console.WriteLine("Indica el número de discos...");
            string key = Console.ReadLine();

            while (!Int32.TryParse(key, out t))
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce un número valido...");
                key = Console.ReadLine();
            }

            if(key != "0")
            {
                Console.WriteLine("");
                Console.WriteLine("Has elegido " + key + " discos.");

                Pila INI = new Pila(Int32.Parse(key));
                ini = INI;


                Hanoi hanoi = new Hanoi();

                Console.WriteLine("");
                Console.WriteLine("Pulsa (I) para Iterativo, pulsa (R) para Recursivo...");
                string key2 = Console.ReadLine();
                key2 = key2.ToUpper();
                while (key2 != "I" && key2 != "R")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Valor no reconocido, introduce (I) o (R)...");
                    key2 = Console.ReadLine();
                    key2 = key2.ToUpper();
                }
                switch (key2)
                {
                    case "I":
                        int c = hanoi.iterativo(Int32.Parse(key), ini, fin, aux);
                        Console.WriteLine("");
                        Console.WriteLine("Se ha completado en " + c + " movimientos");
                        break;

                    case "R":
                        int d = hanoi.recursivo(Int32.Parse(key), ini, fin, aux);
                        Console.WriteLine("");
                        Console.WriteLine("Se ha completado en " + d + " movimientos");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No se puede jugar con 0 discos");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

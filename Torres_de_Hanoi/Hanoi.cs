using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        int m = 0;
        int direccion = 0;

     
        public void mover_disco(Pila a, Pila b)
        {
            if ((a.Top > b.Top || a.Top == 0) && b.Top != 0)
            {
                a.push(b.pop());
                direccion = 1;
                m++;
            }
            else if ((b.Top > a.Top || b.Top == 0) && a.Top != 0)
            {
                b.push(a.pop());
                direccion = 2;
                m++;
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            if(n%2 == 1 || n == 1)
            {
                while(fin.Size < n)
                {
                    mover_disco(ini, fin);
                    if (direccion == 2)
                    {
                        Console.WriteLine("Moviendo de inicio a fin");
                    }
                    else
                    {
                        Console.WriteLine("Moviendo de fin a inicio");
                    }
                    if (fin.Size == n) return m;
                    mover_disco(ini, aux);
                    if (direccion == 2)
                    {
                        Console.WriteLine("Moviendo de inicio a aux");
                    }
                    else
                    {
                        Console.WriteLine("Moviendo de aux a inicio");
                    }
                    mover_disco(aux, fin);
                    if (direccion == 2)
                    {
                        Console.WriteLine("Moviendo de aux a fin");
                    }
                    else
                    {
                        Console.WriteLine("Moviendo de fin a aux");
                    }
                    if (fin.Size == n) return m;

                }
            }
            else
            {
                while (fin.Size < n)
                {
                    mover_disco(ini, aux);
                    if (direccion == 2)
                    {
                        Console.WriteLine("Moviendo de inicio a aux");
                    }
                    else
                    {
                        Console.WriteLine("Moviendo de aux a inicio");
                    }
                    mover_disco(ini, fin);
                    if (direccion == 2)
                    {
                        Console.WriteLine("Moviendo de inicio a fin");
                    }
                    else
                    {
                        Console.WriteLine("Moviendo de fin a inicio");
                    }
                    if (fin.Size == n) return m;
                    mover_disco(aux, fin);
                    if (direccion == 2)
                    {
                        Console.WriteLine("Moviendo de aux a fin");
                    }
                    else
                    {
                        Console.WriteLine("Moviendo de fin a aux");
                    }
                    if (fin.Size == n) return m;

                }
            }
            return 0;
        }

        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            
            if(n == 1)
            {        
                mover_disco(ini, fin);
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);    
                mover_disco(ini, fin);
                recursivo(n - 1, aux, fin, ini);
            }

            return m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        private int top;
        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }


        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }

        public Pila(int s)
        {
            Size = s;
            Elementos = new List<Disco>();
            for (int i = 0; i < s; i++)
            {
                Elementos.Add(new Disco(s-i));
            }
            Top = Elementos[Elementos.Count - 1].Valor; 
        }

        public void push(Disco d)
        {
                Elementos.Add(d);
                Size++;
                Top = d.Valor;      
        }

        public Disco pop()
        {          
            if (Size > 0)
            {
                Disco d = Elementos[Elementos.Count - 1];
                Elementos.RemoveAt(Elementos.Count - 1);
                Size--;
                if (this.isEmpty())
                {
                    Top = 0;
                }
                else
                {
                    Top = Elementos[Elementos.Count - 1].Valor;
                }
                return d;
            }
            return null;
        }                

        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }
    }
}

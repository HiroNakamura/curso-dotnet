using System;
using interfaces;

namespace clases
{
    public class X: IServicio
    {
        public void metodo(int x)
        {
            Console.WriteLine("{0} : {1}",x,(x*2));
        }
        public void metodo(int x, char c)
        {
            int entero = 0;
            if(Char.IsDigit(c))
            {
                entero = (int)c;
            }
            int suma = x + entero;
            Console.WriteLine("Suma = {0}",suma);
        }
        public void metodo(object obj, long dato, int x)
        {
            Console.WriteLine("{0}",obj);
            Console.WriteLine("{0}",dato);
            Console.WriteLine("{0}",x);
        }
        public double metodo(double x, int y)
        {
            return (double) y + x;
        }
        public char metodo()
        {
            return '\u8876';
        }
    }
}
using System;
using clases;
using interfaces;

namespace chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
        }

        static void MockTestA()
        {
            Console.WriteLine();
            IServicio servX = new X();
            var entero = 9;
            servX.metodo(entero);
        }
    }
}

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
            servX.metodo(33, '\u4090');
            servX.metodo(33, '3');
            var result = servX.metodo(3.30, 34);
            Console.WriteLine("Resultado = {0}",result);
            Console.WriteLine("Char = {0}",servX.metodo());
            servX.metodo('\u0101', 300L, Int32.Parse("100"));
            object tipo = servX.metodo().GetType();
            Console.WriteLine("Tipo = {0}",tipo);
            
        }
    }
}

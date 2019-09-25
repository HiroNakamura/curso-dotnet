using System;

namespace chapter1
{
    class Program
    {
        public static readonly int MAX = 100;
        
        static void Main(string[] args)
        {
            TiposDeDatos();
            Parametros(args);
        }
        
        static void Parametros(string[] params)
        {
            if (params.Length > 0)
            {
                foreach (string param in params)
                {
                    Console.WriteLine(param);
                }
            }
            else
            {
                Console.WriteLine("No hay parametros!!!");
            }
        }
        
        
        static void TiposDeDatos()
        {
            byte b = 12;
            char car = '\u1002';
            bool verdadero = 13 > 2;
            decimal numero = 120;
            int entero = 90;
            float flotante = 34.2f;
            double real = 0.000021;
            long clave = 123300L;
            short s = -12;
            sbyte sb = 9;
            ushort us = 1;
            uint enter = 89;
            ulong largo = 2333L;
            object obj = null;
            Object myObj = new Object();
            Console.WriteLine("Tipos de datos:");
            Console.WriteLine("sbyte: {0}", sb);
            Console.WriteLine("short: {0}", s);
            Console.WriteLine("int: {0}", entero);
            Console.WriteLine("long: {0}", clave);
            Console.WriteLine("byte: {0}", b);
            Console.WriteLine("ushort: {0}", us);
            Console.WriteLine("uint: {0}", enter);
            Console.WriteLine("ulong: {0}", largo);
            Console.WriteLine("float: {0}", flotante);
            Console.WriteLine("double: {0}", real);
            Console.WriteLine("decimal: {0}", numero);
            Console.WriteLine("object: {0}", obj);
            Console.WriteLine("Object: {0}", myObj);
            Console.WriteLine("char: {0}", car);
            Console.WriteLine("bool: {0}", verdadero);
            Console.WriteLine("MAX: {0}", MAX);
        }
        
        
    }
}

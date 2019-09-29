using System;
using clases;

namespace chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
        }

        static void MockTestA()
        {
            X my_x1 = new X();
            my_x1.Version = "0.0.1";
            var my_x2 = new X("1.0.1");
            Console.WriteLine(my_x1.ToString());
            Console.WriteLine(my_x2.ToString());

            var my_y1 = new Y();
            my_y1.Version = "2.0";
            my_y1.Grupo = "com.csharp.mx";
            Console.WriteLine("{0}",my_y1.ToString());

            if(my_y1 == my_x1)
            {
                Console.WriteLine("El objeto {0} y el objeto {1} son iguales",my_x1,my_y1);
            }else
            {
                Console.WriteLine("El objeto {0} y el objeto {1} no son iguales",my_x1,my_y1);
            }

             if(my_y1.Equals(my_x1))
            {
                Console.WriteLine("El objeto {0} y el objeto {1} son iguales",my_x1,my_y1);
            }else
            {
                Console.WriteLine("El objeto {0} y el objeto {1} no son iguales",my_x1,my_y1);
            }

            CalculoImpl calculoImpl = new CalculoImpl();
            var enteros = new int[]{3,12,21,25,28,32,36,45,55,56,76,88,90,101,109,210,321,333,432,540};
            foreach(var entero in enteros)
            {
                if(calculoImpl.EsPar(entero) == true)
                {
                    Console.WriteLine("Cumple la condicion: {0}",entero);
                }
            }


        }
    }
}

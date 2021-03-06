﻿using System;
using clases;
using interfaces;

namespace chapter5
{
    class Program
    {

        public Program(){}

        ~Program(){}
        static void Main(string[] args)
        {
            MockTestA();
            MockTestB();
            MockTestC();
        }

        static void MockTestC()
        {
           ServicioImplA serv = new ServicioImplA();
           serv.Mensaje();
           serv.Mensaje("Mariana");
           bool verdadero = serv.Mensaje("X",'X');
           if(verdadero == true)
           {
               Console.WriteLine("X y X son iguales");
           }
           int numero = serv.Mensaje('F');
           Console.WriteLine("Numero: {0}",numero);
        }

        static void MockTestB()
        {
            Console.WriteLine("**** Clases ****");
            Cliente clienteA = new Cliente();
            Console.WriteLine("{0}",clienteA);
            Cliente clienteB = new Cliente(1L,"Armando","Archundia");
            Console.WriteLine("{0}",clienteB); 
            ClienteFrecuente clienteFrecuenteA = new ClienteFrecuente();
            Console.WriteLine("{0}",clienteFrecuenteA);
            DateTime fecha = new DateTime();
            ClienteFrecuente clienteFrecuenteB = new ClienteFrecuente(2L,"Thomas","Muller",fecha);
            Console.WriteLine("{0}",clienteFrecuenteB);
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

using System;
using System.Collections.Generic;

namespace chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
        }


        static bool CumpleCriterio(int item)
        {
            bool resultado = false;
            if(item % 5 == 0 && item %3 == 0){
                resultado = true;
            }
            return resultado;
        }

        static void RecorrerListaInt(List<int> lista)
        {
            if(lista.Count > 0)
            {
                foreach(var numero in lista)
                {
                    Console.WriteLine("Hola no. {0}",numero);
                }
                Console.WriteLine();
                for(int i=0; i < lista.Count; i++)
                {
                    if(CumpleCriterio(lista[i]))
                    {
                        Console.WriteLine("Cumple criterio el no. {0}",lista[i]);
                    }
                }
            }
        }

        static void RecorrerListaIntInversa(List<int> lista)
        {
           if(lista.Count > 0)
           {
               Console.WriteLine("Lista llena");
               try
               {
                   for(int i=lista.Count ; i > 0 ; i--)
                   {
                       Console.WriteLine("Hola no. {0}",lista[i]);
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(":"+ex.Message);
                }
           }
        }

        static void MockTestA()
        {
            List<int> listaNumeros = new List<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20});
            RecorrerListaInt(listaNumeros);
            RecorrerListaIntInversa(listaNumeros);
        }

    }
}

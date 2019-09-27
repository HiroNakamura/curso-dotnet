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

       static Dictionary<int, string> GetDiccionario()
       {
           Dictionary<int, string> diccionario = new Dictionary<int, string>();
           diccionario.Add(0, "Los dolientes");
           diccionario.Add(1, "En busca de Klingsor");
           diccionario.Add(2, "Cain");
           diccionario.Add(3, "El evangelio segun JesusCristo");
           diccionario.Add(4, "La tabla de Flandes");
           diccionario.Add(5, "Adios a Dylan");
           return diccionario;
       }
        

        static bool CumpleCriterio(int item)
        {
            bool resultado = false;
            if(item % 5 == 0 && item %3 == 0){
                resultado = true;
            }
            return resultado;
        }


        static void RecorrerDiccionarios()
        {
            Console.WriteLine("Recorrer diccionarios:");
            if(GetDiccionario().Count > 0){
                Console.WriteLine("Diccionario lleno!!");
                foreach (var item in GetDiccionario())
                {
                    Console.WriteLine("{0} : {1}", item.Key, item.Value);
                }
            }
            var miDiccionario = GetDiccionario();
            var valores = miDiccionario.Values;
            var llaves = miDiccionario.Keys;
            Console.WriteLine("Llaves:");
            foreach(var llave in llaves)
            {
                Console.WriteLine("Llave: {0}",llave);
            }
            Console.WriteLine("Valores:");
            foreach(var valor in valores)
            {
                Console.WriteLine("Valor: {0}",valor);
            }

            Console.WriteLine();
            var itemEliminado= 4;
            miDiccionario.Remove(itemEliminado);
            foreach (var item in miDiccionario)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            Console.WriteLine();
            miDiccionario.TryAdd(6,"El Kybalion");
            miDiccionario.TryAdd(7,"Ciudades Intraterrenas");
            miDiccionario.TryAdd(8,"El Club Dumas");
            foreach (var item in miDiccionario)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

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
            RecorrerDiccionarios();
        }

    }
}

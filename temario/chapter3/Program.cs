using System;
using enumeraciones;
using System.Collections.Generic;

namespace chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
            MockTestB();
            MockTestC();
        }
        
        static void MockTestC()
        {
            LinkedList<float> lista = new LinkedList<float>();
            lista.AddFirst(5.2f);
            lista.AddLast(6.0f);
            foreach(var elemento in lista)
            {
                Console.WriteLine("{0}",elemento);
            }

            Console.WriteLine();
            HashSet<int> myHashSet = new HashSet<int>();
            myHashSet.Add(34);
            myHashSet.Add(35);
            myHashSet.Add(36);
            foreach(var itemHash in myHashSet)
            {
                Console.WriteLine("{0}",itemHash);
            }

            Cafes myCafe = Cafes.MEDIANO;
            Console.WriteLine("Cafe: {0}",myCafe);
            if(myCafe == Cafes.MEDIANO)
            {
                Console.WriteLine("Mi cafe es de tamaño mediano");
            }

            switch(myCafe)
            {
                case Cafes.CHICO: 
                Console.WriteLine("Este cafe es de tamaño chico");break;
                case Cafes.MEDIANO: 
                Console.WriteLine("Este cafe es de tipo mediano");break;
                case Cafes.GRANDE: 
                Console.WriteLine("Este cafe es de tipo grande");break;
                case Cafes.JUMBO: 
                Console.WriteLine("Este cafe es de tipo jumbo");break;
                default: 
                Console.WriteLine("Ese cafe esta en vias de no existir");break;
            }

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

            lista.Add(21);
            lista.Add(22);
            Console.WriteLine();
            foreach(var numero in lista)
            {
                Console.WriteLine("Hola no. {0}",numero);
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

        static Stack<string> GetSatck()
        {
            Stack<string> nombresStack = new Stack<string>();
            nombresStack.Push("Ernesto");
            nombresStack.Push("Gimena");
            nombresStack.Push("Ernesto");
            nombresStack.Push("Gimena");
            nombresStack.Push("Ernesto");
            return nombresStack;
        }

        static void MockTestB()
        {
            var miStack = GetSatck();
            Console.WriteLine("\nRecorriendo Stack:");
            var lleno = miStack.Count>0? "Stack lleno" : "Stack vacio";
            Console.WriteLine("{0}",lleno);
            foreach(var item in miStack)
            {
                Console.WriteLine("{0}",item);
            }
            miStack.Pop();
            miStack.Pop();
            miStack.Pop();
            Console.WriteLine();
            foreach(var item in miStack)
            {
                Console.WriteLine("{0}",item);
            }
            Console.WriteLine("Limpiando todo el Stack:");
            miStack.Clear();
            string vacio = miStack.Count>0? "El stack esta lleno" : "El stack no esta lleno";
            miStack.Push("Tomas");
            miStack.Push("Sergio");
            miStack.Push("Luisa Gimena");
            miStack.Push("Tania");
            foreach(var item in miStack)
            {
                Console.WriteLine("{0}",item);
            }

            var existeGimena = miStack.Contains("Luisa Gimena");
            if(existeGimena == true)
            {
                Console.WriteLine("Hola Luisa Gimena !!!");
            }

            if(miStack.Contains("Tomas") || miStack.Contains("Tomasina"))
            {
                Console.WriteLine("Hola, amigos !!!");
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

using System;
using System.Linq;

namespace chapter2
{
    class Program
    {
        public static readonly int MAX = 100;
        static void Main(string[] args)
        {
            SentenciasIf();
            SentenciasFor();
            SentenciasWhile();
        }
        
        
        static bool OperaA(int x, int y) => x > y;

        static string OperaB(string str1, string str2) => str1.Equals(str2)? "Son iguales: "+str1+" y "+str2 : "Son diferentes: "+str1+" y "+str2;
        
        static bool OperaC(string str1, string str2) => str2.Equals(str1);

        static bool OperaD(char entrada) => Char.IsDigit(entrada);


        static void SentenciasFor()
        {

            int contador = 0; 
            for (; contador < MAX; Console.WriteLine("Contador:" + contador++)) 
            { }
        }

        static void CicloInfinitoWhile()
        {
            while(true)
            {
                Console.WriteLine("101010101");
            }
        }

        static void CicloInfinitoFor()
        {
            for(;;)
            {
                Console.WriteLine("101010101");
            }
        }

        static void SentenciasWhile()
        {
            int cont = 0;
            Console.WriteLine("Ciclo while:");
            while(cont++ < MAX)
            {
                if(cont%4==0)
                {
                    Console.WriteLine("Cumple la condicion: {0}",cont);
                }
            }
        }
        static void SentenciasIf()
        {
            
            int[] mis_numeros = { 0, 1, 2, 3, 4, 5 };
            var limite = 3;
            var consulta = from item in mis_numeros where item <= limite select item;
            int cantidad = consulta.Count();
            int dato = consulta.ElementAt(0);
            Console.WriteLine("Limite: {0}, Consulta en 0:",limite,dato);
            

            var mi_char ='\u0065';
            char caracter = (char) mi_char;
            if(Char.IsLetter(caracter))
            {
                if(Char.IsLower(caracter))
                {
                    Console.WriteLine("El caracter {0} esta en minuscula.",caracter);
                }
                else
                {
                    Console.WriteLine("El caracter {0} esta en mayuscula.",caracter);
                }
            }
            else
            {
                Console.WriteLine("El caracter {0}  no es aun caracter del alfabeto.",caracter);
            }

            char entra = '\u0111';
            if(OperaD(entra) == true)
            {
                Console.WriteLine("{0} es un digito",entra);
            }
            else
            {
                Console.WriteLine("{0} no es un digito",entra);
            }


            entra = '6';
            if(OperaD(entra) == true)
            {
                Console.WriteLine("{0} es un digito",entra);
            }
            else
            {
                Console.WriteLine("{0} no es un digito",entra);
            }

            string your_name = "C Sharp";
            if(OperaC(your_name,"C#") == true)
            {
                Console.WriteLine("{0} y C#  son iguales!!",your_name);
            }
            else
            {
                Console.WriteLine("{0} y C#  no son iguales!!",your_name);   
            }

            var numerosX = new int[] {32,41,54,67,78,83,99,102,150,210,235,363,674};
            var numerosY = new int[] {39,40,59,61,78,81,90,109,145,220,245,333,654};
            
            for(var i = numerosX.Length - 1; i >= 0; i--)
            {
                if(OperaA(numerosX[i], numerosY[i]) == true)
                {
                    Console.WriteLine("--> X: {0} es mayor",numerosX[i]);
                }
                else
                {
                    Console.WriteLine("--> Y: {0} es mayor",numerosY[i]);
                }
                    
            }
            
            bool condicion = 101 > 100;//true
            bool falso = true;
            
            if(condicion == true)
            {
                Console.WriteLine("Es verdadero");
            }
            
            if(falso)
            {
                Console.WriteLine("Hola, amigos programadores!!!");
            }
            
            int opc = 1;
            string card="";
            switch(opc)
            {
                case 1:
                    card = "Aleph";
                    break;
                case 2:
                    card = "Lamed";
                    break;
                default:
                    card = "Gimel";
                    break;
            }
            Console.WriteLine("{0}",card);

            var nombresX = new string[]{"Juan","Miguel","Pedro","Hugo","Tomas","Julia","Omar","Oscar","Ricardo"};
            var nombresY = new string[]{"John","Michael","Pedro","Huge","Tomas","Julian","Omar","Oscar","Richard"};
            for(int c = 0; c < nombresY.Length; c++)
            {
                Console.WriteLine(OperaB(nombresX[c],nombresY[c]));
            }

            int a = 23;
            int b = 21;
            if(a > b)
            {
                Console.WriteLine("{0} es mayor a {1}",a,b);
            }
            else if(b > a)
            {
                Console.WriteLine("{0} es mayor a {1}",b,a);
            }
            else
            {
                Console.WriteLine("{0} y {1} son iguales",a,b);
            }

            a = 4;
            b = 10;
            if(OperaA(a,b))
            {
                Console.WriteLine("{0} es mayor a {1}",a,b);
            }
            else if(OperaA(b,a))
            {
                Console.WriteLine("{0} es mayor a {1}",b,a);
            }
            else
            {
                Console.WriteLine("{0} y {1} son iguales",a,b);
            }

            a = 33;
            b = 33;
            if(OperaA(a,b))
            {
                Console.WriteLine("{0} es mayor a {1}",a,b);
            }
            else if(OperaA(b,a))
            {
                Console.WriteLine("{0} es mayor a {1}",b,a);
            }
            else
            {
                Console.WriteLine("{0} y {1} son iguales",a,b);
            }

            a = 101;
            b = 99;
            if(OperaA(a,100) == true)
            {
                Console.WriteLine("{0} es mayor a 100",a);
                if(OperaA(b,90) == true)
                {
                    Console.WriteLine("{0} es mayor a 90",b);
                }
                else
                {
                    Console.WriteLine("{0} es menor a 90",b);
                }
            }

            DateTime dateTime = new DateTime(2019, 9, 26);
            if(DateTime.Today == dateTime ){
                Console.WriteLine("1. Hoy es {0}",dateTime);
            }else
            {
                Console.WriteLine("2. Hoy es {0}",dateTime);
            }

            char opcion = 'x';
            switch (opcion)
            {
                case 'x': Console.WriteLine("Elegiste x"); break;
                case '\u0099': Console.WriteLine("Elegiste \u0099"); break;
                default: Console.WriteLine("Elegiste \u0049"); break;
            }

            bool booleano = false;
            if("Europa".Equals("EUropa"))
            {
                booleano = true;
            }
            Console.WriteLine(booleano? "Las cadenas son iguales" : "Las cadenas no son iguales");

        }
    }
}

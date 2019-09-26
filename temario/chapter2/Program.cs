using System;

namespace chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            SentenciasIf();
        }
        
        
        static bool OperaA(int x, int y) => x > y;

        static string OperaB(string str1, string str2) => str1.Equals(str2)? "Son iguales: "+str1+" y "+str2 : "Son diferentes: "+str1+" y "+str2;
        
        static bool OperaC(string str1, string str2) => str2.Equals(str1);
        static void SentenciasIf()
        {
            
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

        }
    }
}

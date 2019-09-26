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
        
        static void SentenciasIf()
        {
            
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
            switch(opc){
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
        }
    }
}

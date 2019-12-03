using System;
using System.Collections.Generic;

namespace diccionarios
{
   
   public class Diccionario:Dictionary<int, string>
   {
       public Diccionario()
       {
         Console.WriteLine("Objeto Diccionario creado e inicializado");
       }
       ~Diccionario(){}

       public override string ToString()
       {
         return "Diccionario";
       } 

       
   }

}

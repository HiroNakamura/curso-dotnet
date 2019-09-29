using System;

namespace clases
{
    public class Canario: Oviparo
    {
        public Canario(string nombre):base(nombre)
        {
            Console.WriteLine("Objeto Canario creado e inicializado");
        }

        ~Canario(){}


    }
}
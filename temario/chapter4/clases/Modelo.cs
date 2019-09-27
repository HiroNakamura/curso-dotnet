using System;


namespace clases
{
    class Modelo
    {
        public Modelo()
        {
            Console.WriteLine("Objeto Modelo creado e inicializado");
        }
        ~Modelo(){}

        public string Nombre
        {
            get;set;
        }
    }
}
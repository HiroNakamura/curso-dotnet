using System;


namespace clases
{
    class Modelo
    {
        public Modelo()
        {
            Console.WriteLine("Objeto Modelo creado e inicializado");
        }

        public Modelo(string nombre)
        {
            Nombre = nombre;
        }
        ~Modelo(){}

        public string Nombre
        {
            get;set;
        }

        public string GetModelo()
        {
            return "Modelo{nombre = "+Nombre+"}";
        }

        public virtual void Mostrar()
        {
            Console.WriteLine(GetModelo());
        }
    }
}
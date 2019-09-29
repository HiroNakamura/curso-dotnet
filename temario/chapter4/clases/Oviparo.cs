using System;

namespace clases
{
    public class Oviparo
    {
        public Oviparo(string nombre)
        {
            Nombre = nombre;
            Console.WriteLine("Objeto Oviparo creado e inicializado");
            Console.WriteLine("{0}",ToString());
        }

        ~Oviparo(){}

        public string Nombre
        {
            get;set;
        }

        public override string ToString()
        {
            return String.Format("Ave[ Nombre = {0} ]",Nombre);
        }
    }
}
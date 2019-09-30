using System;
using excepciones;

namespace clases
{
    public class Ritmos
    {
        public Ritmos(){}

        ~Ritmos(){}

        public int Edad
        {
            get;set;
        }

        public void mostrarCalculo()
        {
            if(Edad == 0)
            {
                throw (new MyExcepcion("La edad no deberia ser cero!!"));
            }
            else
            {
                Console.WriteLine("Edad = {0}",Edad);
            }
        }
    }
}
using System;
using interfaces;

namespace clases
{
    public class CalculoImpl: ICalculo
    {
        public CalculoImpl()
        {
            Console.WriteLine("El objeto CalculoImpl se ha creado e iniciaizado");
        }

        ~CalculoImpl(){}

        public bool EsPar(int numero) => numero%2 == 0;
        
    }
}
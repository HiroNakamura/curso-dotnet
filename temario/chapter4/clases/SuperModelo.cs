using System;
using System.Collections.Generic;


namespace clases
{
    public class SuperModelo:Modelo
    {
        public SuperModelo()
        {
            Console.WriteLine("El objeto SuperModelo se ha creado e inicializado");
        }
        ~SuperModelo(){}
        public override void Mostrar()
        {
            base.Mostrar();
            if(GetLista.Count > 0 && GetLista!=null)
            {
                Console.WriteLine("Lista llena !!");
                foreach(var item in GetLista)
                {
                    Console.WriteLine("{0}",item);
                }
            }
        }

        public List<string> GetLista
        {
            get;set;
        }
    }
}
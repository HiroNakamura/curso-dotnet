using System;

namespace clases
{
    public class Y : X
    {
        public Y()
        {
            Console.WriteLine("Se ha creado e inicializado el objeto Y");
        }

        ~Y(){}

        public string Grupo
        {
            get; set;
        }

        public override string ToString()
        {
            return base.ToString()
            +" - "+String.Format("Y::grupo = {0}",Grupo);
        } 
    }
}
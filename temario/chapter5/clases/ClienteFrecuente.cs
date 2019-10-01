using System;

namespace clases
{
    public class ClienteFrecuente:Cliente
    {
        public ClienteFrecuente():base(){
            Console.WriteLine("Objeto ClienteFrecuente creado e inicializado");
        }

        public ClienteFrecuente(long id, string nombre, string apellido, DateTime fecha):base(id,nombre,apellido){
            Fecha = fecha;
            Console.WriteLine("Objeto ClienteFrecuente creado e inicializado");
        }

        ~ClienteFrecuente(){}

        public DateTime Fecha
        {
            get;set;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("-Fecha = {0}",Fecha);
        }

    }
}
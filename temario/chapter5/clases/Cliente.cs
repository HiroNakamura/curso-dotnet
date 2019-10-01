using System;

namespace clases
{
    public class Cliente
    {
        public Cliente()
        {
            Console.WriteLine("Objeto Cliente creado e inicializado");
        }
        ~Cliente(){}

        public Cliente(long id, string nombre, string apellido):base()
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
        }

        public long ID
        {
            get;set;
        } 

        public string Nombre
        {
            get;set;
        }

        public string Apellido
        {
            get;set;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}",ID, Nombre, Apellido);
        }
    }
}
using System;

namespace clases
{
    public class X
    {
        public X()
        {
            Console.WriteLine("Se ha creado e inicializado el objeto X");
        }

        public X(string version)
        {
            Version = version;
        }

        ~X(){}

        public string Version
        {
            get;set;
        }

        public override string ToString()
        {
            return String.Format("X{ version = {0} }",Version);
        }
    }
}
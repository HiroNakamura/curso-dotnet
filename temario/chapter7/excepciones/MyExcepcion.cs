using System;

namespace excepciones
{
    public class MyExcepcion: Exception
    {
        public MyExcepcion(string message): base(message){}

        ~MyExcepcion(){}
    }
}
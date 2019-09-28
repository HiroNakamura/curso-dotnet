using System;
using interfaces;

namespace clases
{
    class ServicioAImpl: ServicioA,ServicioB
    {

        public ServicioAImpl()
        {
            Console.WriteLine("Se ha creado e inicializado el objeto ServicioAImpl");
        }

        public ServicioAImpl(int a, int b)
        {
            X = a;
            Y = b;
        }

        ~ServicioAImpl(){}
        public int X
        {
            get; set;
        }

        public int Y
        {
            get; set;
        }
        public decimal Operacion(int a, int b)
        {
            return a+b;
        }

        public void Mostrar()
        {
            Console.WriteLine("X = {0}, Y = {1}",this.X,this.Y);
            Console.WriteLine("El resultado de la operacion es: {0}",Operacion(X, Y));
        }


    }
}
using System;
using interfaces;

namespace clases
{
    public class ServicioImplA:IServicio
    {
        public ServicioImplA(){}

        ~ServicioImplA(){}
        public void Mensaje()=> Console.WriteLine("Hola, mundo!!");
        public void Mensaje(string msg)=> Console.WriteLine("Hola, {0}",msg);
        public bool Mensaje(string msg, char car)=>  car.ToString().Equals(msg);
        public int Mensaje(char c)=> Char.IsNumber(c)? 1 : 0;
    }
}
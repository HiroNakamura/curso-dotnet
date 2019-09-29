using System;

namespace chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
        }

        static void MockTestA()
        {
            Console.WriteLine("************** Excepciones **************");
            object obj = null;
            object tipo = null;
            string except = "";

            try
            {
                tipo = obj.GetType();
                Console.WriteLine("Tipo = {0}",tipo);
            }
            catch(Exception ex)
            {
                except = ex.StackTrace;
                Console.WriteLine("Error, ha ocurrido una excepcion = {0}",ex.Message);
            }
            finally
            {
                Console.WriteLine("El bloque ha finalizado");
                Console.WriteLine("Excepcion = {0}",except);
            }

            Console.WriteLine("*********************************************");

            int x = 5;
            int y = 0;
            try
            {
                int divisionCero = x/y;
            }
            catch(DivideByZeroException ex)
            {
                except = ex.StackTrace;
                Console.WriteLine("Error al dividir x cero = {0}",ex.Message);
                Console.WriteLine("Excepcion = {0}",except);
            }

            Console.WriteLine("*********************************************");

            try
            {
                Console.WriteLine("Hola");
            }
            finally
            {
                Console.WriteLine("Good bye!!");
            }
            Console.WriteLine("*********************************************");

            int[] numeros = new int[3];//0,1,2
            try
            {
                Console.WriteLine("{0}",numeros[3]);
            }
            catch(IndexOutOfRangeException ex)
            {
                except = ex.StackTrace;
                Console.WriteLine("Error al acceder a un indice inexistente = {0}",ex.Message);
                Console.WriteLine("Excepcion = {0}",except);
            }
            finally
            {
                Console.WriteLine("Ha finalizado el bloque!!");
            }




        }
    }
}

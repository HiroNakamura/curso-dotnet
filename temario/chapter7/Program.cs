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
            object obj = null;
            object tipo = null;
            try
            {
                tipo = obj.GetType();
                Console.WriteLine("Tipo = {0}",tipo);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error = {0}",ex.Message);
            }
            finally
            {
                Console.WriteLine("El bloque ha finalizado");
            }

            try
            {
                int divisionCero = 5/0;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error = {0}",ex.Message);
            }

            

        }
    }
}
